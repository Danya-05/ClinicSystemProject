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
                    @"C:\Users\abc\Desktop\ClinicSystem\Source\ClinicSystem.UI\Icons-Images\Screenshot 2026-11-07 215053.png");
            }
            else
            {
                // Hide Password
                tbPassword.UseSystemPasswordChar = true;
                tbPassword.IconLeft = Image.FromFile(
                    @"C:\Users\abc\Desktop\ClinicSystem\Source\ClinicSystem.UI\Icons-Images\Screenshot 2026-11-07 215045.png");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
