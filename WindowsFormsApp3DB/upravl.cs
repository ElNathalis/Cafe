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
    public partial class upravl : Form
    {
        public upravl()
        {
            InitializeComponent();
        }

        private void upravl_Load(object sender, EventArgs e)
        {

        }

        private void upravlsotr_Click(object sender, EventArgs e)
        {
            sotrs newForm = new sotrs();
            newForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void insertsotr_Click(object sender, EventArgs e)
        {
            dobavlsotr newForm = new dobavlsotr();
            newForm.Show();
        }

        private void uvoln_Click(object sender, EventArgs e)
        {

        }

        private void newpost_Click(object sender, EventArgs e)
        {
            newpost newForm = new newpost();
            newForm.Show();
        }

        private void vsepost_Click(object sender, EventArgs e)
        {
            vsepost newForm = new vsepost();
            newForm.Show();
        }

        private void anal_Click(object sender, EventArgs e)
        {
            diagr newForm = new diagr();
            newForm.Show();
        }

        private void audit_Click(object sender, EventArgs e)
        {
            PARTITION newForm = new PARTITION();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sbarista newForm = new sbarista();
            newForm.Show();
        }
    }
}
