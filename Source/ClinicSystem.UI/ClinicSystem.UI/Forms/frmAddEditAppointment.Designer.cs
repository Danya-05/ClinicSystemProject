namespace ClinicSystem.UI.Forms
{
    partial class frmAddEditAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAppointmentIDNum = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpAppointmentTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveChanges = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblAppointmentIDNum
            // 
            this.lblAppointmentIDNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAppointmentIDNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentIDNum.ForeColor = System.Drawing.Color.Black;
            this.lblAppointmentIDNum.Location = new System.Drawing.Point(187, 25);
            this.lblAppointmentIDNum.Name = "lblAppointmentIDNum";
            this.lblAppointmentIDNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAppointmentIDNum.Size = new System.Drawing.Size(74, 33);
            this.lblAppointmentIDNum.TabIndex = 34;
            this.lblAppointmentIDNum.Text = "10";
            this.lblAppointmentIDNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.ForeColor = System.Drawing.Color.Black;
            this.lblAppointmentID.Location = new System.Drawing.Point(267, 25);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(117, 25);
            this.lblAppointmentID.TabIndex = 33;
            this.lblAppointmentID.Text = " : رقم الموعد ";
            this.lblAppointmentID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpAppointmentDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpAppointmentDate.Checked = true;
            this.dtpAppointmentDate.FillColor = System.Drawing.Color.LightGray;
            this.dtpAppointmentDate.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(22, 79);
            this.dtpAppointmentDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAppointmentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAppointmentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpAppointmentDate.Size = new System.Drawing.Size(240, 24);
            this.dtpAppointmentDate.TabIndex = 55;
            this.dtpAppointmentDate.UseTransparentBackground = true;
            this.dtpAppointmentDate.Value = new System.DateTime(2026, 11, 18, 15, 27, 27, 776);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(267, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 25);
            this.lblDate.TabIndex = 54;
            this.lblDate.Text = " : التاريخ ";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpAppointmentTime
            // 
            this.dtpAppointmentTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpAppointmentTime.BackColor = System.Drawing.Color.Transparent;
            this.dtpAppointmentTime.Checked = true;
            this.dtpAppointmentTime.CustomFormat = "hh:mm tt";
            this.dtpAppointmentTime.FillColor = System.Drawing.Color.LightGray;
            this.dtpAppointmentTime.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentTime.Location = new System.Drawing.Point(22, 131);
            this.dtpAppointmentTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAppointmentTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAppointmentTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAppointmentTime.Name = "dtpAppointmentTime";
            this.dtpAppointmentTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpAppointmentTime.ShowUpDown = true;
            this.dtpAppointmentTime.Size = new System.Drawing.Size(240, 24);
            this.dtpAppointmentTime.TabIndex = 56;
            this.dtpAppointmentTime.UseTransparentBackground = true;
            this.dtpAppointmentTime.Value = new System.DateTime(2026, 11, 18, 15, 27, 27, 776);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(267, 130);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 25);
            this.lblTime.TabIndex = 57;
            this.lblTime.Text = " : الوقت";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbDoctor
            // 
            this.cbDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDoctor.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(22, 191);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbDoctor.Size = new System.Drawing.Size(240, 28);
            this.cbDoctor.Sorted = true;
            this.cbDoctor.TabIndex = 58;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(22, 243);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbStatus.Size = new System.Drawing.Size(240, 28);
            this.cbStatus.Sorted = true;
            this.cbStatus.TabIndex = 59;
            this.cbStatus.Text = "مجدول";
            // 
            // lblDoctor
            // 
            this.lblDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblDoctor.Location = new System.Drawing.Point(264, 190);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(83, 25);
            this.lblDoctor.TabIndex = 60;
            this.lblDoctor.Text = " : الطبيب";
            this.lblDoctor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(264, 242);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 25);
            this.lblStatus.TabIndex = 61;
            this.lblStatus.Text = " : حالة الموعد";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(22, 321);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 70);
            this.btnCancel.TabIndex = 75;
            this.btnCancel.Text = "الغاء";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveChanges.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveChanges.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveChanges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveChanges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveChanges.FillColor = System.Drawing.Color.Silver;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(272, 321);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(105, 70);
            this.btnSaveChanges.TabIndex = 74;
            this.btnSaveChanges.Text = "حفظ";
            // 
            // frmAddEditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 398);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpAppointmentTime);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAppointmentIDNum);
            this.Controls.Add(this.lblAppointmentID);
            this.Name = "frmAddEditAppointment";
            this.Text = "اضافة موعد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentIDNum;
        private System.Windows.Forms.Label lblAppointmentID;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpAppointmentTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSaveChanges;
    }
}