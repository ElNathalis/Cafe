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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) //заголовок
        {

        }

        private void button1_Click(object sender, EventArgs e) //войти
        {
            DialogResult result = MessageBox.Show(
                "Вы клиент?",
                 "Кто вы?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.No)
            {
                enter newForm = new enter();
                newForm.Show();
            }
            if (result == DialogResult.Yes)
            {
                klient newForm = new klient();
                newForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) //зарегистрироваться
        {
            registration newForm = new registration();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e) //меню
        {
            menu newForm = new menu();
            newForm.Show();
        }
    }
}
