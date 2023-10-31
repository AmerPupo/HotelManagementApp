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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDesno_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else
                if (pictureBox2.Visible == true)
                {
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                }
                else
                    if (pictureBox3.Visible == true)
                    {
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = true;
                    }
                    else
                        if (pictureBox4.Visible == true)
                        {
                            pictureBox4.Visible = false;
                            pictureBox1.Visible = true;
                        }
        }

        private void buttonLijevo_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox4.Visible = true;
            }
            else
                if (pictureBox2.Visible == true)
                {
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = true;
                }
                else
                    if (pictureBox3.Visible == true)
                    {
                        pictureBox3.Visible = false;
                        pictureBox2.Visible = true;
                    }
                    else
                        if (pictureBox4.Visible == true)
                        {
                            pictureBox4.Visible = false;
                            pictureBox3.Visible = true;
                        }
        }
    }
}
