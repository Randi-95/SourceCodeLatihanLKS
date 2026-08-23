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
    public partial class Form4 : Form
    {
        BromoAirlinesEntities db = new BromoAirlinesEntities();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            bandaraDataGridView.DataSource = db.Bandara.ToList();
            negaraBindingSource.DataSource = db.Negara.ToList();
        }
    }
}
