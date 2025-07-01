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
    public partial class menu : Form
    {
        NpgsqlConnection NpgsqlConnection = new NpgsqlConnection("server=localhost;Port=5432;Database=FINALdb;Username=postgres;Password=nathalis;");
        public menu()
        {
            InitializeComponent();
            load();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void load()
        {
            NpgsqlCommand cmd = NpgsqlConnection.CreateCommand();
            DataTable dt = new DataTable();
            //columns.Append(name);
            //columns.Append(" (");
            cmd.CommandText = "SELECT * FROM Menyu";
            NpgsqlConnection.Open();
            cmd.ExecuteNonQuery();
            NpgsqlConnection.Close();
            NpgsqlDataAdapter sQLiteDataAdapter = new NpgsqlDataAdapter(cmd);
            sQLiteDataAdapter.Fill(dt);
            CopyDataTableToListView(dt, listView1);
            //loadIDs();
        }

        public static void CopyDataTableToListView(DataTable data, ListView lv)
        {
            lv.BeginUpdate();

            //if column count is different (typically not yet populated)
            if (lv.Columns.Count != data.Columns.Count)
            {
                lv.Columns.Clear();

                //prepare columns
                foreach (DataColumn column in data.Columns)
                {
                    lv.Columns.Add(column.ColumnName);
                }
            }

            //clear rows
            lv.Items.Clear();
            //load rows
            foreach (DataRow row in data.Rows)
            {
                var list = row.ItemArray.Select(ob => ob.ToString()).ToArray();
                ListViewItem item = new ListViewItem(list);
                //for (int i = 1; i < data.Columns.Count; i++) {item.SubItems.Add(row[i].ToString());}
                lv.Items.Add(item);
            }

            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lv.EndUpdate();
        }
    }
}
