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
using Xceed.Words.NET;

namespace WindowsFormsApp3DB
{
    public partial class newpost : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;";

        private int kodPostavshchika;
        private int kodIngredienta;
        private int kodSotrudnika;
        private int kolichestvoUpakovok;
        public newpost()
        {
            InitializeComponent();
        }

        private void newpost_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kodPostavshchika = (int)numericUpDown2.Value;
            kodIngredienta = (int)numericUpDown1.Value;
            kodSotrudnika = (int)numericUpDown3.Value;
            kolichestvoUpakovok = (int)numericUpDown4.Value;
            // Проверка на положительное количество упаковок
            if (kolichestvoUpakovok <= 0)
            {
                MessageBox.Show("Количество упаковок должно быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Добавление записи в таблицу "Поставка"
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO Postavka (KodPostavshchika, KodIngredienta, KodSotrudnika, DataPostavki, KolichestvoUpakovok)
                VALUES (@kodPostavshchika, @kodIngredienta, @kodSotrudnika, CURRENT_DATE, @kolichestvoUpakovok)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kodPostavshchika", kodPostavshchika);
                    command.Parameters.AddWithValue("@kodIngredienta", kodIngredienta);
                    command.Parameters.AddWithValue("@kodSotrudnika", kodSotrudnika);
                    command.Parameters.AddWithValue("@kolichestvoUpakovok", kolichestvoUpakovok);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Закрываем форму после успешного добавления
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при добавлении записи: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kodPostavshchika = (int)numericUpDown2.Value;
            kodIngredienta = (int)numericUpDown1.Value;
            kodSotrudnika = (int)numericUpDown3.Value;
            kolichestvoUpakovok = (int)numericUpDown4.Value;


                // Путь к шаблону и выходному файлу
                string templatePath = Path.Combine(Application.StartupPath, "InvoiceTemplate.dotm");
                string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Nakladnaya.docx");

            // Создаем документ на основе шаблона
            using (var document = DocX.Load(templatePath))
            {
                // Заменяем метки на значения


                // Сохраняем новый документ
                document.SaveAs(outputPath);
                MessageBox.Show($"Накладная успешно выгружена по пути: {outputPath}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
                   
        }
    }
}
