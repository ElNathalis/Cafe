using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3DB
{
    public partial class sotrs : Form
    {
        private string connectionString = "server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;";
        private int currentEmployeeId;
        public sotrs()
        {
            InitializeComponent();
            LoadActiveEmployees();
        }
        private void LoadActiveEmployees()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM Sotrudnik WHERE Status = TRUE", conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                        dataGridView1.Columns["KodSotrudnika"].HeaderText = "Код Сотрудника";
                        dataGridView1.Columns["Familiya"].HeaderText = "Фамилия";
                        dataGridView1.Columns["Imya"].HeaderText = "Имя";
                        dataGridView1.Columns["Otchestvo"].HeaderText = "Отчество";
                        dataGridView1.Columns["DataRozhdeniya"].HeaderText = "Дата рождения";
                        dataGridView1.Columns["ElPochta"].HeaderText = "Email";
                        dataGridView1.Columns["Telefon"].HeaderText = "телефон";
                        dataGridView1.Columns["Status"].HeaderText = "статус";
                        dataGridView1.Columns["Foto"].HeaderText = "фото";
                    }
                }
            }
        }
        private void LoadFiredEmployees()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM Sotrudnik WHERE Status = FALSE", conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                        dataGridView1.Columns["KodSotrudnika"].HeaderText = "Код Сотрудника";
                        dataGridView1.Columns["Familiya"].HeaderText = "Фамилия";
                        dataGridView1.Columns["Imya"].HeaderText = "Имя";
                        dataGridView1.Columns["Otchestvo"].HeaderText = "Отчество";
                        dataGridView1.Columns["DataRozhdeniya"].HeaderText = "Дата рождения";
                        dataGridView1.Columns["ElPochta"].HeaderText = "Email";
                        dataGridView1.Columns["Telefon"].HeaderText = "телефон";
                        dataGridView1.Columns["Status"].HeaderText = "статус";
                        dataGridView1.Columns["Foto"].HeaderText = "фото";
                    }
                }
            }
        }
        private void uvolit_Click(object sender, EventArgs e)
        {
            currentEmployeeId = (int)numericUpDown1.Value;
            if (MessageBox.Show("Вы уверены, что хотите уволить этого сотрудника?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("UPDATE Sotrudnik SET Status=FALSE WHERE KodSotrudnika=@employeeId", conn))
                    {
                        cmd.Parameters.AddWithValue("employeeId", currentEmployeeId);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Сотрудник успешно уволен!");
                            LoadActiveEmployees(); // Обновляем таблицу
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show($"Ошибка при увольнении сотрудника: {ex.Message}");
                        }
                    }
                }
            }
        }
        private void deletephoto_Click(object sender, EventArgs e)
        {
            currentEmployeeId = (int)numericUpDown1.Value;
            if (MessageBox.Show("Вы уверены, что хотите удалить фото этого сотрудника?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("UPDATE Sotrudnik SET Foto=NULL WHERE KodSotrudnika=@employeeId", conn))
                    {
                        cmd.Parameters.AddWithValue("employeeId", currentEmployeeId);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            //pictureBoxFoto.Image = null; // Удаляем изображение из PictureBox
                            MessageBox.Show("Фото успешно удалено!");
                            LoadActiveEmployees(); // Обновляем таблицу
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show($"Ошибка при удалении фото: {ex.Message}");
                        }
                    }
                }
            }
        }
        private void spuvol_Click(object sender, EventArgs e)
        {
            LoadFiredEmployees(); // Загружаем уволенных сотрудников
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sotrs_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

