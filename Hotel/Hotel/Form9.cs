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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        OleDbConnection konekcija = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hotel.mdb");
        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Gosti' table. You can move, or remove it, as needed.
            this.gostiTableAdapter.Fill(this.hotelDataSet.Gosti);

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length == 0 || textBoxIme.Text.Length == 0 || textBoxPrezime.Text.Length == 0 || textBoxBrTel.Text.Length == 0)
            {
                MessageBox.Show("Molimo vas popunite podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                konekcija.Open();
                OleDbCommand komanda = konekcija.CreateCommand();
                komanda.CommandType = CommandType.Text;
                komanda.CommandText = ("Insert into Gosti(Gosti_ID,Ime,Prezime,BrojTelefona)values('"
                    + textBoxID.Text + "','" + textBoxIme.Text + "','" + textBoxPrezime.Text + "','" + textBoxBrTel.Text + "')");
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

            komanda.CommandText = ("Update Gosti set Ime='" + textBoxIme.Text + "', Prezime='" + textBoxPrezime.Text + "', BrojTelefona='" + textBoxBrTel.Text +
            "'Where Gosti_ID=" + id + "");
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

            komanda.CommandText = ("Delete from Gosti where Gosti_ID=" + id + "");
            komanda.ExecuteNonQuery();
            konekcija.Close();
            MessageBox.Show("Uspješno ste izbrisali podatke iz baze!");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            konekcija.Open();
            OleDbCommand komanda = konekcija.CreateCommand();
            komanda.CommandType = CommandType.Text;
            komanda.CommandText = ("Select * from Gosti where Ime='" + textBoxIme.Text + "'");

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
            textBoxIme.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPrezime.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxBrTel.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.gostiTableAdapter.Fill(this.hotelDataSet.Gosti);
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
