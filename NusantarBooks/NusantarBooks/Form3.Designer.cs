namespace NusantarBooks
{
    partial class Form3
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
            System.Windows.Forms.Label deskripsiLabel;
            System.Windows.Forms.Label namaKategoriLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.deskripsiRichTextBox = new System.Windows.Forms.RichTextBox();
            this.namaKategoriTextBox = new System.Windows.Forms.TextBox();
            deskripsiLabel = new System.Windows.Forms.Label();
            namaKategoriLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.namaKategoriDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn,
            this.bukuDataGridViewTextBoxColumn,
            this.Edit,
            this.deleteCol});
            this.dataGridView1.DataSource = this.kategoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(686, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataSource = typeof(NusantarBooks.Kategori);
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
            // namaKategoriDataGridViewTextBoxColumn
            // 
            this.namaKategoriDataGridViewTextBoxColumn.DataPropertyName = "NamaKategori";
            this.namaKategoriDataGridViewTextBoxColumn.HeaderText = "NamaKategori";
            this.namaKategoriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaKategoriDataGridViewTextBoxColumn.Name = "namaKategoriDataGridViewTextBoxColumn";
            this.namaKategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            this.deskripsiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bukuDataGridViewTextBoxColumn
            // 
            this.bukuDataGridViewTextBoxColumn.DataPropertyName = "Buku";
            this.bukuDataGridViewTextBoxColumn.HeaderText = "Buku";
            this.bukuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bukuDataGridViewTextBoxColumn.Name = "bukuDataGridViewTextBoxColumn";
            this.bukuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // deleteCol
            // 
            this.deleteCol.HeaderText = "Delete";
            this.deleteCol.MinimumWidth = 8;
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // deskripsiLabel
            // 
            deskripsiLabel.AutoSize = true;
            deskripsiLabel.Location = new System.Drawing.Point(63, 391);
            deskripsiLabel.Name = "deskripsiLabel";
            deskripsiLabel.Size = new System.Drawing.Size(78, 20);
            deskripsiLabel.TabIndex = 2;
            deskripsiLabel.Text = "Deskripsi:";
            // 
            // deskripsiRichTextBox
            // 
            this.deskripsiRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategoriBindingSource, "Deskripsi", true));
            this.deskripsiRichTextBox.Location = new System.Drawing.Point(187, 388);
            this.deskripsiRichTextBox.Name = "deskripsiRichTextBox";
            this.deskripsiRichTextBox.Size = new System.Drawing.Size(266, 96);
            this.deskripsiRichTextBox.TabIndex = 3;
            this.deskripsiRichTextBox.Text = "";
            // 
            // namaKategoriLabel
            // 
            namaKategoriLabel.AutoSize = true;
            namaKategoriLabel.Location = new System.Drawing.Point(63, 345);
            namaKategoriLabel.Name = "namaKategoriLabel";
            namaKategoriLabel.Size = new System.Drawing.Size(118, 20);
            namaKategoriLabel.TabIndex = 4;
            namaKategoriLabel.Text = "Nama Kategori:";
            // 
            // namaKategoriTextBox
            // 
            this.namaKategoriTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategoriBindingSource, "NamaKategori", true));
            this.namaKategoriTextBox.Location = new System.Drawing.Point(187, 342);
            this.namaKategoriTextBox.Name = "namaKategoriTextBox";
            this.namaKategoriTextBox.Size = new System.Drawing.Size(266, 26);
            this.namaKategoriTextBox.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 584);
            this.Controls.Add(deskripsiLabel);
            this.Controls.Add(this.deskripsiRichTextBox);
            this.Controls.Add(namaKategoriLabel);
            this.Controls.Add(this.namaKategoriTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Master Kategori";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn deleteCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox deskripsiRichTextBox;
        private System.Windows.Forms.TextBox namaKategoriTextBox;
    }
}