namespace Hotel
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.buttonNazad = new System.Windows.Forms.Button();
            this.buttonLijevo = new System.Windows.Forms.Button();
            this.buttonDesno = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNazad
            // 
            this.buttonNazad.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonNazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNazad.Location = new System.Drawing.Point(320, 450);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(116, 29);
            this.buttonNazad.TabIndex = 22;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = false;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // buttonLijevo
            // 
            this.buttonLijevo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonLijevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLijevo.Location = new System.Drawing.Point(12, 181);
            this.buttonLijevo.Name = "buttonLijevo";
            this.buttonLijevo.Size = new System.Drawing.Size(38, 110);
            this.buttonLijevo.TabIndex = 21;
            this.buttonLijevo.Text = "<";
            this.buttonLijevo.UseVisualStyleBackColor = false;
            this.buttonLijevo.Click += new System.EventHandler(this.buttonLijevo_Click);
            // 
            // buttonDesno
            // 
            this.buttonDesno.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDesno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDesno.Location = new System.Drawing.Point(701, 181);
            this.buttonDesno.Name = "buttonDesno";
            this.buttonDesno.Size = new System.Drawing.Size(38, 110);
            this.buttonDesno.TabIndex = 20;
            this.buttonDesno.Text = ">";
            this.buttonDesno.UseVisualStyleBackColor = false;
            this.buttonDesno.Click += new System.EventHandler(this.buttonDesno_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hotel.Properties.Resources.Odvojena_Dvokrevetna_3;
            this.pictureBox3.Location = new System.Drawing.Point(63, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(616, 421);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel.Properties.Resources.Odvojena_Dvokrevetna_2;
            this.pictureBox2.Location = new System.Drawing.Point(63, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(616, 421);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.Odvojena_Dvokrevetna_1;
            this.pictureBox1.Location = new System.Drawing.Point(63, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(751, 503);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonLijevo);
            this.Controls.Add(this.buttonDesno);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odvojena dvokrevetna soba";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Button buttonLijevo;
        private System.Windows.Forms.Button buttonDesno;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}