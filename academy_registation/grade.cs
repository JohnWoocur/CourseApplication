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
    public partial class grade : Form
    {
        public grade()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            int grade = int.Parse(txtgrade.Text);
            switch (grade)
            {
                case 1:
                    //  Console.WriteLine("Monday");
                    grade10 fm1 = new grade10();
                    this.Hide();
                    fm1.Show();
                    break;
                case 2:
                    grade11 fm2 = new grade11();
                    this.Hide();
                    fm2.Show();
                    break;
                case 3:
                    grade12 fm3 = new grade12();
                    this.Hide();
                    fm3.Show();
                    break;
                case 4:
                    higher fm = new higher();
                    this.Hide();
                    fm.Show();
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
            }
        }
    }
}
