namespace Hotel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonIzlaz = new System.Windows.Forms.Button();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.buttonGost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIzlaz
            // 
            this.buttonIzlaz.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIzlaz.Location = new System.Drawing.Point(198, 215);
            this.buttonIzlaz.Name = "buttonIzlaz";
            this.buttonIzlaz.Size = new System.Drawing.Size(64, 23);
            this.buttonIzlaz.TabIndex = 11;
            this.buttonIzlaz.Text = "Izlaz";
            this.buttonIzlaz.UseVisualStyleBackColor = false;
            this.buttonIzlaz.Click += new System.EventHandler(this.buttonIzlaz_Click);
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrijava.Location = new System.Drawing.Point(73, 162);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(120, 32);
            this.buttonPrijava.TabIndex = 10;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = false;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // buttonGost
            // 
            this.buttonGost.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGost.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonGost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGost.Location = new System.Drawing.Point(73, 107);
            this.buttonGost.Name = "buttonGost";
            this.buttonGost.Size = new System.Drawing.Size(120, 32);
            this.buttonGost.TabIndex = 9;
            this.buttonGost.Text = "Nastavi kao gost";
            this.buttonGost.UseVisualStyleBackColor = false;
            this.buttonGost.Click += new System.EventHandler(this.buttonGost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dobrodošli";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonIzlaz);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.buttonGost);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Pupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIzlaz;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Button buttonGost;
        private System.Windows.Forms.Label label1;
    }
}

