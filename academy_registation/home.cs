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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login fm = new login();
            this.Hide();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register fm = new register();
            this.Hide();
            fm.Show();
        }
    }
}
