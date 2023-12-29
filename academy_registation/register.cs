using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academy_registation
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtsid.Text != "" && txtemail.Text != "" && txtcontact.Text != "" && txtpassword.Text != "")
            {
                string name = txtname.Text;
                string sid = txtsid.Text;
                string email = txtemail.Text;
                string contact = txtcontact.Text;
                string password = txtpassword.Text;


                string registerData = $"{name},{sid},{email},{contact},{password}\r\n";
                string path = @"students.txt";

                System.IO.File.AppendAllText(path, registerData);

                MessageBox.Show("Registered Successfully!");

                login fm = new login();
                this.Hide();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Empty Field");
            }
        }
    }
}
