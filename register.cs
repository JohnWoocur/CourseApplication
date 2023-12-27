using System.IO;
namespace acadamy


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtmail.Text = "";
            txtnum.Text = "";
            txtpwd.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {   
           
            string name = txtname.Text;
            string mail = txtmail.Text;
            string phone = txtnum.Text;
            string password = txtpwd.Text;

            string registerData=$"{name}\t{mail}\t{phone}\t{password}\r\n";

            string path = @"C:\Users\ASUS\Desktop\register.txt";

            System.IO.File.AppendAllText(path, registerData);
        }
    }
}
