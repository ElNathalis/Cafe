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

namespace WindowsFormsApp3DB
{
    public partial class PARTITION : Form
    {
        private string connectionString = "server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;";
        public PARTITION()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAveragePrices();
        }
        private void LoadAveragePrices()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"
                SELECT 
                    Tipe,
                    ImyaPozitsii,
                    Tsena,
                    AVG(Tsena) OVER (PARTITION BY Tipe) AS AveragePrice
                FROM 
                    Menyu", conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                        // Установка заголовков колонок на латинице
                        dataGridView1.Columns["Tipe"].HeaderText = "Тип";
                        dataGridView1.Columns["ImyaPozitsii"].HeaderText = "Название позиции";
                        dataGridView1.Columns["Tsena"].HeaderText = "Цена";
                        dataGridView1.Columns["AveragePrice"].HeaderText = "Средняя цена";
                    }
                }
            }
        }
    }
}

