namespace WindowsFormsApp11
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
            System.Windows.Forms.Label alamatLabel;
            System.Windows.Forms.Label jumlahTerminalLabel;
            System.Windows.Forms.Label kodeIATALabel;
            System.Windows.Forms.Label kotaLabel;
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label negaraIDLabel;
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bandaraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.jumlahTerminalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kodeIATATextBox = new System.Windows.Forms.TextBox();
            this.kotaTextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.negaraIDComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.negaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            alamatLabel = new System.Windows.Forms.Label();
            jumlahTerminalLabel = new System.Windows.Forms.Label();
            kodeIATALabel = new System.Windows.Forms.Label();
            kotaLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            negaraIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahTerminalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataSource = typeof(WindowsFormsApp11.Bandara);
            // 
            // bandaraDataGridView
            // 
            this.bandaraDataGridView.AllowUserToAddRows = false;
            this.bandaraDataGridView.AllowUserToDeleteRows = false;
            this.bandaraDataGridView.AutoGenerateColumns = false;
            this.bandaraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bandaraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandaraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.bandaraDataGridView.DataSource = this.bandaraBindingSource;
            this.bandaraDataGridView.Location = new System.Drawing.Point(31, 39);
            this.bandaraDataGridView.Name = "bandaraDataGridView";
            this.bandaraDataGridView.ReadOnly = true;
            this.bandaraDataGridView.RowHeadersWidth = 62;
            this.bandaraDataGridView.RowTemplate.Height = 28;
            this.bandaraDataGridView.Size = new System.Drawing.Size(911, 270);
            this.bandaraDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KodeIATA";
            this.dataGridViewTextBoxColumn3.HeaderText = "KodeIATA";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kota";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kota";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NegaraID";
            this.dataGridViewTextBoxColumn5.HeaderText = "NegaraID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "JumlahTerminal";
            this.dataGridViewTextBoxColumn6.HeaderText = "JumlahTerminal";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Alamat";
            this.dataGridViewTextBoxColumn7.HeaderText = "Alamat";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "JadwalPenerbangan";
            this.dataGridViewTextBoxColumn8.HeaderText = "JadwalPenerbangan";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "JadwalPenerbangan1";
            this.dataGridViewTextBoxColumn9.HeaderText = "JadwalPenerbangan1";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Negara";
            this.dataGridViewTextBoxColumn10.HeaderText = "Negara";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(53, 378);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(63, 20);
            alamatLabel.TabIndex = 1;
            alamatLabel.Text = "Alamat:";
            // 
            // alamatRichTextBox
            // 
            this.alamatRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandaraBindingSource, "Alamat", true));
            this.alamatRichTextBox.Location = new System.Drawing.Point(187, 375);
            this.alamatRichTextBox.Name = "alamatRichTextBox";
            this.alamatRichTextBox.Size = new System.Drawing.Size(323, 96);
            this.alamatRichTextBox.TabIndex = 2;
            this.alamatRichTextBox.Text = "";
            // 
            // jumlahTerminalLabel
            // 
            jumlahTerminalLabel.AutoSize = true;
            jumlahTerminalLabel.Location = new System.Drawing.Point(53, 477);
            jumlahTerminalLabel.Name = "jumlahTerminalLabel";
            jumlahTerminalLabel.Size = new System.Drawing.Size(128, 20);
            jumlahTerminalLabel.TabIndex = 3;
            jumlahTerminalLabel.Text = "Jumlah Terminal:";
            // 
            // jumlahTerminalNumericUpDown
            // 
            this.jumlahTerminalNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bandaraBindingSource, "JumlahTerminal", true));
            this.jumlahTerminalNumericUpDown.Location = new System.Drawing.Point(187, 477);
            this.jumlahTerminalNumericUpDown.Name = "jumlahTerminalNumericUpDown";
            this.jumlahTerminalNumericUpDown.Size = new System.Drawing.Size(323, 26);
            this.jumlahTerminalNumericUpDown.TabIndex = 4;
            // 
            // kodeIATALabel
            // 
            kodeIATALabel.AutoSize = true;
            kodeIATALabel.Location = new System.Drawing.Point(53, 512);
            kodeIATALabel.Name = "kodeIATALabel";
            kodeIATALabel.Size = new System.Drawing.Size(90, 20);
            kodeIATALabel.TabIndex = 5;
            kodeIATALabel.Text = "Kode IATA:";
            // 
            // kodeIATATextBox
            // 
            this.kodeIATATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandaraBindingSource, "KodeIATA", true));
            this.kodeIATATextBox.Location = new System.Drawing.Point(187, 509);
            this.kodeIATATextBox.Name = "kodeIATATextBox";
            this.kodeIATATextBox.Size = new System.Drawing.Size(323, 26);
            this.kodeIATATextBox.TabIndex = 6;
            // 
            // kotaLabel
            // 
            kotaLabel.AutoSize = true;
            kotaLabel.Location = new System.Drawing.Point(53, 544);
            kotaLabel.Name = "kotaLabel";
            kotaLabel.Size = new System.Drawing.Size(46, 20);
            kotaLabel.TabIndex = 7;
            kotaLabel.Text = "Kota:";
            // 
            // kotaTextBox
            // 
            this.kotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandaraBindingSource, "Kota", true));
            this.kotaTextBox.Location = new System.Drawing.Point(187, 541);
            this.kotaTextBox.Name = "kotaTextBox";
            this.kotaTextBox.Size = new System.Drawing.Size(323, 26);
            this.kotaTextBox.TabIndex = 8;
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(53, 576);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(55, 20);
            namaLabel.TabIndex = 9;
            namaLabel.Text = "Nama:";
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandaraBindingSource, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(187, 573);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(323, 26);
            this.namaTextBox.TabIndex = 10;
            // 
            // negaraIDLabel
            // 
            negaraIDLabel.AutoSize = true;
            negaraIDLabel.Location = new System.Drawing.Point(53, 608);
            negaraIDLabel.Name = "negaraIDLabel";
            negaraIDLabel.Size = new System.Drawing.Size(86, 20);
            negaraIDLabel.TabIndex = 11;
            negaraIDLabel.Text = "Negara ID:";
            // 
            // negaraIDComboBox
            // 
            this.negaraIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bandaraBindingSource, "NegaraID", true));
            this.negaraIDComboBox.DataSource = this.negaraBindingSource;
            this.negaraIDComboBox.DisplayMember = "Nama";
            this.negaraIDComboBox.FormattingEnabled = true;
            this.negaraIDComboBox.Location = new System.Drawing.Point(187, 605);
            this.negaraIDComboBox.Name = "negaraIDComboBox";
            this.negaraIDComboBox.Size = new System.Drawing.Size(323, 28);
            this.negaraIDComboBox.TabIndex = 12;
            this.negaraIDComboBox.ValueMember = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 62);
            this.button1.TabIndex = 13;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // negaraBindingSource
            // 
            this.negaraBindingSource.DataSource = typeof(WindowsFormsApp11.Negara);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 653);
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
            this.Controls.Add(this.bandaraDataGridView);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahTerminalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bandaraBindingSource;
        private System.Windows.Forms.DataGridView bandaraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.RichTextBox alamatRichTextBox;
        private System.Windows.Forms.NumericUpDown jumlahTerminalNumericUpDown;
        private System.Windows.Forms.TextBox kodeIATATextBox;
        private System.Windows.Forms.TextBox kotaTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.ComboBox negaraIDComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource negaraBindingSource;
    }
}