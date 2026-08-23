namespace WindowsFormsApp11
{
    partial class Form5
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
            System.Windows.Forms.Label alamatLabel;
            System.Windows.Forms.Label jumlahTerminalLabel;
            System.Windows.Forms.Label kodeIATALabel;
            System.Windows.Forms.Label kotaLabel;
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label negaraIDLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alamatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jumlahTerminalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kodeIATATextBox = new System.Windows.Forms.TextBox();
            this.kotaTextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.negaraIDComboBox = new System.Windows.Forms.ComboBox();
            this.negaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeIATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negaraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahTerminalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalPenerbanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalPenerbangan1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            alamatLabel = new System.Windows.Forms.Label();
            jumlahTerminalLabel = new System.Windows.Forms.Label();
            kodeIATALabel = new System.Windows.Forms.Label();
            kotaLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            negaraIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahTerminalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(66, 402);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(63, 20);
            alamatLabel.TabIndex = 1;
            alamatLabel.Text = "Alamat:";
            // 
            // jumlahTerminalLabel
            // 
            jumlahTerminalLabel.AutoSize = true;
            jumlahTerminalLabel.Location = new System.Drawing.Point(66, 501);
            jumlahTerminalLabel.Name = "jumlahTerminalLabel";
            jumlahTerminalLabel.Size = new System.Drawing.Size(128, 20);
            jumlahTerminalLabel.TabIndex = 3;
            jumlahTerminalLabel.Text = "Jumlah Terminal:";
            // 
            // kodeIATALabel
            // 
            kodeIATALabel.AutoSize = true;
            kodeIATALabel.Location = new System.Drawing.Point(66, 536);
            kodeIATALabel.Name = "kodeIATALabel";
            kodeIATALabel.Size = new System.Drawing.Size(90, 20);
            kodeIATALabel.TabIndex = 5;
            kodeIATALabel.Text = "Kode IATA:";
            // 
            // kotaLabel
            // 
            kotaLabel.AutoSize = true;
            kotaLabel.Location = new System.Drawing.Point(66, 568);
            kotaLabel.Name = "kotaLabel";
            kotaLabel.Size = new System.Drawing.Size(46, 20);
            kotaLabel.TabIndex = 7;
            kotaLabel.Text = "Kota:";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(66, 600);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(55, 20);
            namaLabel.TabIndex = 9;
            namaLabel.Text = "Nama:";
            // 
            // negaraIDLabel
            // 
            negaraIDLabel.AutoSize = true;
            negaraIDLabel.Location = new System.Drawing.Point(66, 632);
            negaraIDLabel.Name = "negaraIDLabel";
            negaraIDLabel.Size = new System.Drawing.Size(86, 20);
            negaraIDLabel.TabIndex = 11;
            negaraIDLabel.Text = "Negara ID:";
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
            this.deleteCol,
            this.editCol,
            this.namaDataGridViewTextBoxColumn,
            this.kodeIATADataGridViewTextBoxColumn,
            this.kotaDataGridViewTextBoxColumn,
            this.negaraIDDataGridViewTextBoxColumn,
            this.jumlahTerminalDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.jadwalPenerbanganDataGridViewTextBoxColumn,
            this.jadwalPenerbangan1DataGridViewTextBoxColumn,
            this.negaraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bandaraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(916, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataSource = typeof(WindowsFormsApp11.Bandara);
            // 
            // alamatRichTextBox
            // 
            this.alamatRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Alamat", true));
            this.alamatRichTextBox.Location = new System.Drawing.Point(200, 399);
            this.alamatRichTextBox.Name = "alamatRichTextBox";
            this.alamatRichTextBox.Size = new System.Drawing.Size(322, 96);
            this.alamatRichTextBox.TabIndex = 2;
            this.alamatRichTextBox.Text = "";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp11.Bandara);
            // 
            // jumlahTerminalNumericUpDown
            // 
            this.jumlahTerminalNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "JumlahTerminal", true));
            this.jumlahTerminalNumericUpDown.Location = new System.Drawing.Point(200, 501);
            this.jumlahTerminalNumericUpDown.Name = "jumlahTerminalNumericUpDown";
            this.jumlahTerminalNumericUpDown.Size = new System.Drawing.Size(322, 26);
            this.jumlahTerminalNumericUpDown.TabIndex = 4;
            // 
            // kodeIATATextBox
            // 
            this.kodeIATATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "KodeIATA", true));
            this.kodeIATATextBox.Location = new System.Drawing.Point(200, 533);
            this.kodeIATATextBox.Name = "kodeIATATextBox";
            this.kodeIATATextBox.Size = new System.Drawing.Size(322, 26);
            this.kodeIATATextBox.TabIndex = 6;
            // 
            // kotaTextBox
            // 
            this.kotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Kota", true));
            this.kotaTextBox.Location = new System.Drawing.Point(200, 565);
            this.kotaTextBox.Name = "kotaTextBox";
            this.kotaTextBox.Size = new System.Drawing.Size(322, 26);
            this.kotaTextBox.TabIndex = 8;
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(200, 597);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(322, 26);
            this.namaTextBox.TabIndex = 10;
            // 
            // negaraIDComboBox
            // 
            this.negaraIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "NegaraID", true));
            this.negaraIDComboBox.DataSource = this.negaraBindingSource;
            this.negaraIDComboBox.DisplayMember = "Nama";
            this.negaraIDComboBox.FormattingEnabled = true;
            this.negaraIDComboBox.Location = new System.Drawing.Point(200, 629);
            this.negaraIDComboBox.Name = "negaraIDComboBox";
            this.negaraIDComboBox.Size = new System.Drawing.Size(322, 28);
            this.negaraIDComboBox.TabIndex = 12;
            this.negaraIDComboBox.ValueMember = "ID";
            // 
            // negaraBindingSource
            // 
            this.negaraBindingSource.DataSource = typeof(WindowsFormsApp11.Negara);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deleteCol
            // 
            this.deleteCol.HeaderText = "Delete";
            this.deleteCol.MinimumWidth = 8;
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.ReadOnly = true;
            // 
            // editCol
            // 
            this.editCol.HeaderText = "Edit";
            this.editCol.MinimumWidth = 8;
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodeIATADataGridViewTextBoxColumn
            // 
            this.kodeIATADataGridViewTextBoxColumn.DataPropertyName = "KodeIATA";
            this.kodeIATADataGridViewTextBoxColumn.HeaderText = "KodeIATA";
            this.kodeIATADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodeIATADataGridViewTextBoxColumn.Name = "kodeIATADataGridViewTextBoxColumn";
            this.kodeIATADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kotaDataGridViewTextBoxColumn
            // 
            this.kotaDataGridViewTextBoxColumn.DataPropertyName = "Kota";
            this.kotaDataGridViewTextBoxColumn.HeaderText = "Kota";
            this.kotaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kotaDataGridViewTextBoxColumn.Name = "kotaDataGridViewTextBoxColumn";
            this.kotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // negaraIDDataGridViewTextBoxColumn
            // 
            this.negaraIDDataGridViewTextBoxColumn.DataPropertyName = "NegaraID";
            this.negaraIDDataGridViewTextBoxColumn.HeaderText = "NegaraID";
            this.negaraIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.negaraIDDataGridViewTextBoxColumn.Name = "negaraIDDataGridViewTextBoxColumn";
            this.negaraIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jumlahTerminalDataGridViewTextBoxColumn
            // 
            this.jumlahTerminalDataGridViewTextBoxColumn.DataPropertyName = "JumlahTerminal";
            this.jumlahTerminalDataGridViewTextBoxColumn.HeaderText = "JumlahTerminal";
            this.jumlahTerminalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jumlahTerminalDataGridViewTextBoxColumn.Name = "jumlahTerminalDataGridViewTextBoxColumn";
            this.jumlahTerminalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jadwalPenerbanganDataGridViewTextBoxColumn
            // 
            this.jadwalPenerbanganDataGridViewTextBoxColumn.DataPropertyName = "JadwalPenerbangan";
            this.jadwalPenerbanganDataGridViewTextBoxColumn.HeaderText = "JadwalPenerbangan";
            this.jadwalPenerbanganDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jadwalPenerbanganDataGridViewTextBoxColumn.Name = "jadwalPenerbanganDataGridViewTextBoxColumn";
            this.jadwalPenerbanganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jadwalPenerbangan1DataGridViewTextBoxColumn
            // 
            this.jadwalPenerbangan1DataGridViewTextBoxColumn.DataPropertyName = "JadwalPenerbangan1";
            this.jadwalPenerbangan1DataGridViewTextBoxColumn.HeaderText = "JadwalPenerbangan1";
            this.jadwalPenerbangan1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jadwalPenerbangan1DataGridViewTextBoxColumn.Name = "jadwalPenerbangan1DataGridViewTextBoxColumn";
            this.jadwalPenerbangan1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // negaraDataGridViewTextBoxColumn
            // 
            this.negaraDataGridViewTextBoxColumn.DataPropertyName = "Negara";
            this.negaraDataGridViewTextBoxColumn.HeaderText = "Negara";
            this.negaraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.negaraDataGridViewTextBoxColumn.Name = "negaraDataGridViewTextBoxColumn";
            this.negaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(alamatLabel);
            this.Controls.Add(this.alamatRichTextBox);
            this.Controls.Add(jumlahTerminalLabel);
            this.Controls.Add(this.jumlahTerminalNumericUpDown);
            this.Controls.Add(kodeIATALabel);
            this.Controls.Add(this.kodeIATATextBox);
            this.Controls.Add(kotaLabel);
            this.Controls.Add(this.kotaTextBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(negaraIDLabel);
            this.Controls.Add(this.negaraIDComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahTerminalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bandaraBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RichTextBox alamatRichTextBox;
        private System.Windows.Forms.NumericUpDown jumlahTerminalNumericUpDown;
        private System.Windows.Forms.TextBox kodeIATATextBox;
        private System.Windows.Forms.TextBox kotaTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.ComboBox negaraIDComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource negaraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteCol;
        private System.Windows.Forms.DataGridViewButtonColumn editCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeIATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn negaraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahTerminalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jadwalPenerbanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jadwalPenerbangan1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn negaraDataGridViewTextBoxColumn;
    }
}