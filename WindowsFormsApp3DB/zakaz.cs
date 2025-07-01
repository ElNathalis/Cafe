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
    public partial class zakaz : Form
    {
        private string connectionString = "server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;";
        public zakaz()
        {
            InitializeComponent();
        }


        private void zakaz_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int kartaKlienta = (int)numericUpDown2.Value;
            int kodMenyu = (int)numericUpDown1.Value;



            // Получаем информацию о клиенте и позиции меню
            (decimal totalPrice, decimal discount, decimal initialPrice) = GetOrderTotal(kartaKlienta, kodMenyu);

            // Отображаем результаты
            label3.Text = $"Начальная цена: {initialPrice:C}"; // Форматируем как валюту
            label4.Text = $"Размер скидки: {discount:C}"; // Форматируем как валюту
            label5.Text = $"Сумма заказа: {totalPrice:C}"; // Форматируем как валюту

            // Записываем заказ в таблицу "Zakaz"
            SaveOrder(kartaKlienta, kodMenyu, totalPrice);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private (decimal totalPrice, decimal discount, decimal initialPrice) GetOrderTotal(int kartaKlienta, int kodMenyu)
        {
            decimal price = 0;
            DateTime registrationDate;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Получаем цену позиции меню
                using (var cmd = new NpgsqlCommand("SELECT Tsena FROM Menyu WHERE KodMenyu = @kodMenyu", conn))
                {
                    cmd.Parameters.AddWithValue("kodMenyu", kodMenyu);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        price = Convert.ToDecimal(result);
                    }
                    else
                    {
                        MessageBox.Show("Блюдо не найдено.");
                        return (0, 0, 0); // Возвращаем нулевые значения
                    }
                }

                // Получаем дату регистрации клиента
                using (var cmd = new NpgsqlCommand("SELECT DataRegistracii FROM Klient WHERE KartaKlienta = @kartaKlienta", conn))
                {
                    cmd.Parameters.AddWithValue("kartaKlienta", kartaKlienta);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        registrationDate = Convert.ToDateTime(result);
                    }
                    else
                    {
                        MessageBox.Show("Клиент не найден.");
                        return (0, 0, 0); // Возвращаем нулевые значения
                    }
                }
            }

            // Рассчитываем скидку
            decimal discount = 0;
            if ((DateTime.Now - registrationDate).TotalDays < 7)
            {
                discount = price * 0.10m; // Скидка 10%
            }

            decimal totalPrice = price - discount; // Итоговая сумма с учетом скидки

            return (totalPrice, discount, price); // Возвращаем итоговую сумму, размер скидки и начальную цену
        }
        private void SaveOrder(int kartaKlienta, int kodMenyu, decimal totalPrice)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO Zakaz (KartaKlienta, KodMenyu, Skidka) VALUES (@kartaKlienta, @kodMenyu, @skidka)", conn))
                {
                    cmd.Parameters.AddWithValue("kartaKlienta", kartaKlienta);
                    cmd.Parameters.AddWithValue("kodMenyu", kodMenyu);

                    // Скидка рассчитывается как разница между начальной ценой и итоговой ценой
                    decimal initialPrice = GetInitialPrice(kodMenyu);
                    decimal discount = initialPrice - totalPrice;

                    cmd.Parameters.AddWithValue("skidka", discount);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Заказ успешно сохранен!");
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении заказа: {ex.Message}");
                    }
                }
            }
        }
        private decimal GetInitialPrice(int kodMenyu)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT Tsena FROM Menyu WHERE KodMenyu = @kodMenyu", conn))
                {
                    cmd.Parameters.AddWithValue("kodMenyu", kodMenyu);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        return Convert.ToDecimal(result);

                    return 0; // Если не найдено
                }
            }
        }

    }
}
