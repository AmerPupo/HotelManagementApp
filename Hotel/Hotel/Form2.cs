using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hotel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection konekcija = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hotel.mdb");
        private void buttonPrijava_Click(object sender, EventArgs e)
        {
             konekcija.Open();
            OleDbCommand komanda = konekcija.CreateCommand();
            komanda.CommandType = CommandType.Text;
            komanda.CommandText = ("select * from Zaposleni where Ime='" + textBox1.Text + "' and [Password]='" + textBox2.Text + "'");

            OleDbDataReader dr = komanda.ExecuteReader();
            if (dr.Read() == true)
            {
                label3.Visible = false;
                Form3 frm = new Form3();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                label3.Visible = true;
            }

            konekcija.Close();

        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
