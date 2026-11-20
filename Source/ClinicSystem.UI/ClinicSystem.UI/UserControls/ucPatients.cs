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
    }
}
