using Login_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System.Presentation
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Controls control = new Controls();
            string message = control.register(txtName.Text, txtEmail.Text, txtLogin.Text, txtPassword.Text, txtConfirmPassword.Text);
            if(control.have)
            {
                MessageBox.Show(message, "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(control.message);
            }
        }
    }
}
