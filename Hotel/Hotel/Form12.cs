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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        OleDbConnection konekcija = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hotel.mdb");
        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Rezervacije' table. You can move, or remove it, as needed.
            this.rezervacijeTableAdapter.Fill(this.hotelDataSet.Rezervacije);

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length == 0 || textBoxGost.Text.Length == 0 || textBoxBrSobe.Text.Length == 0 || textBoxBrOsoba.Text.Length == 0 || textBoxDolazak.Text.Length == 0 || textBoxOdlazak.Text.Length == 0)
            {
                MessageBox.Show("Molimo vas popunite podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                konekcija.Open();
                OleDbCommand komanda = konekcija.CreateCommand();
                komanda.CommandType = CommandType.Text;
                komanda.CommandText = ("Insert into Rezervacije(Rezervacije_ID,Gost,Soba,Broj_osoba,Datum_dolaska,Datum_odlaska)values('"
                    + textBoxID.Text + "','" + textBoxGost.Text + "','" + textBoxBrSobe.Text + "','" + textBoxBrOsoba.Text + "','" + textBoxDolazak.Text + "','" + textBoxOdlazak.Text + "')");
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Uspješno ste unijeli podatke u bazu!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            konekcija.Open();
            OleDbCommand komanda = konekcija.CreateCommand();
            komanda.CommandType = CommandType.Text;
            komanda.CommandText = ("Update Rezervacije set Soba='" + textBoxBrSobe.Text + "', Broj_osoba='" + textBoxBrOsoba.Text +
                "', Datum_dolaska='" + textBoxDolazak.Text + "', Datum_odlaska='" + textBoxOdlazak.Text +
            "', Gost='" + textBoxGost.Text + "'Where Rezervacije_ID=" + id + "");
            komanda.ExecuteNonQuery();
            konekcija.Close();
            MessageBox.Show("Uspješno ste promijenili podatke u bazi!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            konekcija.Open();
            OleDbCommand komanda = konekcija.CreateCommand();
            komanda.CommandType = CommandType.Text;

            komanda.CommandText = ("Delete from Rezervacije where Rezervacije_ID=" + id + "");
            komanda.ExecuteNonQuery();
            konekcija.Close();
            MessageBox.Show("Uspješno ste izbrisali podatke iz baze!");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            int id = Convert.ToInt32(textBoxID.Text);
            konekcija.Open();
            OleDbCommand komanda = konekcija.CreateCommand();
            komanda.CommandType = CommandType.Text;
            komanda.CommandText = ("Select * from Rezervacije where Rezervacije_ID=" + id + "");

            komanda.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komanda);
            da.Fill(dt);

            count = Convert.ToInt16(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            konekcija.Close();
            if (count == 0)
            {
                MessageBox.Show("Zapis nije pronađen");
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxGost.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxBrSobe.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxBrOsoba.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxDolazak.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Substring(0, 10);
            textBoxOdlazak.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString().Substring(0, 10);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.rezervacijeTableAdapter.Fill(this.hotelDataSet.Rezervacije);
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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

        private void Form12_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
        }
    }
}
