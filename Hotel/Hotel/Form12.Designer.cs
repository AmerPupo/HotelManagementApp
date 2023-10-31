namespace Hotel
{
    partial class Form12
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.textBoxOdlazak = new System.Windows.Forms.TextBox();
            this.textBoxDolazak = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxBrOsoba = new System.Windows.Forms.TextBox();
            this.textBoxBrSobe = new System.Windows.Forms.TextBox();
            this.textBoxGost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rezervacijeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojosobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumdolaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumodlaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.rezervacijeTableAdapter = new Hotel.HotelDataSetTableAdapters.RezervacijeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Location = new System.Drawing.Point(185, 331);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(112, 31);
            this.buttonRefresh.TabIndex = 76;
            this.buttonRefresh.Text = "Osvježi";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(163, 191);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 75;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // textBoxOdlazak
            // 
            this.textBoxOdlazak.Location = new System.Drawing.Point(98, 172);
            this.textBoxOdlazak.MaxLength = 10;
            this.textBoxOdlazak.Name = "textBoxOdlazak";
            this.textBoxOdlazak.Size = new System.Drawing.Size(147, 20);
            this.textBoxOdlazak.TabIndex = 74;
            this.textBoxOdlazak.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxOdlazak_MouseClick);
            // 
            // textBoxDolazak
            // 
            this.textBoxDolazak.Location = new System.Drawing.Point(98, 145);
            this.textBoxDolazak.MaxLength = 10;
            this.textBoxDolazak.Name = "textBoxDolazak";
            this.textBoxDolazak.Size = new System.Drawing.Size(147, 20);
            this.textBoxDolazak.TabIndex = 73;
            this.textBoxDolazak.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDolazak_MouseClick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(247, 148);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 72;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // buttonNazad
            // 
            this.buttonNazad.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonNazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNazad.Location = new System.Drawing.Point(185, 379);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(114, 31);
            this.buttonNazad.TabIndex = 71;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = false;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Datum odlaska";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Datum dolaska";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Location = new System.Drawing.Point(15, 379);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(114, 31);
            this.buttonSearch.TabIndex = 68;
            this.buttonSearch.Text = "Traži";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(15, 331);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 31);
            this.buttonDelete.TabIndex = 67;
            this.buttonDelete.Text = "Obriši";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Location = new System.Drawing.Point(15, 279);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(114, 31);
            this.buttonUpdate.TabIndex = 66;
            this.buttonUpdate.Text = "Ažuriraj";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(15, 227);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(114, 31);
            this.buttonInsert.TabIndex = 65;
            this.buttonInsert.Text = "Dodaj";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxBrOsoba
            // 
            this.textBoxBrOsoba.Location = new System.Drawing.Point(98, 115);
            this.textBoxBrOsoba.Name = "textBoxBrOsoba";
            this.textBoxBrOsoba.Size = new System.Drawing.Size(147, 20);
            this.textBoxBrOsoba.TabIndex = 64;
            // 
            // textBoxBrSobe
            // 
            this.textBoxBrSobe.Location = new System.Drawing.Point(98, 86);
            this.textBoxBrSobe.Name = "textBoxBrSobe";
            this.textBoxBrSobe.Size = new System.Drawing.Size(147, 20);
            this.textBoxBrSobe.TabIndex = 63;
            // 
            // textBoxGost
            // 
            this.textBoxGost.Location = new System.Drawing.Point(98, 56);
            this.textBoxGost.Name = "textBoxGost";
            this.textBoxGost.Size = new System.Drawing.Size(147, 20);
            this.textBoxGost.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Broj osoba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Soba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Gost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(98, 28);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(147, 20);
            this.textBoxID.TabIndex = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervacijeIDDataGridViewTextBoxColumn,
            this.gostDataGridViewTextBoxColumn,
            this.sobaDataGridViewTextBoxColumn,
            this.brojosobaDataGridViewTextBoxColumn,
            this.datumdolaskaDataGridViewTextBoxColumn,
            this.datumodlaskaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervacijeBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(351, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 395);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // rezervacijeIDDataGridViewTextBoxColumn
            // 
            this.rezervacijeIDDataGridViewTextBoxColumn.DataPropertyName = "Rezervacije_ID";
            this.rezervacijeIDDataGridViewTextBoxColumn.HeaderText = "Rezervacije_ID";
            this.rezervacijeIDDataGridViewTextBoxColumn.Name = "rezervacijeIDDataGridViewTextBoxColumn";
            // 
            // gostDataGridViewTextBoxColumn
            // 
            this.gostDataGridViewTextBoxColumn.DataPropertyName = "Gost";
            this.gostDataGridViewTextBoxColumn.HeaderText = "Gost";
            this.gostDataGridViewTextBoxColumn.Name = "gostDataGridViewTextBoxColumn";
            // 
            // sobaDataGridViewTextBoxColumn
            // 
            this.sobaDataGridViewTextBoxColumn.DataPropertyName = "Soba";
            this.sobaDataGridViewTextBoxColumn.HeaderText = "Soba";
            this.sobaDataGridViewTextBoxColumn.Name = "sobaDataGridViewTextBoxColumn";
            // 
            // brojosobaDataGridViewTextBoxColumn
            // 
            this.brojosobaDataGridViewTextBoxColumn.DataPropertyName = "Broj_osoba";
            this.brojosobaDataGridViewTextBoxColumn.HeaderText = "Broj_osoba";
            this.brojosobaDataGridViewTextBoxColumn.Name = "brojosobaDataGridViewTextBoxColumn";
            // 
            // datumdolaskaDataGridViewTextBoxColumn
            // 
            this.datumdolaskaDataGridViewTextBoxColumn.DataPropertyName = "Datum_dolaska";
            this.datumdolaskaDataGridViewTextBoxColumn.HeaderText = "Datum_dolaska";
            this.datumdolaskaDataGridViewTextBoxColumn.Name = "datumdolaskaDataGridViewTextBoxColumn";
            // 
            // datumodlaskaDataGridViewTextBoxColumn
            // 
            this.datumodlaskaDataGridViewTextBoxColumn.DataPropertyName = "Datum_odlaska";
            this.datumodlaskaDataGridViewTextBoxColumn.HeaderText = "Datum_odlaska";
            this.datumodlaskaDataGridViewTextBoxColumn.Name = "datumodlaskaDataGridViewTextBoxColumn";
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataMember = "Rezervacije";
            this.rezervacijeBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervacijeTableAdapter
            // 
            this.rezervacijeTableAdapter.ClearBeforeFill = true;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1008, 425);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.textBoxOdlazak);
            this.Controls.Add(this.textBoxDolazak);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxBrOsoba);
            this.Controls.Add(this.textBoxBrSobe);
            this.Controls.Add(this.textBoxGost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRefresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form12_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.TextBox textBoxOdlazak;
        private System.Windows.Forms.TextBox textBoxDolazak;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxBrOsoba;
        private System.Windows.Forms.TextBox textBoxBrSobe;
        private System.Windows.Forms.TextBox textBoxGost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private Hotel.HotelDataSetTableAdapters.RezervacijeTableAdapter rezervacijeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojosobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumdolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumodlaskaDataGridViewTextBoxColumn;
    }
}