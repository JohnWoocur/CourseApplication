﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace academy_registation
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            register fm = new register();
            this.Hide();
            fm.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;

            string[] lines = File.ReadAllLines("students.txt");

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {


                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        string storedname = parts[0].Trim();
                        string storedPassword = parts[4].Trim();

                        if (storedname == name && storedPassword == password)
                        {
                            MessageBox.Show("Login Successfully");
                            grade fm = new grade();
                            this.Hide();
                            fm.Show();

                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid Username or Password... Please Try Again!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Field");
            }




        }

        private void login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
