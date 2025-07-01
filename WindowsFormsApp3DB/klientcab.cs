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
    public partial class klientcab : Form
    {
        private string NpgsqlCon = "server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;";
        private string cardNumber;

        public klientcab(string cardNumber)
        {
            InitializeComponent();
            this.cardNumber = cardNumber;
            klientcab_Load();
        }

        private void klientcab_Load()
        {
            // Загрузите информацию о клиенте по номеру карты из базы данных и отобразите её на форме
            // Например:
            lblCardNumber.Text = $"Номер вашей карты: {cardNumber}";
            lblnameKlient.Text = $"Здравствуйте, {GetClientName(cardNumber)}!";
            recom.Text = $"Думаем, вам стоит попробовать \n{GetRec(cardNumber)}.";
            elpochta.Text = $"Ваша почта: {GetPochta(cardNumber)}";
            phone.Text = $"Ваш номер телефона: {GetPhone(cardNumber)}";
            date.Text = $"Дата создания карты: {GetDate(cardNumber)}";
            skidka.Text = $"Скидка: {GetSkidka(cardNumber)}%";
            // Здесь можно добавить код для получения и отображения других данных о клиенте из базы данных
        }

        private void lblcardNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblnameKlient_Click(object sender, EventArgs e)
        {

        }

        private string GetClientName(string cardNumber)
        {
            using (var connection = new NpgsqlConnection(NpgsqlCon))
            {
                string query = "SELECT Imya FROM Klient WHERE kartaklienta = @nomer_karty";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomer_karty", int.Parse(cardNumber));
                    connection.Open();

                    object result = command.ExecuteScalar();
                    return result.ToString(); // Возвращаем имя клиента как строку                                       
                }
            }
        }

        private string GetRec(string cardNumber)
        {
            using (var connection = new NpgsqlConnection(NpgsqlCon))
            {
                string query = "SELECT favoritetipe FROM Klient where kartaklienta = @nomer_karty";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomer_karty", int.Parse(cardNumber));
                    connection.Open();

                    object result = command.ExecuteScalar();
                    result = result.ToString(); // Возвращаем имя клиента как строку
                    if (result.ToString() == "молочный кофе") return "латте, раф, флэт уайт и капучино";
                    if (result.ToString() == "крепкий кофе") return "эспрессо и американо";
                    else return "какао и десерты";

                }
            }
        }


        private string GetPochta(string cardNumber)
        {
            using (var connection = new NpgsqlConnection(NpgsqlCon))
            {
                string query = "SELECT elpochta FROM Klient where kartaklienta = @nomer_karty";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomer_karty", int.Parse(cardNumber));
                    connection.Open();

                    object result = command.ExecuteScalar();
                    return result.ToString(); ;

                }
            }
        }

        private string GetPhone(string cardNumber)
        {
            using (var connection = new NpgsqlConnection(NpgsqlCon))
            {
                string query = "SELECT telefon FROM Klient where kartaklienta = @nomer_karty";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomer_karty", int.Parse(cardNumber));
                    connection.Open();

                    object result = command.ExecuteScalar();
                    return result.ToString(); ;

                }
            }
        }

        private string GetDate(string cardNumber)
        {
            using (var connection = new NpgsqlConnection(NpgsqlCon))
            {
                string query = "SELECT dataregistracii as day FROM Klient where kartaklienta = @nomer_karty";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomer_karty", int.Parse(cardNumber));
                    connection.Open();

                    object result = command.ExecuteScalar();
                    return result.ToString(); ;

                }
            }
        }

        private string GetSkidka(string cardNumber)
        {
            using (var connection = new NpgsqlConnection(NpgsqlCon))
            {
                string query = "SELECT " +
                    "CASE WHEN Klient.dataregistracii >= CURRENT_DATE - INTERVAL '7 DAYS' THEN 10.00  ELSE 0.00 " +
                    "END AS discount FROM Klient WHERE  kartaklienta =  @nomer_karty";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomer_karty", int.Parse(cardNumber));
                    connection.Open();

                    object result = command.ExecuteScalar();
                    return result.ToString(); ;

                }
            }
        }

        private void recom_Click(object sender, EventArgs e)
        {

        }

        private void elpochta_Click(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void skidka_Click(object sender, EventArgs e)
        {

        }
    }
}
