using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusantarBooks
{
    public partial class Form4 : Form
    {
        NusantaraBooksEntities db = new NusantaraBooksEntities();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            bukuBindingSource.DataSource = db.Buku.ToList();
            kategoriBindingSource.DataSource = db.Kategori.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            var query = db.Buku.AsQueryable();

            string keyword = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.KodeBuku.Contains(keyword) || x.Judul.Contains(keyword));
            }

            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int kategoriId))
            {
                query = query.Where(x => x.KategoriID == kategoriId);
            }

            bukuBindingSource.DataSource = query.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
