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
    public partial class ucVisits : UserControl
    {
        public ucVisits()
        {
            InitializeComponent();
        }

        private void btnAddVisit_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditVisit frm = new frmAddEditVisit();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnEditVisit_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditVisit frm = new frmAddEditVisit();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = "تعديل زيارة";
            frm.ShowDialog(this);
        }

        private void btnShowVisit_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditVisit frm = new frmAddEditVisit();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = "عرض زيارة";
            frm.SetViewMode();
            frm.ShowDialog(this);
        }
    }
}
