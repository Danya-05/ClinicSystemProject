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
                tbPassword.IconLeft = Image.FromFile(
                    @"C:\Users\abc\Desktop\ClinicSystem\Source\ClinicSystem.UI\Icons-Images\eye-on.png");
            }
            else
            {
                // Hide Password
                tbPassword.UseSystemPasswordChar = true;
                tbPassword.IconLeft = Image.FromFile(
                    @"C:\Users\abc\Desktop\ClinicSystem\Source\ClinicSystem.UI\Icons-Images\eye-off.png");
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
