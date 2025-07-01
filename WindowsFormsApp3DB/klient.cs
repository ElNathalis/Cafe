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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3DB
{
    public partial class klient : Form
    {
        //NpgsqlConnection NpgsqlCon = new NpgsqlConnection("server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;");
        private string NpgsqlCon = "server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;";
        public klient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string cardNumber = textBox1.Text;

            if (CheckCardExists(cardNumber))
            {
                // Если карта найдена, открываем новую форму
                klientcab newForm = new klientcab(cardNumber);
                newForm.Show();
                this.Hide(); // Скрываем текущую форму
            }
            else
            {
                // Если карта не найдена, выводим сообщение
                MessageBox.Show("Клиент не найден :( \nПроверьте введенные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CheckCardExists(string cardNumber)
        {
            using (var connection = new NpgsqlConnection(NpgsqlCon))
            {
                string query = "SELECT COUNT(*) FROM Klient WHERE kartaklienta = @nomer_karty";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomer_karty", int.Parse(cardNumber));
                    connection.Open();

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; // Возвращаем true, если клиент найден
                }
            }
        }


    }


    //klientcab newForm = new klientcab();
           // newForm.Show();
}
    

