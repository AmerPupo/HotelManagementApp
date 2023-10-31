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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        OleDbConnection konekcija = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hotel.mdb");
        private void Form15_Load(object sender, EventArgs e)
        {
            konekcija.Open();
            OleDbCommand komanda = new OleDbCommand();
            komanda.Connection = konekcija;
            komanda.CommandText = "SELECT * FROM Sobe WHERE Tip_sobe = 'Dvokrevetna sa pogledom' AND Stanje = 'Slobodna'";
            OleDbDataReader citaj = komanda.ExecuteReader();
            while (citaj.Read())
            {
                listBox1.Items.Add(citaj["Broj_sobe"].ToString());
            }
            konekcija.Close();
            textBox4.Text = "2";
        }

        private void buttonRezervisi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
            {
                MessageBox.Show("Molimo vas popunite podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (textBoxDolazak.Text.Length == 0 || textBoxOdlazak.Text.Length == 0)
            {
                MessageBox.Show("Molimo vas specifirajte datum dolaska i odlaska", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo vas izaberite broj sobe", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                string soba = listBox1.SelectedItem.ToString();
                string stanje = "Zauzeta";
                string gost = textBox1.Text + " " + textBox2.Text;
                konekcija.Open();
                OleDbCommand komanda = konekcija.CreateCommand();
                komanda.CommandType = CommandType.Text;
                komanda.CommandText = ("Insert into Gosti(Ime,Prezime,BrojTelefona)values('"
                + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')");
                komanda.ExecuteNonQuery();
                konekcija.Close();
                konekcija.Open();

                komanda.CommandType = CommandType.Text;
                komanda.CommandText = ("Insert into Rezervacije(Gost,Soba,Broj_osoba,Datum_dolaska,Datum_odlaska)values('"
                                + gost + "','" + soba + "','" + textBox4.Text + "','" + textBoxDolazak.Text + "','" + textBoxOdlazak.Text + "')");
                komanda.ExecuteNonQuery();
                konekcija.Close();
                konekcija.Open();

                komanda.CommandType = CommandType.Text;
                komanda.CommandText = ("Update Sobe set Stanje='" + stanje +
                "'Where Broj_sobe=" + soba + "");
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Uspješno ste rezervisali sobu");

            }
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            this.Close();
            frm.Show();
            this.Hide();
        }

        private void textBoxDolazak_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dolazak = monthCalendar1.SelectionEnd;
            textBoxDolazak.Text = dolazak.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void textBoxOdlazak_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar2.Visible = true;
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime odlazak = monthCalendar2.SelectionEnd;
            textBoxOdlazak.Text = odlazak.ToShortDateString();
            monthCalendar2.Visible = false;
        }

        private void Form15_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
        }
    }
}
