using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            erroeLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pass = txtPass.Text;
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string returnFlag;
            returnFlag = client.GetData(email, pass);
            AdminPanel zs = new AdminPanel();
            if (returnFlag == "true") { zs.Show();this.Hide(); }
            else
            {
                erroeLabel.Visible = true;
                erroeLabel.Text = "Incorrect Credentials";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
