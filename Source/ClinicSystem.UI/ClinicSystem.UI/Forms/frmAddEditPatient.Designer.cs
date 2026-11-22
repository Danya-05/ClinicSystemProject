namespace ClinicSystem.UI.Forms
{
    partial class frmAddEditPatient
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
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientIDNum = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAgeNum = new System.Windows.Forms.Label();
            this.dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.pnType = new System.Windows.Forms.Panel();
            this.rbFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.tbPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhonNumber = new System.Windows.Forms.Label();
            this.tbChronicDiseases = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblChronicDiseases = new System.Windows.Forms.Label();
            this.tbAllergic = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAllergic = new System.Windows.Forms.Label();
            this.pnInsuranceRB = new System.Windows.Forms.Panel();
            this.rbNo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbYes = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.dtpExpier = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblExpier = new System.Windows.Forms.Label();
            this.tbInsuranceNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInsurancePercentage = new System.Windows.Forms.Label();
            this.lblInsuranceNum = new System.Windows.Forms.Label();
            this.TrackBarPercentage = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnSaveChanges = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlInsuranceOptions = new System.Windows.Forms.Panel();
            this.pnType.SuspendLayout();
            this.pnInsuranceRB.SuspendLayout();
            this.pnlInsuranceOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPatientID
            // 
            this.lblPatientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.Black;
            this.lblPatientID.Location = new System.Drawing.Point(507, 18);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(127, 25);
            this.lblPatientID.TabIndex = 15;
            this.lblPatientID.Text = " : رقم المريض ";
            this.lblPatientID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPatientIDNum
            // 
            this.lblPatientIDNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPatientIDNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientIDNum.ForeColor = System.Drawing.Color.Black;
            this.lblPatientIDNum.Location = new System.Drawing.Point(427, 18);
            this.lblPatientIDNum.Name = "lblPatientIDNum";
            this.lblPatientIDNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatientIDNum.Size = new System.Drawing.Size(74, 33);
            this.lblPatientIDNum.TabIndex = 32;
            this.lblPatientIDNum.Text = "10";
            this.lblPatientIDNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(507, 74);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(114, 25);
            this.lblFirstName.TabIndex = 33;
            this.lblFirstName.Text = " : الاسم الاول";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(504, 126);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(119, 25);
            this.lblLastName.TabIndex = 34;
            this.lblLastName.Text = " : الاسم الثاني";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.DefaultText = "";
            this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Location = new System.Drawing.Point(257, 127);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PlaceholderText = "";
            this.tbLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbLastName.SelectedText = "";
            this.tbLastName.Size = new System.Drawing.Size(239, 24);
            this.tbLastName.TabIndex = 35;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.DefaultText = "";
            this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Location = new System.Drawing.Point(257, 75);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PlaceholderText = "";
            this.tbFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.Size = new System.Drawing.Size(239, 24);
            this.tbFirstName.TabIndex = 36;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.ForeColor = System.Drawing.Color.Black;
            this.lblBirthDate.Location = new System.Drawing.Point(502, 180);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(119, 25);
            this.lblBirthDate.TabIndex = 37;
            this.lblBirthDate.Text = " : تاريخ الميلاد";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAge
            // 
            this.lblAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(548, 223);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(68, 25);
            this.lblAge.TabIndex = 38;
            this.lblAge.Text = " : العمر";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAgeNum
            // 
            this.lblAgeNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgeNum.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblAgeNum.ForeColor = System.Drawing.Color.Black;
            this.lblAgeNum.Location = new System.Drawing.Point(468, 222);
            this.lblAgeNum.Name = "lblAgeNum";
            this.lblAgeNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgeNum.Size = new System.Drawing.Size(74, 33);
            this.lblAgeNum.TabIndex = 39;
            this.lblAgeNum.Text = "10";
            this.lblAgeNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpBirthDate.Checked = true;
            this.dtpBirthDate.FillColor = System.Drawing.Color.LightGray;
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(257, 181);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpBirthDate.Size = new System.Drawing.Size(240, 24);
            this.dtpBirthDate.TabIndex = 53;
            this.dtpBirthDate.UseTransparentBackground = true;
            this.dtpBirthDate.Value = new System.DateTime(2026, 11, 18, 15, 27, 27, 776);
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(419, 230);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(77, 25);
            this.lblType.TabIndex = 54;
            this.lblType.Text = " : الجنس";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnType
            // 
            this.pnType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnType.Controls.Add(this.rbFemale);
            this.pnType.Controls.Add(this.rbMale);
            this.pnType.Location = new System.Drawing.Point(257, 230);
            this.pnType.Name = "pnType";
            this.pnType.Size = new System.Drawing.Size(157, 44);
            this.pnType.TabIndex = 55;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.BorderThickness = 0;
            this.rbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFemale.CheckedState.InnerOffset = -4;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(12, 3);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbFemale.Size = new System.Drawing.Size(61, 29);
            this.rbFemale.TabIndex = 57;
            this.rbFemale.Text = "انثى";
            this.rbFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFemale.UncheckedState.BorderThickness = 2;
            this.rbFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.BorderThickness = 0;
            this.rbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbMale.CheckedState.InnerOffset = -4;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(90, 3);
            this.rbMale.Name = "rbMale";
            this.rbMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbMale.Size = new System.Drawing.Size(55, 29);
            this.rbMale.TabIndex = 56;
            this.rbMale.Text = "ذكر";
            this.rbMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbMale.UncheckedState.BorderThickness = 2;
            this.rbMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNumber.DefaultText = "";
            this.tbPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneNumber.Location = new System.Drawing.Point(254, 290);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.PlaceholderText = "";
            this.tbPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPhoneNumber.SelectedText = "";
            this.tbPhoneNumber.Size = new System.Drawing.Size(239, 24);
            this.tbPhoneNumber.TabIndex = 57;
            // 
            // lblPhonNumber
            // 
            this.lblPhonNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhonNumber.AutoSize = true;
            this.lblPhonNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhonNumber.Location = new System.Drawing.Point(504, 289);
            this.lblPhonNumber.Name = "lblPhonNumber";
            this.lblPhonNumber.Size = new System.Drawing.Size(110, 25);
            this.lblPhonNumber.TabIndex = 56;
            this.lblPhonNumber.Text = " : رقم الهاتف";
            this.lblPhonNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbChronicDiseases
            // 
            this.tbChronicDiseases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbChronicDiseases.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChronicDiseases.DefaultText = "";
            this.tbChronicDiseases.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbChronicDiseases.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbChronicDiseases.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbChronicDiseases.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbChronicDiseases.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbChronicDiseases.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChronicDiseases.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbChronicDiseases.Location = new System.Drawing.Point(254, 349);
            this.tbChronicDiseases.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbChronicDiseases.Name = "tbChronicDiseases";
            this.tbChronicDiseases.PlaceholderText = "";
            this.tbChronicDiseases.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbChronicDiseases.SelectedText = "";
            this.tbChronicDiseases.Size = new System.Drawing.Size(239, 24);
            this.tbChronicDiseases.TabIndex = 59;
            // 
            // lblChronicDiseases
            // 
            this.lblChronicDiseases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChronicDiseases.AutoSize = true;
            this.lblChronicDiseases.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChronicDiseases.ForeColor = System.Drawing.Color.Black;
            this.lblChronicDiseases.Location = new System.Drawing.Point(504, 348);
            this.lblChronicDiseases.Name = "lblChronicDiseases";
            this.lblChronicDiseases.Size = new System.Drawing.Size(145, 25);
            this.lblChronicDiseases.TabIndex = 58;
            this.lblChronicDiseases.Text = " :الامراض المزمنة";
            this.lblChronicDiseases.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbAllergic
            // 
            this.tbAllergic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAllergic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAllergic.DefaultText = "";
            this.tbAllergic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAllergic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAllergic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAllergic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAllergic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAllergic.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAllergic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAllergic.Location = new System.Drawing.Point(255, 403);
            this.tbAllergic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAllergic.Name = "tbAllergic";
            this.tbAllergic.PlaceholderText = "";
            this.tbAllergic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAllergic.SelectedText = "";
            this.tbAllergic.Size = new System.Drawing.Size(239, 24);
            this.tbAllergic.TabIndex = 61;
            // 
            // lblAllergic
            // 
            this.lblAllergic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAllergic.AutoSize = true;
            this.lblAllergic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergic.ForeColor = System.Drawing.Color.Black;
            this.lblAllergic.Location = new System.Drawing.Point(505, 402);
            this.lblAllergic.Name = "lblAllergic";
            this.lblAllergic.Size = new System.Drawing.Size(102, 25);
            this.lblAllergic.TabIndex = 60;
            this.lblAllergic.Text = " : الحساسية";
            this.lblAllergic.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnInsuranceRB
            // 
            this.pnInsuranceRB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnInsuranceRB.Controls.Add(this.rbNo);
            this.pnInsuranceRB.Controls.Add(this.rbYes);
            this.pnInsuranceRB.Location = new System.Drawing.Point(314, 449);
            this.pnInsuranceRB.Name = "pnInsuranceRB";
            this.pnInsuranceRB.Size = new System.Drawing.Size(178, 44);
            this.pnInsuranceRB.TabIndex = 63;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNo.CheckedState.BorderThickness = 0;
            this.rbNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbNo.CheckedState.InnerOffset = -4;
            this.rbNo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(46, 3);
            this.rbNo.Name = "rbNo";
            this.rbNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbNo.Size = new System.Drawing.Size(40, 29);
            this.rbNo.TabIndex = 57;
            this.rbNo.Text = "لا";
            this.rbNo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbNo.UncheckedState.BorderThickness = 2;
            this.rbNo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbYes.CheckedState.BorderThickness = 0;
            this.rbYes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbYes.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbYes.CheckedState.InnerOffset = -4;
            this.rbYes.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.Location = new System.Drawing.Point(108, 3);
            this.rbYes.Name = "rbYes";
            this.rbYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbYes.Size = new System.Drawing.Size(56, 29);
            this.rbYes.TabIndex = 56;
            this.rbYes.Text = "نعم";
            this.rbYes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbYes.UncheckedState.BorderThickness = 2;
            this.rbYes.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbYes.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // lblInsurance
            // 
            this.lblInsurance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsurance.ForeColor = System.Drawing.Color.Black;
            this.lblInsurance.Location = new System.Drawing.Point(497, 449);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(119, 25);
            this.lblInsurance.TabIndex = 62;
            this.lblInsurance.Text = " : تأمين صحي";
            this.lblInsurance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpExpier
            // 
            this.dtpExpier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpExpier.BackColor = System.Drawing.Color.Transparent;
            this.dtpExpier.Checked = true;
            this.dtpExpier.FillColor = System.Drawing.Color.LightGray;
            this.dtpExpier.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpier.Location = new System.Drawing.Point(93, 115);
            this.dtpExpier.Margin = new System.Windows.Forms.Padding(2);
            this.dtpExpier.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpier.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpier.Name = "dtpExpier";
            this.dtpExpier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpExpier.Size = new System.Drawing.Size(240, 24);
            this.dtpExpier.TabIndex = 69;
            this.dtpExpier.UseTransparentBackground = true;
            this.dtpExpier.Value = new System.DateTime(2026, 11, 18, 15, 27, 27, 776);
            // 
            // lblExpier
            // 
            this.lblExpier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpier.AutoSize = true;
            this.lblExpier.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpier.ForeColor = System.Drawing.Color.Black;
            this.lblExpier.Location = new System.Drawing.Point(346, 114);
            this.lblExpier.Name = "lblExpier";
            this.lblExpier.Size = new System.Drawing.Size(121, 25);
            this.lblExpier.TabIndex = 68;
            this.lblExpier.Text = " : تاريخ الانتهاء";
            this.lblExpier.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbInsuranceNum
            // 
            this.tbInsuranceNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInsuranceNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInsuranceNum.DefaultText = "";
            this.tbInsuranceNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbInsuranceNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbInsuranceNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbInsuranceNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbInsuranceNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbInsuranceNum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInsuranceNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbInsuranceNum.Location = new System.Drawing.Point(93, 9);
            this.tbInsuranceNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbInsuranceNum.Name = "tbInsuranceNum";
            this.tbInsuranceNum.PlaceholderText = "";
            this.tbInsuranceNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbInsuranceNum.SelectedText = "";
            this.tbInsuranceNum.Size = new System.Drawing.Size(239, 24);
            this.tbInsuranceNum.TabIndex = 67;
            // 
            // lblInsurancePercentage
            // 
            this.lblInsurancePercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInsurancePercentage.AutoSize = true;
            this.lblInsurancePercentage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsurancePercentage.ForeColor = System.Drawing.Color.Black;
            this.lblInsurancePercentage.Location = new System.Drawing.Point(346, 60);
            this.lblInsurancePercentage.Name = "lblInsurancePercentage";
            this.lblInsurancePercentage.Size = new System.Drawing.Size(122, 25);
            this.lblInsurancePercentage.TabIndex = 65;
            this.lblInsurancePercentage.Text = " : نسبة التأمين";
            this.lblInsurancePercentage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblInsuranceNum
            // 
            this.lblInsuranceNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInsuranceNum.AutoSize = true;
            this.lblInsuranceNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsuranceNum.ForeColor = System.Drawing.Color.Black;
            this.lblInsuranceNum.Location = new System.Drawing.Point(352, 9);
            this.lblInsuranceNum.Name = "lblInsuranceNum";
            this.lblInsuranceNum.Size = new System.Drawing.Size(111, 25);
            this.lblInsuranceNum.TabIndex = 64;
            this.lblInsuranceNum.Text = " : رقم التأمين";
            this.lblInsuranceNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TrackBarPercentage
            // 
            this.TrackBarPercentage.Location = new System.Drawing.Point(95, 60);
            this.TrackBarPercentage.Name = "TrackBarPercentage";
            this.TrackBarPercentage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TrackBarPercentage.Size = new System.Drawing.Size(241, 23);
            this.TrackBarPercentage.SmallChange = 5;
            this.TrackBarPercentage.TabIndex = 70;
            this.TrackBarPercentage.ThumbColor = System.Drawing.SystemColors.GrayText;
            this.TrackBarPercentage.Value = 5;
            this.TrackBarPercentage.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarPercentage_Scroll);
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPercentage.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblPercentage.ForeColor = System.Drawing.Color.Black;
            this.lblPercentage.Location = new System.Drawing.Point(3, 56);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPercentage.Size = new System.Drawing.Size(74, 33);
            this.lblPercentage.TabIndex = 71;
            this.lblPercentage.Text = "5 %";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnSaveChanges.Location = new System.Drawing.Point(36, 120);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(105, 70);
            this.btnSaveChanges.TabIndex = 72;
            this.btnSaveChanges.Text = "حفظ";
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
            this.btnCancel.Location = new System.Drawing.Point(36, 237);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 70);
            this.btnCancel.TabIndex = 73;
            this.btnCancel.Text = "الغاء";
            // 
            // pnlInsuranceOptions
            // 
            this.pnlInsuranceOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlInsuranceOptions.Controls.Add(this.lblInsuranceNum);
            this.pnlInsuranceOptions.Controls.Add(this.lblInsurancePercentage);
            this.pnlInsuranceOptions.Controls.Add(this.lblPercentage);
            this.pnlInsuranceOptions.Controls.Add(this.lblExpier);
            this.pnlInsuranceOptions.Controls.Add(this.tbInsuranceNum);
            this.pnlInsuranceOptions.Controls.Add(this.TrackBarPercentage);
            this.pnlInsuranceOptions.Controls.Add(this.dtpExpier);
            this.pnlInsuranceOptions.Enabled = false;
            this.pnlInsuranceOptions.Location = new System.Drawing.Point(154, 499);
            this.pnlInsuranceOptions.Name = "pnlInsuranceOptions";
            this.pnlInsuranceOptions.Size = new System.Drawing.Size(487, 163);
            this.pnlInsuranceOptions.TabIndex = 74;
            // 
            // frmAddEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 664);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.pnInsuranceRB);
            this.Controls.Add(this.lblInsurance);
            this.Controls.Add(this.tbAllergic);
            this.Controls.Add(this.lblAllergic);
            this.Controls.Add(this.tbChronicDiseases);
            this.Controls.Add(this.lblChronicDiseases);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.lblPhonNumber);
            this.Controls.Add(this.pnType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblAgeNum);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPatientIDNum);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.pnlInsuranceOptions);
            this.Name = "frmAddEditPatient";
            this.Text = "اضافة مريض";
            this.pnType.ResumeLayout(false);
            this.pnType.PerformLayout();
            this.pnInsuranceRB.ResumeLayout(false);
            this.pnInsuranceRB.PerformLayout();
            this.pnlInsuranceOptions.ResumeLayout(false);
            this.pnlInsuranceOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientIDNum;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAgeNum;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel pnType;
        private Guna.UI2.WinForms.Guna2RadioButton rbFemale;
        private Guna.UI2.WinForms.Guna2RadioButton rbMale;
        private Guna.UI2.WinForms.Guna2TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblPhonNumber;
        private Guna.UI2.WinForms.Guna2TextBox tbChronicDiseases;
        private System.Windows.Forms.Label lblChronicDiseases;
        private Guna.UI2.WinForms.Guna2TextBox tbAllergic;
        private System.Windows.Forms.Label lblAllergic;
        private System.Windows.Forms.Panel pnInsuranceRB;
        private Guna.UI2.WinForms.Guna2RadioButton rbNo;
        private Guna.UI2.WinForms.Guna2RadioButton rbYes;
        private System.Windows.Forms.Label lblInsurance;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpier;
        private System.Windows.Forms.Label lblExpier;
        private Guna.UI2.WinForms.Guna2TextBox tbInsuranceNum;
        private System.Windows.Forms.Label lblInsurancePercentage;
        private System.Windows.Forms.Label lblInsuranceNum;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBarPercentage;
        private System.Windows.Forms.Label lblPercentage;
        private Guna.UI2.WinForms.Guna2Button btnSaveChanges;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Panel pnlInsuranceOptions;
    }
}