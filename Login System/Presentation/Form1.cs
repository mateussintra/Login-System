using Login_System.Model;
using Login_System.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register re = new Register();
            re.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Controls control = new Controls();
            control.access(txtLogin.Text, txtPassword.Text);
            if (control.message.Equals(""))
            {
                if (control.have)
                {
                    MessageBox.Show("login successfully", "logging in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Welcome wc = new Welcome();
                    wc.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect login or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(control.message);
            }
        }
    }
}
