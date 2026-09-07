namespace NusantarBooks
{
    partial class Form4
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
            System.Windows.Forms.Label hargaLabel;
            System.Windows.Forms.Label judulLabel;
            System.Windows.Forms.Label kategoriIDLabel;
            System.Windows.Forms.Label kodeBukuLabel;
            System.Windows.Forms.Label penerbitLabel;
            System.Windows.Forms.Label pengarangLabel;
            System.Windows.Forms.Label stokLabel;
            System.Windows.Forms.Label tahunTerbitLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penerbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunTerbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColum = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hargaTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.judulTextBox = new System.Windows.Forms.TextBox();
            this.kategoriIDComboBox = new System.Windows.Forms.ComboBox();
            this.kodeBukuTextBox = new System.Windows.Forms.TextBox();
            this.penerbitTextBox = new System.Windows.Forms.TextBox();
            this.pengarangTextBox = new System.Windows.Forms.TextBox();
            this.stokNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tahunTerbitTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            hargaLabel = new System.Windows.Forms.Label();
            judulLabel = new System.Windows.Forms.Label();
            kategoriIDLabel = new System.Windows.Forms.Label();
            kodeBukuLabel = new System.Windows.Forms.Label();
            penerbitLabel = new System.Windows.Forms.Label();
            pengarangLabel = new System.Windows.Forms.Label();
            stokLabel = new System.Windows.Forms.Label();
            tahunTerbitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hargaLabel
            // 
            hargaLabel.AutoSize = true;
            hargaLabel.Location = new System.Drawing.Point(29, 452);
            hargaLabel.Name = "hargaLabel";
            hargaLabel.Size = new System.Drawing.Size(57, 20);
            hargaLabel.TabIndex = 1;
            hargaLabel.Text = "Harga:";
            // 
            // judulLabel
            // 
            judulLabel.AutoSize = true;
            judulLabel.Location = new System.Drawing.Point(29, 484);
            judulLabel.Name = "judulLabel";
            judulLabel.Size = new System.Drawing.Size(51, 20);
            judulLabel.TabIndex = 3;
            judulLabel.Text = "Judul:";
            // 
            // kategoriIDLabel
            // 
            kategoriIDLabel.AutoSize = true;
            kategoriIDLabel.Location = new System.Drawing.Point(29, 516);
            kategoriIDLabel.Name = "kategoriIDLabel";
            kategoriIDLabel.Size = new System.Drawing.Size(72, 20);
            kategoriIDLabel.TabIndex = 5;
            kategoriIDLabel.Text = "Kategori:";
            // 
            // kodeBukuLabel
            // 
            kodeBukuLabel.AutoSize = true;
            kodeBukuLabel.Location = new System.Drawing.Point(29, 550);
            kodeBukuLabel.Name = "kodeBukuLabel";
            kodeBukuLabel.Size = new System.Drawing.Size(91, 20);
            kodeBukuLabel.TabIndex = 7;
            kodeBukuLabel.Text = "Kode Buku:";
            // 
            // penerbitLabel
            // 
            penerbitLabel.AutoSize = true;
            penerbitLabel.Location = new System.Drawing.Point(29, 582);
            penerbitLabel.Name = "penerbitLabel";
            penerbitLabel.Size = new System.Drawing.Size(72, 20);
            penerbitLabel.TabIndex = 9;
            penerbitLabel.Text = "Penerbit:";
            // 
            // pengarangLabel
            // 
            pengarangLabel.AutoSize = true;
            pengarangLabel.Location = new System.Drawing.Point(29, 614);
            pengarangLabel.Name = "pengarangLabel";
            pengarangLabel.Size = new System.Drawing.Size(91, 20);
            pengarangLabel.TabIndex = 11;
            pengarangLabel.Text = "Pengarang:";
            // 
            // stokLabel
            // 
            stokLabel.AutoSize = true;
            stokLabel.Location = new System.Drawing.Point(29, 643);
            stokLabel.Name = "stokLabel";
            stokLabel.Size = new System.Drawing.Size(46, 20);
            stokLabel.TabIndex = 13;
            stokLabel.Text = "Stok:";
            // 
            // tahunTerbitLabel
            // 
            tahunTerbitLabel.AutoSize = true;
            tahunTerbitLabel.Location = new System.Drawing.Point(29, 678);
            tahunTerbitLabel.Name = "tahunTerbitLabel";
            tahunTerbitLabel.Size = new System.Drawing.Size(102, 20);
            tahunTerbitLabel.TabIndex = 15;
            tahunTerbitLabel.Text = "Tahun Terbit:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.kodeBukuDataGridViewTextBoxColumn,
            this.judulDataGridViewTextBoxColumn,
            this.kategoriIDDataGridViewTextBoxColumn,
            this.pengarangDataGridViewTextBoxColumn,
            this.penerbitDataGridViewTextBoxColumn,
            this.tahunTerbitDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.editColumn,
            this.deleteColum});
            this.dataGridView1.DataSource = this.bukuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(852, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // kodeBukuDataGridViewTextBoxColumn
            // 
            this.kodeBukuDataGridViewTextBoxColumn.DataPropertyName = "KodeBuku";
            this.kodeBukuDataGridViewTextBoxColumn.HeaderText = "KodeBuku";
            this.kodeBukuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodeBukuDataGridViewTextBoxColumn.Name = "kodeBukuDataGridViewTextBoxColumn";
            this.kodeBukuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // judulDataGridViewTextBoxColumn
            // 
            this.judulDataGridViewTextBoxColumn.DataPropertyName = "Judul";
            this.judulDataGridViewTextBoxColumn.HeaderText = "Judul";
            this.judulDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.judulDataGridViewTextBoxColumn.Name = "judulDataGridViewTextBoxColumn";
            this.judulDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriIDDataGridViewTextBoxColumn
            // 
            this.kategoriIDDataGridViewTextBoxColumn.DataPropertyName = "KategoriID";
            this.kategoriIDDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kategoriIDDataGridViewTextBoxColumn.Name = "kategoriIDDataGridViewTextBoxColumn";
            this.kategoriIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pengarangDataGridViewTextBoxColumn
            // 
            this.pengarangDataGridViewTextBoxColumn.DataPropertyName = "Pengarang";
            this.pengarangDataGridViewTextBoxColumn.HeaderText = "Pengarang";
            this.pengarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pengarangDataGridViewTextBoxColumn.Name = "pengarangDataGridViewTextBoxColumn";
            this.pengarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // penerbitDataGridViewTextBoxColumn
            // 
            this.penerbitDataGridViewTextBoxColumn.DataPropertyName = "Penerbit";
            this.penerbitDataGridViewTextBoxColumn.HeaderText = "Penerbit";
            this.penerbitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.penerbitDataGridViewTextBoxColumn.Name = "penerbitDataGridViewTextBoxColumn";
            this.penerbitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tahunTerbitDataGridViewTextBoxColumn
            // 
            this.tahunTerbitDataGridViewTextBoxColumn.DataPropertyName = "TahunTerbit";
            this.tahunTerbitDataGridViewTextBoxColumn.HeaderText = "TahunTerbit";
            this.tahunTerbitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tahunTerbitDataGridViewTextBoxColumn.Name = "tahunTerbitDataGridViewTextBoxColumn";
            this.tahunTerbitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriDataGridViewTextBoxColumn.Visible = false;
            // 
            // editColumn
            // 
            this.editColumn.HeaderText = "Edit";
            this.editColumn.MinimumWidth = 8;
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            // 
            // deleteColum
            // 
            this.deleteColum.HeaderText = "Delete";
            this.deleteColum.MinimumWidth = 8;
            this.deleteColum.Name = "deleteColum";
            this.deleteColum.ReadOnly = true;
            // 
            // bukuBindingSource
            // 
            this.bukuBindingSource.DataSource = typeof(NusantarBooks.Buku);
            // 
            // hargaTextBox
            // 
            this.hargaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Harga", true));
            this.hargaTextBox.Location = new System.Drawing.Point(137, 449);
            this.hargaTextBox.Name = "hargaTextBox";
            this.hargaTextBox.Size = new System.Drawing.Size(283, 26);
            this.hargaTextBox.TabIndex = 2;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(NusantarBooks.Buku);
            // 
            // judulTextBox
            // 
            this.judulTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Judul", true));
            this.judulTextBox.Location = new System.Drawing.Point(137, 481);
            this.judulTextBox.Name = "judulTextBox";
            this.judulTextBox.Size = new System.Drawing.Size(283, 26);
            this.judulTextBox.TabIndex = 4;
            // 
            // kategoriIDComboBox
            // 
            this.kategoriIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "KategoriID", true));
            this.kategoriIDComboBox.FormattingEnabled = true;
            this.kategoriIDComboBox.Location = new System.Drawing.Point(137, 513);
            this.kategoriIDComboBox.Name = "kategoriIDComboBox";
            this.kategoriIDComboBox.Size = new System.Drawing.Size(283, 28);
            this.kategoriIDComboBox.TabIndex = 6;
            // 
            // kodeBukuTextBox
            // 
            this.kodeBukuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "KodeBuku", true));
            this.kodeBukuTextBox.Location = new System.Drawing.Point(137, 547);
            this.kodeBukuTextBox.Name = "kodeBukuTextBox";
            this.kodeBukuTextBox.Size = new System.Drawing.Size(283, 26);
            this.kodeBukuTextBox.TabIndex = 8;
            // 
            // penerbitTextBox
            // 
            this.penerbitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Penerbit", true));
            this.penerbitTextBox.Location = new System.Drawing.Point(137, 579);
            this.penerbitTextBox.Name = "penerbitTextBox";
            this.penerbitTextBox.Size = new System.Drawing.Size(283, 26);
            this.penerbitTextBox.TabIndex = 10;
            // 
            // pengarangTextBox
            // 
            this.pengarangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Pengarang", true));
            this.pengarangTextBox.Location = new System.Drawing.Point(137, 611);
            this.pengarangTextBox.Name = "pengarangTextBox";
            this.pengarangTextBox.Size = new System.Drawing.Size(283, 26);
            this.pengarangTextBox.TabIndex = 12;
            // 
            // stokNumericUpDown
            // 
            this.stokNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "Stok", true));
            this.stokNumericUpDown.Location = new System.Drawing.Point(137, 643);
            this.stokNumericUpDown.Name = "stokNumericUpDown";
            this.stokNumericUpDown.Size = new System.Drawing.Size(283, 26);
            this.stokNumericUpDown.TabIndex = 14;
            // 
            // tahunTerbitTextBox
            // 
            this.tahunTerbitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "TahunTerbit", true));
            this.tahunTerbitTextBox.Location = new System.Drawing.Point(137, 675);
            this.tahunTerbitTextBox.Name = "tahunTerbitTextBox";
            this.tahunTerbitTextBox.Size = new System.Drawing.Size(283, 26);
            this.tahunTerbitTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cari Buku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kategoriBindingSource;
            this.comboBox1.DisplayMember = "NamaKategori";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(659, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 28);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataSource = typeof(NusantarBooks.Kategori);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kategori: ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(hargaLabel);
            this.Controls.Add(this.hargaTextBox);
            this.Controls.Add(judulLabel);
            this.Controls.Add(this.judulTextBox);
            this.Controls.Add(kategoriIDLabel);
            this.Controls.Add(this.kategoriIDComboBox);
            this.Controls.Add(kodeBukuLabel);
            this.Controls.Add(this.kodeBukuTextBox);
            this.Controls.Add(penerbitLabel);
            this.Controls.Add(this.penerbitTextBox);
            this.Controls.Add(pengarangLabel);
            this.Controls.Add(this.pengarangTextBox);
            this.Controls.Add(stokLabel);
            this.Controls.Add(this.stokNumericUpDown);
            this.Controls.Add(tahunTerbitLabel);
            this.Controls.Add(this.tahunTerbitTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Master Buku";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penerbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunTerbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColum;
        private System.Windows.Forms.BindingSource bukuBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox hargaTextBox;
        private System.Windows.Forms.TextBox judulTextBox;
        private System.Windows.Forms.ComboBox kategoriIDComboBox;
        private System.Windows.Forms.TextBox kodeBukuTextBox;
        private System.Windows.Forms.TextBox penerbitTextBox;
        private System.Windows.Forms.TextBox pengarangTextBox;
        private System.Windows.Forms.NumericUpDown stokNumericUpDown;
        private System.Windows.Forms.TextBox tahunTerbitTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
    }
}