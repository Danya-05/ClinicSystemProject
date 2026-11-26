using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicSystem.UI.Forms
{
    public partial class frmAddEditPatient : Form
    {
        public frmAddEditPatient()
        {
            InitializeComponent();
        }

        private void TrackBarPercentage_Scroll(object sender, ScrollEventArgs e)
        {
            int value = (int)Math.Round(TrackBarPercentage.Value / 5.0) * 5;

            TrackBarPercentage.Value = value;
            lblPercentage.Text = TrackBarPercentage.Value + "%";
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            pnlInsuranceOptions.Enabled = rbYes.Checked;
        }

    }
}
