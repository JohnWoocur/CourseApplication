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
    public partial class higher : Form
    {
        public higher()
        {
            InitializeComponent();
        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            Application_Form fm = new Application_Form();
            this.Hide();
            fm.Show();
        }

        private void btnapply2_Click(object sender, EventArgs e)
        {
            Application_Form fm = new Application_Form();
            this.Hide();
            fm.Show();
        }

        private void btnapply3_Click(object sender, EventArgs e)
        {
            Application_Form fm = new Application_Form();
            this.Hide();
            fm.Show();
        }
    }
}
