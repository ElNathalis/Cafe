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
    public partial class vsepost : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;";
        public vsepost()
        {
            InitializeComponent();
            LoadSupplies();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadSupplies()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    p.KodPostavki,
                    ps.NazvanieKompanii AS Postavshchik,
                    i.Nazvanieingredienta AS Ingredient,
                    s.Familiya AS Sotrudnik,
                    p.DataPostavki,
                    p.KolichestvoUpakovok
                FROM 
                    Postavka p
                JOIN 
                    Postavshchik ps ON p.KodPostavshchika = ps.KodPostavshchika
                JOIN 
                    Ingredient i ON p.KodIngredienta = i.KodIngredienta
                JOIN 
                    Sotrudnik s ON p.KodSotrudnika = s.KodSotrudnika";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    connection.Open();
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt; // Заполняем DataGridView данными

                        // Установка заголовков столбцов на кириллице
                        dataGridView1.Columns[0].HeaderText = "Код Поставки";
                        dataGridView1.Columns[1].HeaderText = "Поставщик";
                        dataGridView1.Columns[2].HeaderText = "Ингредиент";
                        dataGridView1.Columns[3].HeaderText = "Сотрудник";
                        dataGridView1.Columns[4].HeaderText = "Дата Поставки";
                        dataGridView1.Columns[5].HeaderText = "Количество Упаковок";
                    }
                }
            }
        }
    }
}
