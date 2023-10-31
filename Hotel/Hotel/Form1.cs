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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();

        }

        private void buttonIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGost_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            this.Hide();
            frm.ShowDialog();

        }
    }
}
