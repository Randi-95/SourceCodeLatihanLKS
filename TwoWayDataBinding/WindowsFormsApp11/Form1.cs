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
    public partial class Form1 : Form
    {
        BromoAirlinesEntities db = new BromoAirlinesEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = db.Akun.FirstOrDefault(u => u.Username == textBox1.Text && u.Password == textBox2.Text);

            if(user == null)
            {
                MessageBox.Show("Akun tidak temukan");
                return;
            }
            else
            {
                this.Hide();
                new Form2().ShowDialog();
                this.Show();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Form6().ShowDialog();
            Show();
        }
    }
}
