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
    public partial class Form5 : Form
    {
        BromoAirlinesEntities db;
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadData()
        {
            db = new BromoAirlinesEntities();
            bandaraBindingSource.DataSource = db.Bandara.ToList();
            negaraBindingSource.DataSource = db.Negara.ToList();

            bindingSource1.Clear();
            bindingSource1.AddNew();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            if(bindingSource1.Current is Bandara b)
            {
                db.Bandara.AddOrUpdate(b);
                db.SaveChanges();
                MessageBox.Show("Succes Update Data");
                loadData();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Bandara b)
            {
                var dataBandara = db.Bandara.FirstOrDefault(x => x.ID == b.ID);
                if (e.ColumnIndex == editCol.Index)
                {
                    bindingSource1.Clear();
                   

                    if(dataBandara != null)
                    {
                        bindingSource1.Clear();
                        bindingSource1.DataSource = dataBandara;
                    }
                }

                if(e.ColumnIndex == deleteCol.Index)
                {
                    var confirm = MessageBox.Show("Are you sure delete this data?", "Warning", MessageBoxButtons.YesNo);

                    if(confirm == DialogResult.Yes)
                    {
                        try
                        {
                            db.Bandara.Remove(dataBandara);
                            db.SaveChanges();
                            MessageBox.Show("Succes Delete");
                            loadData();
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                       
                    }
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            try
            {
                if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Bandara b)
                {
                    if (e.ColumnIndex == editCol.Index) e.Value = "Edit";
                    if (e.ColumnIndex == deleteCol.Index) e.Value = "Delete";
                }
            }
            catch (Exception)
            {

            }
          
        }
    }
}
