using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem.UI.Forms
{
    public partial class frmAddEditVisit : Form
    {
        public frmAddEditVisit()
        {
            InitializeComponent();
        }

        private void btnShowMedicalFile_Click(object sender, EventArgs e)
        {
            Forms.frmMedicalFile frm = new frmMedicalFile();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        public void SetViewMode()
        {
            // Hide Buttons
            btnShowMedicalFile.Visible = false;
            btnSaveChanges.Visible = false;
            btnCancel.Visible = false;

            // Make RichTextBoxes ReadOnly
            rtbDiagnosis.ReadOnly = true;
            rtbPrescription.ReadOnly = true;
            rtbFees.ReadOnly = true;
            rtbNotes.ReadOnly = true;

            // Make RichTextBoxes with white back color
            rtbDiagnosis.BackColor = Color.White;
            rtbPrescription.BackColor = Color.White;
            rtbFees.BackColor = Color.White;
            rtbNotes.BackColor = Color.White;
        }
    }
}
