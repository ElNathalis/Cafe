using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3DB
{
    public partial class enter : Form
    {
        private string NpgsqlCon = "server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;";
        public enter()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dolg_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sotr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int KodSotrudnika = (int)sotr.Value;
            int KodDolzhnosti = (int)dolg.Value;

            if (CheckSotrExists(KodSotrudnika, KodDolzhnosti))
            {
                 //Если сотрудник найден, открываем новую форму
               if (KodDolzhnosti == 4 || KodDolzhnosti == 3)
                {
                    zakaz newForm = new zakaz();
                    newForm.Show();
                }
                else if (KodDolzhnosti == 1 || KodDolzhnosti == 2 || KodDolzhnosti == 5 || KodDolzhnosti == 6)
                {
                    upravl newForm = new upravl();
                    newForm.Show();
                }
              //else if (KodDolzhnosti == 3)
               // {
               //     sbarista newForm = new sbarista();
               //     newForm.Show();
               // }
                else
                {
                    MessageBox.Show("Нет специальных форм", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                // Если сотрудник не найден, показываем сообщение
                MessageBox.Show("Сотрудник не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CheckSotrExists(int s, int d)
        {
            using (var connection = new NpgsqlConnection(NpgsqlCon))
            {
                string query = "SELECT COUNT(*) FROM Sotrudnik WHERE KodSotrudnika = @EmployeeCode AND KodDolzhnosti = @PositionCode AND status = true";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeCode", s);
                    command.Parameters.AddWithValue("@PositionCode", d);
                    connection.Open();

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; // Возвращаем true, если sotrudnik найден
                }
            }
        }

        private void enter_Load(object sender, EventArgs e)
        {

        }
    }
}
