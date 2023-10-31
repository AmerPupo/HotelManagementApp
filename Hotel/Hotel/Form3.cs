using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm = new Form2();
            frm.Show(); ;
        }

        private void pictureBoxGosti_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            if (rez == DialogResult.Cancel)
            {
                frm.Close();
                this.Show();
            }
        }

        private void pictureBoxZaposlenici_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            if (rez == DialogResult.Cancel)
            {
                frm.Close();
                this.Show();
            }
        }

        private void pictureBoxSobe_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            if (rez == DialogResult.Cancel)
            {
                frm.Close();
                this.Show();
            }
        }

        private void pictureBoxRezervacije_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            if (rez == DialogResult.Cancel)
            {
                frm.Close();
                this.Show();
            }
        }
    }
}
