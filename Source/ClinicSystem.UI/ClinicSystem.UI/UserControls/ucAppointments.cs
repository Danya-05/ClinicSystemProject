using ClinicSystem.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem.UI.UserControls
{
    public partial class ucAppointments : UserControl
    {
        public ucAppointments()
        {
            InitializeComponent();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditAppointment frm = new frmAddEditAppointment();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد أنك تريد الغاء الموعد ؟",
                                                    "الغاء موعد",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {

            }
        }

        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditAppointment frm = new frmAddEditAppointment();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = "تعديل موعد";
            frm.ShowDialog(this);
        }

        private void btnAddVisit_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditVisit frm = new frmAddEditVisit();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }
    }
}
