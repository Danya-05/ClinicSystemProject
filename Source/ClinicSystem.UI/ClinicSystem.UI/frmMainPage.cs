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
    public partial class frmMainMenu : Form
    {
        //private Form activeForm;

        public frmMainMenu()
        {
            InitializeComponent();
        }

        //Method to open the forms in the container panel (15:44)
        private void OpenUserControl(UserControl uc, object btnSender)
        {
            uc.Dock = DockStyle.Fill;
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(uc);
            uc.BringToFront();

            //lblTitle.Text = childForm.Text;
        }
        
    }
}
