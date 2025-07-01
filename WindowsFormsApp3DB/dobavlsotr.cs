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
    public partial class dobavlsotr : Form
    {
        public dobavlsotr()
        {
            InitializeComponent();
        }

        private void dobavlsotr_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtOtchestvo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtElPochta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение данных из текстовых полей
            string familiya = txtFamiliya.Text.Trim();
            string imya = txtImya.Text.Trim();
            string otchestvo = txtOtchestvo.Text.Trim();
            DateTime dataRozhdeniya = dtpDataRozhdeniya.Value;
            string elPochta = txtElPochta.Text.Trim();
            string telefon = txtTelefon.Text.Trim();

            // Статус автоматически устанавливается как TRUE
            bool status = true;

            // Проверка на заполненность полей
            if (string.IsNullOrEmpty(familiya) ||
                string.IsNullOrEmpty(imya) ||
                string.IsNullOrEmpty(elPochta) ||
                string.IsNullOrEmpty(telefon))
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

            // Проверка возраста
            if (dataRozhdeniya >= DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("Сотрудник должен быть старше 18 лет.");
                return;
            }

            // Подключение к базе данных и выполнение запроса
            using (var conn = new NpgsqlConnection("server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO Sotrudnik (Familiya, Imya, Otchestvo, DataRozhdeniya, Foto, ElPochta, Telefon, Status, DataUstroystva, KodDolzhnosti) " +
                    "VALUES (@familiya, @imya, @otchestvo, @dataRozhdeniya, @foto, @elPochta, @telefon, @status, CURRENT_DATE, @KodDolzhnosti)", conn))
                {
                    cmd.Parameters.AddWithValue("familiya", familiya);
                    cmd.Parameters.AddWithValue("imya", imya);
                    cmd.Parameters.AddWithValue("otchestvo", otchestvo);
                    cmd.Parameters.AddWithValue("dataRozhdeniya", dataRozhdeniya);
                    cmd.Parameters.AddWithValue("foto", GetPhotoBytes()); // Метод для получения байтов изображения
                    cmd.Parameters.AddWithValue("elPochta", elPochta);
                    cmd.Parameters.AddWithValue("telefon", telefon);
                    cmd.Parameters.AddWithValue("status", status); // Статус всегда TRUE
                    cmd.Parameters.AddWithValue("KodDolzhnosti", GetSelectedKodDolzhnosti());

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Сотрудник успешно добавлен!");
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении сотрудника: {ex.Message}");
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

        private byte[] GetPhotoBytes()
        {
            // Метод для получения байтов изображения из PictureBox или другого источника
            if (pictureBoxFoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }

            return null; // Если фото не выбрано
        }

        private int GetSelectedKodDolzhnosti()
        {
            // Метод для получения выбранного кода должности из ComboBox или другого элемента управления
            return Convert.ToInt32(numericUpDown1.Value); // Предполагается использование ComboBox с кодами должностей
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            // Создание диалогового окна для выбора файла
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Загружаем изображение в PictureBox
                    string filePath = openFileDialog.FileName;
                    pictureBoxFoto.Image = Image.FromFile(filePath);
                }
            }
        }
    }
}
