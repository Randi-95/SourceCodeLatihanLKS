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
    public partial class Form2 : Form
    {
        NusantaraBooksEntities db = new NusantaraBooksEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Form4().ShowDialog();
            Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var user = db.Akun.FirstOrDefault(x => x.ID == UserSessions.userID);

            label1.Text = $"Selamat Datang, {user.NamaLengkap}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSessions.userID = 0;
        }
    }
}
