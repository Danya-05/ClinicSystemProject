namespace ClinicSystem.UI.Forms
{
    partial class frmAddEditVisit
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
            this.lblDoctorFullName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAppointmentIDNum = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpVisitTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpVisitDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveChanges = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowMedicalFile = new Guna.UI2.WinForms.Guna2Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtbDiagnosis = new System.Windows.Forms.RichTextBox();
            this.rtbPrescription = new System.Windows.Forms.RichTextBox();
            this.rtbFees = new System.Windows.Forms.RichTextBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblDoctorFullName
            // 
            this.lblDoctorFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDoctorFullName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblDoctorFullName.ForeColor = System.Drawing.Color.Black;
            this.lblDoctorFullName.Location = new System.Drawing.Point(44, 48);
            this.lblDoctorFullName.Name = "lblDoctorFullName";
            this.lblDoctorFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDoctorFullName.Size = new System.Drawing.Size(217, 29);
            this.lblDoctorFullName.TabIndex = 40;
            this.lblDoctorFullName.Text = "الاسم الاول و الثاني";
            this.lblDoctorFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(584, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 25);
            this.lblName.TabIndex = 39;
            this.lblName.Text = " : المريض";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAppointmentIDNum
            // 
            this.lblAppointmentIDNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAppointmentIDNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentIDNum.ForeColor = System.Drawing.Color.Black;
            this.lblAppointmentIDNum.Location = new System.Drawing.Point(486, 9);
            this.lblAppointmentIDNum.Name = "lblAppointmentIDNum";
            this.lblAppointmentIDNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAppointmentIDNum.Size = new System.Drawing.Size(74, 33);
            this.lblAppointmentIDNum.TabIndex = 38;
            this.lblAppointmentIDNum.Text = "10";
            this.lblAppointmentIDNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.ForeColor = System.Drawing.Color.Black;
            this.lblAppointmentID.Location = new System.Drawing.Point(566, 13);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(117, 25);
            this.lblAppointmentID.TabIndex = 37;
            this.lblAppointmentID.Text = " : رقم الموعد ";
            this.lblAppointmentID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(261, 97);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 25);
            this.lblTime.TabIndex = 61;
            this.lblTime.Text = " : الوقت";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpVisitTime
            // 
            this.dtpVisitTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpVisitTime.BackColor = System.Drawing.Color.Transparent;
            this.dtpVisitTime.Checked = true;
            this.dtpVisitTime.CustomFormat = "hh:mm tt";
            this.dtpVisitTime.Enabled = false;
            this.dtpVisitTime.FillColor = System.Drawing.Color.LightGray;
            this.dtpVisitTime.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVisitTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVisitTime.Location = new System.Drawing.Point(16, 98);
            this.dtpVisitTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpVisitTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpVisitTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpVisitTime.Name = "dtpVisitTime";
            this.dtpVisitTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpVisitTime.ShowUpDown = true;
            this.dtpVisitTime.Size = new System.Drawing.Size(240, 24);
            this.dtpVisitTime.TabIndex = 60;
            this.dtpVisitTime.UseTransparentBackground = true;
            this.dtpVisitTime.Value = new System.DateTime(2026, 11, 18, 15, 27, 27, 776);
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpVisitDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpVisitDate.Checked = true;
            this.dtpVisitDate.Enabled = false;
            this.dtpVisitDate.FillColor = System.Drawing.Color.LightGray;
            this.dtpVisitDate.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisitDate.Location = new System.Drawing.Point(348, 98);
            this.dtpVisitDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpVisitDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpVisitDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpVisitDate.Size = new System.Drawing.Size(240, 24);
            this.dtpVisitDate.TabIndex = 59;
            this.dtpVisitDate.UseTransparentBackground = true;
            this.dtpVisitDate.Value = new System.DateTime(2026, 11, 18, 15, 27, 27, 776);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(593, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 25);
            this.lblDate.TabIndex = 58;
            this.lblDate.Text = " : التاريخ ";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(357, 50);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFullName.Size = new System.Drawing.Size(217, 29);
            this.lblFullName.TabIndex = 63;
            this.lblFullName.Text = "الاسم الاول و الثاني";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.ForeColor = System.Drawing.Color.Black;
            this.lblDoctorName.Location = new System.Drawing.Point(261, 50);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(83, 25);
            this.lblDoctorName.TabIndex = 62;
            this.lblDoctorName.Text = " : الطبيب";
            this.lblDoctorName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.ForeColor = System.Drawing.Color.Black;
            this.lblDiagnosis.Location = new System.Drawing.Point(510, 177);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(145, 25);
            this.lblDiagnosis.TabIndex = 65;
            this.lblDiagnosis.Text = " : اضافة تشخيص";
            this.lblDiagnosis.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPrescription
            // 
            this.lblPrescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescription.ForeColor = System.Drawing.Color.Black;
            this.lblPrescription.Location = new System.Drawing.Point(501, 372);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(173, 25);
            this.lblPrescription.TabIndex = 67;
            this.lblPrescription.Text = " : اضافة وصفة طبية";
            this.lblPrescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(501, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 69;
            this.label7.Text = " : اضافة رسوم الزيارة";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.btnCancel.Location = new System.Drawing.Point(16, 567);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 70);
            this.btnCancel.TabIndex = 77;
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
            this.btnSaveChanges.Location = new System.Drawing.Point(16, 372);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(138, 70);
            this.btnSaveChanges.TabIndex = 76;
            this.btnSaveChanges.Text = "حفظ";
            // 
            // btnShowMedicalFile
            // 
            this.btnShowMedicalFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowMedicalFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowMedicalFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowMedicalFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowMedicalFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowMedicalFile.FillColor = System.Drawing.Color.Silver;
            this.btnShowMedicalFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnShowMedicalFile.ForeColor = System.Drawing.Color.Black;
            this.btnShowMedicalFile.Location = new System.Drawing.Point(16, 177);
            this.btnShowMedicalFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowMedicalFile.Name = "btnShowMedicalFile";
            this.btnShowMedicalFile.Size = new System.Drawing.Size(138, 70);
            this.btnShowMedicalFile.TabIndex = 78;
            this.btnShowMedicalFile.Text = "عرض ملف المريض";
            this.btnShowMedicalFile.Click += new System.EventHandler(this.btnShowMedicalFile_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.Black;
            this.lblNotes.Location = new System.Drawing.Point(501, 549);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(98, 25);
            this.lblNotes.TabIndex = 80;
            this.lblNotes.Text = " : ملاحظات";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rtbDiagnosis
            // 
            this.rtbDiagnosis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDiagnosis.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rtbDiagnosis.Location = new System.Drawing.Point(237, 177);
            this.rtbDiagnosis.Name = "rtbDiagnosis";
            this.rtbDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbDiagnosis.Size = new System.Drawing.Size(267, 183);
            this.rtbDiagnosis.TabIndex = 82;
            this.rtbDiagnosis.Text = "نص التشخيص";
            // 
            // rtbPrescription
            // 
            this.rtbPrescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbPrescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPrescription.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rtbPrescription.Location = new System.Drawing.Point(238, 372);
            this.rtbPrescription.Name = "rtbPrescription";
            this.rtbPrescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbPrescription.Size = new System.Drawing.Size(266, 88);
            this.rtbPrescription.TabIndex = 83;
            this.rtbPrescription.Text = "نص الوصفة";
            // 
            // rtbFees
            // 
            this.rtbFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFees.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rtbFees.Location = new System.Drawing.Point(238, 477);
            this.rtbFees.Name = "rtbFees";
            this.rtbFees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbFees.Size = new System.Drawing.Size(266, 50);
            this.rtbFees.TabIndex = 84;
            this.rtbFees.Text = "15";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rtbNotes.Location = new System.Drawing.Point(238, 549);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbNotes.Size = new System.Drawing.Size(266, 88);
            this.rtbNotes.TabIndex = 85;
            this.rtbNotes.Text = "نص الملاحظة";
            // 
            // frmAddEditVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.rtbFees);
            this.Controls.Add(this.rtbPrescription);
            this.Controls.Add(this.rtbDiagnosis);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnShowMedicalFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPrescription);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpVisitTime);
            this.Controls.Add(this.dtpVisitDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDoctorFullName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAppointmentIDNum);
            this.Controls.Add(this.lblAppointmentID);
            this.Name = "frmAddEditVisit";
            this.Text = "اضافة زيارة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoctorFullName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAppointmentIDNum;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label lblTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpVisitTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpVisitDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSaveChanges;
        private Guna.UI2.WinForms.Guna2Button btnShowMedicalFile;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtbDiagnosis;
        private System.Windows.Forms.RichTextBox rtbPrescription;
        private System.Windows.Forms.RichTextBox rtbFees;
        private System.Windows.Forms.RichTextBox rtbNotes;
    }
}