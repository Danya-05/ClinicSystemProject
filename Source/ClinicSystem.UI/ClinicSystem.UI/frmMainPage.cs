using ClinicSystem.UI.UserControls;
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

            lblTitle.Text = ((Button)btnSender).Text;
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucPatients(), sender);
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucAppointments(), sender);
        }

        private void btnVisits_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucVisits(), sender);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucPayments(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucUsers(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucSettings(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد أنك تريد تسجيل الخروج؟",
                                                    "تأكيد تسجيل الخروج",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
