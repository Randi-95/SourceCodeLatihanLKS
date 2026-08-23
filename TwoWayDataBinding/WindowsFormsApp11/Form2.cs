using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        BromoAirlinesEntities db = new BromoAirlinesEntities();
        int idbandara = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Bandara.ToList();
            negaraBindingSource.DataSource = db.Negara.ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Bandara b)
            {
                if (e.ColumnIndex == negaraIDDataGridViewTextBoxColumn.Index)
                {
                    e.Value = b.Negara.Nama;
                }

                if (e.ColumnIndex == editColumn.Index) e.Value = "Edit";
                if (e.ColumnIndex == hapusColumn.Index) e.Value = "Hapus";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(idbandara == 0)
            {
                Bandara bandara = new Bandara()
                {
                    Nama = namaTextBox.Text,
                    KodeIATA = kodeIATATextBox.Text,
                    Kota = kotaTextBox.Text,
                    NegaraID = (int)negaraIDComboBox.SelectedValue,
                    JumlahTerminal = (int)jumlahTerminalNumericUpDown.Value,
                    Alamat = alamatRichTextBox.Text
                };

                db.Bandara.Add(bandara);
                db.SaveChanges();
                MessageBox.Show("berhasil tambah data");
                this.OnLoad(EventArgs.Empty);
            }
            else
            {
                var getBandara = db.Bandara.FirstOrDefault(x => x.ID == idbandara);

                getBandara.Nama = namaTextBox.Text;
                getBandara.Kota = kotaTextBox.Text;
                getBandara.NegaraID = (int)negaraIDComboBox.SelectedValue;
                getBandara.JumlahTerminal = (int)jumlahTerminalNumericUpDown.Value;
                getBandara.KodeIATA = kodeIATATextBox.Text;
                getBandara.Alamat = alamatRichTextBox.Text;

                db.SaveChanges();
                MessageBox.Show("berhasil save data");
                OnLoad(EventArgs.Empty);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Bandara b)
            {
               if(e.ColumnIndex == editColumn.Index)
                {
                    idbandara = b.ID;
                    namaTextBox.Text = b.Nama;
                    alamatRichTextBox.Text = b.Alamat;
                    kotaTextBox.Text = b.Kota;
                    kodeIATATextBox.Text = b.KodeIATA;
                    negaraIDComboBox.SelectedValue = b.NegaraID;
                    jumlahTerminalNumericUpDown.Value = b.JumlahTerminal;

                }

               if(e.ColumnIndex == hapusColumn.Index)
                {
                    var message = MessageBox.Show("Yakin Hapus Data?", "Peringatan", MessageBoxButtons.YesNo);

                    if(message == DialogResult.Yes)
                    {
                        var bandara = db.Bandara.FirstOrDefault(x => x.ID == b.ID);

                        db.Bandara.Remove(bandara);
                        db.SaveChanges();

                        MessageBox.Show("Berhasil hapus data");
                        OnLoad(EventArgs.Empty);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Form4().ShowDialog();
            Show();
        }
    }
}
