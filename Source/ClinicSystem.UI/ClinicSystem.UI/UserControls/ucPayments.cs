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
    public partial class ucPayments : UserControl
    {
        public ucPayments()
        {
            InitializeComponent();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditPayment frm = new frmAddEditPayment();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditPayment frm = new frmAddEditPayment();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = "تعديل دفعة";
            frm.ShowDialog(this);
        }
    }
}
