namespace Hotel
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStanje = new System.Windows.Forms.TextBox();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.checkBoxStanje = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrSobe = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tipSobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvokrevetnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvokrevetnaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odvojenaDvokrevetnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvokrevetnaSaPogledomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jednokrevetnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jednokrevetnaSaPogledomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.sobeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sobeTableAdapter = new Hotel.HotelDataSetTableAdapters.SobeTableAdapter();
            this.brojsobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipsobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Location = new System.Drawing.Point(195, 271);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(112, 31);
            this.buttonRefresh.TabIndex = 75;
            this.buttonRefresh.Text = "Osvježi";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxTip
            // 
            this.textBoxTip.Location = new System.Drawing.Point(102, 61);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(145, 20);
            this.textBoxTip.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Tip sobe";
            // 
            // textBoxStanje
            // 
            this.textBoxStanje.Location = new System.Drawing.Point(102, 115);
            this.textBoxStanje.Name = "textBoxStanje";
            this.textBoxStanje.Size = new System.Drawing.Size(145, 20);
            this.textBoxStanje.TabIndex = 71;
            this.textBoxStanje.TextChanged += new System.EventHandler(this.textBoxStanje_TextChanged);
            // 
            // buttonNazad
            // 
            this.buttonNazad.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonNazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNazad.Location = new System.Drawing.Point(195, 323);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(112, 31);
            this.buttonNazad.TabIndex = 70;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = false;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // checkBoxStanje
            // 
            this.checkBoxStanje.AutoSize = true;
            this.checkBoxStanje.Location = new System.Drawing.Point(74, 117);
            this.checkBoxStanje.Name = "checkBoxStanje";
            this.checkBoxStanje.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStanje.TabIndex = 69;
            this.checkBoxStanje.UseVisualStyleBackColor = true;
            this.checkBoxStanje.CheckedChanged += new System.EventHandler(this.checkBoxStanje_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Location = new System.Drawing.Point(17, 323);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 31);
            this.buttonSearch.TabIndex = 68;
            this.buttonSearch.Text = "Traži";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(17, 271);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 31);
            this.buttonDelete.TabIndex = 67;
            this.buttonDelete.Text = "Obriši";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Location = new System.Drawing.Point(17, 219);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 31);
            this.buttonUpdate.TabIndex = 66;
            this.buttonUpdate.Text = "Ažuriraj";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(17, 167);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(112, 31);
            this.buttonInsert.TabIndex = 65;
            this.buttonInsert.Text = "Dodaj";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(102, 89);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(145, 20);
            this.textBoxTelefon.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Slobodna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Broj sobe";
            // 
            // textBoxBrSobe
            // 
            this.textBoxBrSobe.Location = new System.Drawing.Point(103, 32);
            this.textBoxBrSobe.Name = "textBoxBrSobe";
            this.textBoxBrSobe.Size = new System.Drawing.Size(145, 20);
            this.textBoxBrSobe.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojsobeDataGridViewTextBoxColumn,
            this.tipsobeDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.stanjeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sobeBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(313, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 302);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipSobeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 73;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tipSobeToolStripMenuItem
            // 
            this.tipSobeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dvokrevetnaToolStripMenuItem,
            this.jednokrevetnaToolStripMenuItem});
            this.tipSobeToolStripMenuItem.Name = "tipSobeToolStripMenuItem";
            this.tipSobeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.tipSobeToolStripMenuItem.Text = "Tip sobe";
            // 
            // dvokrevetnaToolStripMenuItem
            // 
            this.dvokrevetnaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dvokrevetnaToolStripMenuItem1,
            this.odvojenaDvokrevetnaToolStripMenuItem,
            this.dvokrevetnaSaPogledomToolStripMenuItem});
            this.dvokrevetnaToolStripMenuItem.Name = "dvokrevetnaToolStripMenuItem";
            this.dvokrevetnaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dvokrevetnaToolStripMenuItem.Text = "Dvokrevetna";
            // 
            // dvokrevetnaToolStripMenuItem1
            // 
            this.dvokrevetnaToolStripMenuItem1.Name = "dvokrevetnaToolStripMenuItem1";
            this.dvokrevetnaToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.dvokrevetnaToolStripMenuItem1.Text = "Dvokrevetna";
            this.dvokrevetnaToolStripMenuItem1.Click += new System.EventHandler(this.dvokrevetnaToolStripMenuItem1_Click);
            // 
            // odvojenaDvokrevetnaToolStripMenuItem
            // 
            this.odvojenaDvokrevetnaToolStripMenuItem.Name = "odvojenaDvokrevetnaToolStripMenuItem";
            this.odvojenaDvokrevetnaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.odvojenaDvokrevetnaToolStripMenuItem.Text = "Odvojena dvokrevetna";
            this.odvojenaDvokrevetnaToolStripMenuItem.Click += new System.EventHandler(this.odvojenaDvokrevetnaToolStripMenuItem_Click);
            // 
            // dvokrevetnaSaPogledomToolStripMenuItem
            // 
            this.dvokrevetnaSaPogledomToolStripMenuItem.Name = "dvokrevetnaSaPogledomToolStripMenuItem";
            this.dvokrevetnaSaPogledomToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.dvokrevetnaSaPogledomToolStripMenuItem.Text = "Dvokrevetna sa pogledom";
            this.dvokrevetnaSaPogledomToolStripMenuItem.Click += new System.EventHandler(this.dvokrevetnaSaPogledomToolStripMenuItem_Click);
            // 
            // jednokrevetnaToolStripMenuItem
            // 
            this.jednokrevetnaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jednokrevetnaSaPogledomToolStripMenuItem});
            this.jednokrevetnaToolStripMenuItem.Name = "jednokrevetnaToolStripMenuItem";
            this.jednokrevetnaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jednokrevetnaToolStripMenuItem.Text = "Jednokrevetna";
            // 
            // jednokrevetnaSaPogledomToolStripMenuItem
            // 
            this.jednokrevetnaSaPogledomToolStripMenuItem.Name = "jednokrevetnaSaPogledomToolStripMenuItem";
            this.jednokrevetnaSaPogledomToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.jednokrevetnaSaPogledomToolStripMenuItem.Text = "Jednokrevetna sa pogledom";
            this.jednokrevetnaSaPogledomToolStripMenuItem.Click += new System.EventHandler(this.jednokrevetnaSaPogledomToolStripMenuItem_Click);
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
            // brojsobeDataGridViewTextBoxColumn
            // 
            this.brojsobeDataGridViewTextBoxColumn.DataPropertyName = "Broj_sobe";
            this.brojsobeDataGridViewTextBoxColumn.HeaderText = "Broj_sobe";
            this.brojsobeDataGridViewTextBoxColumn.Name = "brojsobeDataGridViewTextBoxColumn";
            // 
            // tipsobeDataGridViewTextBoxColumn
            // 
            this.tipsobeDataGridViewTextBoxColumn.DataPropertyName = "Tip_sobe";
            this.tipsobeDataGridViewTextBoxColumn.HeaderText = "Tip_sobe";
            this.tipsobeDataGridViewTextBoxColumn.Name = "tipsobeDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // stanjeDataGridViewTextBoxColumn
            // 
            this.stanjeDataGridViewTextBoxColumn.DataPropertyName = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.HeaderText = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.Name = "stanjeDataGridViewTextBoxColumn";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(772, 360);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStanje);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.checkBoxStanje);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBrSobe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobe";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStanje;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.CheckBox checkBoxStanje;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrSobe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tipSobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dvokrevetnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dvokrevetnaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odvojenaDvokrevetnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dvokrevetnaSaPogledomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jednokrevetnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jednokrevetnaSaPogledomToolStripMenuItem;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource sobeBindingSource;
        private Hotel.HotelDataSetTableAdapters.SobeTableAdapter sobeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojsobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipsobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn;
    }
}