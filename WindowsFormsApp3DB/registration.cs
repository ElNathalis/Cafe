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
    //private string NpgsqlCon = "server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;";
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void InitializeFavoriteTypeComboBox()
        {
            // Добавление допустимых значений в ComboBox
            comboFavoriteType.Items.Add("Молочный кофе");
            comboFavoriteType.Items.Add("Крепкий кофе");
            comboFavoriteType.Items.Add("Не кофе и десерты");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Получение данных из текстовых полей
            string imya = name.Text.Trim();
            string telefon = telefonn.Text.Trim();
            string elPochta = email.Text.Trim();

            // Получение выбранного значения из ComboBox
            string favoriteType = comboFavoriteType.SelectedItem?.ToString();

            // Проверка на заполненность полей
            if (string.IsNullOrEmpty(imya) ||
                string.IsNullOrEmpty(telefon) ||
                string.IsNullOrEmpty(elPochta) ||
                string.IsNullOrEmpty(favoriteType))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            // Проверка формата телефона (например, 11 цифр)
            if (telefon.Length != 11 || !long.TryParse(telefon, out _))
            {
                MessageBox.Show("Телефон должен содержать 11 цифр.");
                return;
            }

            // Проверка формата электронной почты
            if (!IsValidEmail(elPochta))
            {
                MessageBox.Show("Введите корректный адрес электронной почты.");
                return;
            }

            // Подключение к базе данных и выполнение запроса
            using (var conn = new NpgsqlConnection("server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO Klient (Imya, Telefon, ElPochta, DataRegistracii, FavoriteTipe) VALUES (@imya, @telefon, @elPochta, CURRENT_DATE, @favoriteType)", conn))
                {
                    cmd.Parameters.AddWithValue("imya", imya);
                    cmd.Parameters.AddWithValue("telefon", telefon);
                    cmd.Parameters.AddWithValue("elPochta", elPochta);
                    cmd.Parameters.AddWithValue("favoriteType", favoriteType);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Клиент успешно добавлен!");
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении клиента: {ex.Message}");
                    }
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}