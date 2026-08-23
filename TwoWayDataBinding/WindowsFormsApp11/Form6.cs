using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form6 : Form
    {
        BromoAirlinesEntities db;
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Bandara b)
                {
                    if (e.ColumnIndex == editCol.Index) e.Value = "Edit";
                    if (e.ColumnIndex == HapusCol.Index) e.Value = "Hapus";
                }
            }
            catch
            {

            }   
        }

        private void onload()
        {
            db = new BromoAirlinesEntities();

            bandaraBindingSource.DataSource = db.Bandara.ToList();
            negaraBindingSource.DataSource = db.Negara.ToList();

            bindingSource1.Clear();
            bindingSource1.AddNew();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            onload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();

            if(bindingSource1.Current is Bandara b)
            {
                if (jumlahTerminalNumericUpDown.Value > 5)
                {
                    MessageBox.Show("kebanyakan");
                    return;
                }

                db.Bandara.AddOrUpdate(b);
                db.SaveChanges();
                MessageBox.Show("Succes save data");
                onload();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Bandara b)
            {
                db = new BromoAirlinesEntities();
                var dataBandara = db.Bandara.FirstOrDefault(x => x.ID == b.ID);

                if(e.ColumnIndex == editCol.Index)
                {
                    bindingSource1.Clear();
                    bindingSource1.DataSource = dataBandara;
                }

                if(e.ColumnIndex == HapusCol.Index)
                {
                    var confirm = MessageBox.Show("yakin hapus data ini", "Peringatan", MessageBoxButtons.YesNo);

                    try
                    {
                        if (confirm == DialogResult.Yes)
                        {
                            db.Bandara.Remove(dataBandara);
                            db.SaveChanges();
                            MessageBox.Show("berhasil hapus data");
                            onload();
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                }
            }
        }
    }
}
