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
    public partial class ucPatients : UserControl
    {
        public ucPatients()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditPatient frm = new frmAddEditPatient();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);        
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditPatient frm = new frmAddEditPatient();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = "تعديل مريض";
            frm.ShowDialog(this);
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد أنك تريد حذف (اسم المريض) ؟",
                                                    "حذف مريض",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {

            }
        }

        private void btnShowMedicalFile_Click(object sender, EventArgs e)
        {
            Forms.frmMedicalFile frm = new frmMedicalFile();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnShowAllPayments_Click(object sender, EventArgs e)
        {
            Forms.frmPaymentLog frm = new frmPaymentLog();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditAppointment frm = new frmAddEditAppointment();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnAddVisite_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditVisit frm = new frmAddEditVisit();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditPayment frm = new frmAddEditPayment();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }
    }
}
