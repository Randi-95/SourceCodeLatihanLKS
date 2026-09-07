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
    public partial class Form1 : Form
    {
        public static NusantaraBooksEntities db = new NusantaraBooksEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userCheck = db.Akun.FirstOrDefault(x => x.Username == usernameTextBox.Text && x.Password == passwordTextBox.Text);

            if(userCheck == null)
            {
                MessageBox.Show("Invalid Credentials");
                return;
            }
            else
            {
                if(userCheck.Role != "Admin")
                {
                    MessageBox.Show("Akses ditolak. Hanya akun Admin yang diperbolehkan untuk login ke sistem ini.");
                    return;
                }
                else
                {
                    UserSessions.userID = userCheck.ID;
                    Hide();
                    new Form2().ShowDialog();
        
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
