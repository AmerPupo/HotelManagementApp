namespace Hotel
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxBrTel = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.sobeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sobeTableAdapter = new Hotel.HotelDataSetTableAdapters.SobeTableAdapter();
            this.gostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gostiTableAdapter = new Hotel.HotelDataSetTableAdapters.GostiTableAdapter();
            this.gostiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Location = new System.Drawing.Point(197, 280);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(112, 31);
            this.buttonRefresh.TabIndex = 59;
            this.buttonRefresh.Text = "Osvježi";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonNazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNazad.Location = new System.Drawing.Point(197, 332);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(112, 31);
            this.buttonNazad.TabIndex = 58;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = false;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Location = new System.Drawing.Point(21, 332);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 31);
            this.buttonSearch.TabIndex = 57;
            this.buttonSearch.Text = "Traži";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(21, 280);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 31);
            this.buttonDelete.TabIndex = 56;
            this.buttonDelete.Text = "Obriši";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Location = new System.Drawing.Point(21, 228);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 31);
            this.buttonUpdate.TabIndex = 55;
            this.buttonUpdate.Text = "Ažuriraj";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(21, 176);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(112, 31);
            this.buttonInsert.TabIndex = 54;
            this.buttonInsert.Text = "Dodaj";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxBrTel
            // 
            this.textBoxBrTel.Location = new System.Drawing.Point(104, 108);
            this.textBoxBrTel.Name = "textBoxBrTel";
            this.textBoxBrTel.Size = new System.Drawing.Size(145, 20);
            this.textBoxBrTel.TabIndex = 53;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(104, 79);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(145, 20);
            this.textBoxPrezime.TabIndex = 52;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(104, 49);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(145, 20);
            this.textBoxIme.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Broj telefona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(104, 21);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(145, 20);
            this.textBoxID.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gostiIDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.brojTelefonaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gostiBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(362, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 350);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sobeBindingSource
            // 
            this.sobeBindingSource.DataMember = "Sobe";
            this.sobeBindingSource.DataSource = this.hotelDataSet;
            // 
            // sobeTableAdapter
            // 
            this.sobeTableAdapter.ClearBeforeFill = true;
            // 
            // gostiBindingSource
            // 
            this.gostiBindingSource.DataMember = "Gosti";
            this.gostiBindingSource.DataSource = this.hotelDataSet;
            // 
            // gostiTableAdapter
            // 
            this.gostiTableAdapter.ClearBeforeFill = true;
            // 
            // gostiIDDataGridViewTextBoxColumn
            // 
            this.gostiIDDataGridViewTextBoxColumn.DataPropertyName = "Gosti_ID";
            this.gostiIDDataGridViewTextBoxColumn.HeaderText = "Gosti_ID";
            this.gostiIDDataGridViewTextBoxColumn.Name = "gostiIDDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // brojTelefonaDataGridViewTextBoxColumn
            // 
            this.brojTelefonaDataGridViewTextBoxColumn.DataPropertyName = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.HeaderText = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.Name = "brojTelefonaDataGridViewTextBoxColumn";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(822, 377);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxBrTel);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gosti";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxBrTel;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource sobeBindingSource;
        private Hotel.HotelDataSetTableAdapters.SobeTableAdapter sobeTableAdapter;
        private System.Windows.Forms.BindingSource gostiBindingSource;
        private Hotel.HotelDataSetTableAdapters.GostiTableAdapter gostiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gostiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojTelefonaDataGridViewTextBoxColumn;
    }
}