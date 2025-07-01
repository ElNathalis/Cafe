using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp3DB
{
    
    public partial class diagr : Form
    {
        private string connectionString = "server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;";
        public diagr()
        {
            InitializeComponent();
            LoadSalaryDistribution();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void LoadSalaryDistribution()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT Nazvanie, Stavka FROM Dolzhnost WHERE Stavka IS NOT NULL", conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Настройка диаграммы
                        chart1.Series.Clear();
                        Series series = chart1.Series.Add("Ставки");
                        series.ChartType = SeriesChartType.Pie;

                        foreach (DataRow row in dt.Rows)
                        {
                            string positionName = row["Nazvanie"].ToString();
                            decimal salaryRate = Convert.ToDecimal(row["Stavka"]);

                            series.Points.AddXY(positionName, salaryRate);
                        }

                        // Настройка внешнего вида диаграммы
                        chart1.Legends[0].Docking = Docking.Top;
                        chart1.Titles.Add("Распределение ставок по должностям");
                    }
                }
            }
        }
    }
}