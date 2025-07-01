using Npgsql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace WindowsFormsApp3DB
{
    public partial class sbarista : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;";

        public sbarista()
        {
            InitializeComponent();
        }

        private void sbarista_Load(object sender, EventArgs e)
        {
            // Здесь можно инициализировать значения или элементы управления
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем код поставки из numericUpDown1
            int kodPostavki = (int)numericUpDown1.Value;

            // Формируем накладную на основе кода поставки
            ExportInvoice(kodPostavki);
        }

        private void ExportInvoice(int kodPostavki)
        {
            // Путь к шаблону и выходному файлу
            string templatePath = "InvoiceTemplate.dotm";
            string outputPath = "Nakladnaya.docx";

            using (var document = DocX.Load(templatePath))
            {
                // Заменяем метки на значения
                //document.ReplaceText("{ДатаПоставки}", DateTime.Now.ToShortDateString());

                // Получаем информацию о поставке по коду поставки
                string supplyQuery = @"
                    SELECT p.KodPostavki, ps.NazvanieKompaniji, i.Nazvanie AS NazvanieIngredienta,
                           s.Familiya AS FamiliyaSotrudnika, s.Imya AS ImyaSotrudnika,
                           p.KolichestvoUpakovok, i.TsenaZakupochnaia 
                    FROM Postavka p
                    JOIN Postavshchik ps ON p.KodPostavshchika = ps.KodPostavshchika
                    JOIN Ingredient i ON p.KodIngredienta = i.KodIngredienta
                    JOIN Sotrudnik s ON p.KodSotrudnika = s.KodSotrudnika
                    WHERE p.KodPostavki = @kodPostavki";

                using (var supplyCommand = new NpgsqlCommand(supplyQuery, new NpgsqlConnection(connectionString)))
                {
                    supplyCommand.Parameters.AddWithValue("@kodPostavki", kodPostavki);

                    try
                    {
                        supplyCommand.Connection.Open();
                        using (var reader = supplyCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Заполняем накладную данными о поставке
                                document.ReplaceText("{NazvanieKompaniji}", reader["NazvanieKompaniji"].ToString());
                                document.ReplaceText("{KodPostavki}", reader["KodPostavki"].ToString());
                                document.ReplaceText("{KolichestvoUpakovok}", reader["KolichestvoUpakovok"].ToString());
                                document.ReplaceText("{NazvanieIngredienta}", reader["NazvanieIngredienta"].ToString());
                                document.ReplaceText("{FamiliyaSotrudnika}", reader["FamiliyaSotrudnika"].ToString());
                                document.ReplaceText("{ImyaSotrudnika}", reader["ImyaSotrudnika"].ToString());

                                decimal tsenaZakupochnaia = (decimal)reader["TsenaZakupochnaia"];
                                decimal obshchayaTsena = tsenaZakupochnaia * (int)reader["KolichestvoUpakovok"];
                                document.ReplaceText("{ObshchayaTsena}", obshchayaTsena.ToString("F2")); // Форматируем до двух знаков после запятой
                            }
                            else
                            {
                                MessageBox.Show("Поставка не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при получении данных о поставке: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Сохраняем новый документ
                document.SaveAs(outputPath);
                MessageBox.Show($"Накладная успешно выгружена по пути: {outputPath}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}