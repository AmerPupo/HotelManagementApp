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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        OleDbConnection konekcija = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hotel.mdb");
        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Sobe' table. You can move, or remove it, as needed.
            this.sobeTableAdapter.Fill(this.hotelDataSet.Sobe);
            textBoxStanje.Text = "Zauzeta";
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxBrSobe.Text.Length == 0 || textBoxTip.Text.Length == 0 || textBoxTelefon.Text.Length == 0 || textBoxStanje.Text.Length == 0)
            {
                MessageBox.Show("Molimo vas popunite podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                konekcija.Open();
                OleDbCommand komanda = konekcija.CreateCommand();
                komanda.CommandType = CommandType.Text;
                komanda.CommandText = ("Insert into Sobe(Broj_sobe,Tip_sobe,Telefon,Stanje)values('"
                    + textBoxBrSobe.Text + "','" + textBoxTip.Text + "','" + textBoxTelefon.Text + "','" + textBoxStanje.Text + "')");
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Uspješno ste unijeli podatke u bazu!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxBrSobe.Text);
            konekcija.Open();
            OleDbCommand komanda = konekcija.CreateCommand();
            komanda.CommandType = CommandType.Text;
            komanda.CommandText = ("Update Sobe set Tip_sobe='" + textBoxTip.Text + "', Stanje='" + textBoxStanje.Text +
            "', Telefon='" + textBoxTelefon.Text + "'Where Broj_sobe=" + id + "");
            komanda.ExecuteNonQuery();
            konekcija.Close();
            MessageBox.Show("Uspješno ste promijenili podatke u bazi!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxBrSobe.Text);
            konekcija.Open();
            OleDbCommand komanda = konekcija.CreateCommand();
            komanda.CommandType = CommandType.Text;
            komanda.CommandText = ("Delete from Sobe where Broj_sobe=" + id + "");
            komanda.ExecuteNonQuery();
            konekcija.Close();
            MessageBox.Show("Uspješno ste obrisali podatke iz baze!");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            konekcija.Open();
            OleDbCommand komanda = konekcija.CreateCommand();
            komanda.CommandType = CommandType.Text;
            komanda.CommandText = ("Select * from Sobe where Tip_sobe='" + textBoxTip.Text + "'");

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
            textBoxBrSobe.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxTip.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxTelefon.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxStanje.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void checkBoxStanje_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStanje.Checked)
            {
                textBoxStanje.Text = "Slobodna";
            }
            else
            {
                textBoxStanje.Text = "Zauzeta";
            }
        }

        private void textBoxStanje_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStanje.Text == "Slobodna")
            {
                checkBoxStanje.Checked = true;
            }
            else
            {
                checkBoxStanje.Checked = false;
            }
        }

        private void dvokrevetnaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBoxTip.Text = "Dvokrevetna";
        }

        private void odvojenaDvokrevetnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxTip.Text = "Odvojena dvokrevetna";
        }

        private void dvokrevetnaSaPogledomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxTip.Text = "Dvokrevetna sa pogledom";
        }

        private void jednokrevetnaSaPogledomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxTip.Text = "Jednokrevetna sa pogledom";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.sobeTableAdapter.Fill(this.hotelDataSet.Sobe);
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
