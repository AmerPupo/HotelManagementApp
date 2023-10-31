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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonSlike1_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }

        private void buttonSlike2_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }

        private void buttonSlike3_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }

        private void buttonSlike4_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void Form4_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            panel4.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
        }

        private void buttonRez1_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            this.Close();
            frm.Show();
            this.Hide();
        }

        private void buttonRez2_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            this.Close();
            frm.Show();
            this.Hide();
        }

        private void buttonRez3_Click(object sender, EventArgs e)
        {
            Form15 frm = new Form15();
            this.Close();
            frm.Show();
            this.Hide();
        }

        private void buttonRez4_Click(object sender, EventArgs e)
        {
            Form16 frm = new Form16();
            this.Close();
            frm.Show();
            this.Hide();
        }

        private void buttonSlike1_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        private void buttonSlike2_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        private void buttonSlike3_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        private void buttonSlike4_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        private void buttonNazad_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }
    }
}
