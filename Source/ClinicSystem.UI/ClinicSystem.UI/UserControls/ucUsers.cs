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
    public partial class ucUsers : UserControl
    {
        public ucUsers()
        {
            InitializeComponent();
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد أنك تريد حذف (اسم المستخدم) ؟",
                                                    "حذف مستخدم",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {

            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditUser frm = new frmAddEditUser();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            Forms.frmAddEditUser frm = new frmAddEditUser();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = "تعديل مستخدم";
            frm.ShowDialog(this);
        }
    }
}
