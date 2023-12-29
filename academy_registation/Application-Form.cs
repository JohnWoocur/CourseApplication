using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace academy_registation
{
    public partial class Application_Form : Form
    {
        DataTable application = new DataTable("Application");
        public Application_Form()

           
        {
            InitializeComponent();

            DataColumn sName = new DataColumn("Student_Name", typeof(string));
            DataColumn SID = new DataColumn("Student_ID", typeof(string));
            DataColumn courseName = new DataColumn("Course_Name", typeof(string));

            application.Columns.Add(sName);
            application.Columns.Add(SID);   
            application.Columns.Add(courseName);

            dataGridView1.DataSource = application;


        }

        private void Application_Form_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtsName.Text = "";
            txtSID.Text = "";
            txtcourseName.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtsName.Text != "" && txtSID.Text != "" && txtcourseName.Text != "")
            {
                application.Rows.Add(txtsName.Text, txtSID.Text, txtcourseName.Text);
            }
            else
            {
                MessageBox.Show("Empty Field");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string Details = "";
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                Details += dataGridView1.Rows[row].Cells[0].Value + "\t" + dataGridView1.Rows[row].Cells[1].Value + "\t" + dataGridView1.Rows[row].Cells[2].Value + "\n";

            }

            string filePath = @"CourseApplications.txt";

            System.IO.File.AppendAllText(filePath, Details);
            MessageBox.Show(" Successfully Added ");

            grade fm = new grade();
            this.Hide();
            fm.Show();
        }
    }
}
