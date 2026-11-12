using ClinicSystem.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void PasswordTB_IconLeftClick(object sender, EventArgs e)
        {
            if (tbPassword.UseSystemPasswordChar == true)
            {
                // Show Password
                tbPassword.UseSystemPasswordChar = false;
                tbPassword.IconLeft = Resources.eye_on;
            }
            else
            {
                // Hide Password
                tbPassword.UseSystemPasswordChar = true;
                tbPassword.IconLeft = Resources.eye_off;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
