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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        OleDbConnection konekcija = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hotel.mdb");
        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Zaposleni' table. You can move, or remove it, as needed.
            this.zaposleniTableAdapter.Fill(this.hotelDataSet.Zaposleni);

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length == 0 || textBoxIme.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Molimo vas popunite podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                string id, ime, sifra;
                id = textBoxID.Text;
                ime = textBoxIme.Text;
                sifra = textBoxPassword.Text;

                    konekcija.Open();
                    OleDbCommand komanda = konekcija.CreateCommand();
                    komanda.CommandType = CommandType.Text;
                    komanda.CommandText = ("Insert into Zaposleni(Zaposleni_ID,Ime,[Password])values('"
                        + id + "','" + ime + "','" + sifra + "')");
                    komanda.ExecuteNonQuery();
                    konekcija.Close();
                    MessageBox.Show("Uspješno ste unijeli podatke u bazu!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string ime, sifra;

            ime = textBoxIme.Text;
            sifra = textBoxPassword.Text;
            konekcija.Open();
            OleDbCommand komanda = konekcija.CreateCommand();
            komanda.CommandType = CommandType.Text;

            komanda.CommandText = ("Update Zaposleni set [Password]='" + sifra + "', Ime='" + ime + "'Where Zaposleni_ID=" + id + "");
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

            komanda.CommandText = ("Delete from Zaposleni where Zaposleni_ID=" + textBoxIme.Text + "");
            komanda.ExecuteNonQuery();
            konekcija.Close();
            MessageBox.Show("Uspješno ste obrisali podatke iz baze!");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxIme.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            konekcija.Open();
            OleDbCommand komanda = konekcija.CreateCommand();
            komanda.CommandType = CommandType.Text;
            komanda.CommandText = ("Select * from Zaposleni where Ime='" + textBoxIme.Text + "'");

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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.zaposleniTableAdapter.Fill(this.hotelDataSet.Zaposleni);
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
