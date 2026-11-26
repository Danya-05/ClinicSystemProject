namespace ClinicSystem.UI.Forms
{
    partial class frmAddEditUser
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
            this.lblUserIDNum = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.gbLoginData = new System.Windows.Forms.GroupBox();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.gbUserData = new System.Windows.Forms.GroupBox();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbSpecialize = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSpecialize = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveChanges = new Guna.UI2.WinForms.Guna2Button();
            this.gbLoginData.SuspendLayout();
            this.gbUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserIDNum
            // 
            this.lblUserIDNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserIDNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDNum.ForeColor = System.Drawing.Color.Black;
            this.lblUserIDNum.Location = new System.Drawing.Point(601, 9);
            this.lblUserIDNum.Name = "lblUserIDNum";
            this.lblUserIDNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserIDNum.Size = new System.Drawing.Size(74, 33);
            this.lblUserIDNum.TabIndex = 34;
            this.lblUserIDNum.Text = "10";
            this.lblUserIDNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(681, 9);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(140, 25);
            this.lblUserID.TabIndex = 33;
            this.lblUserID.Text = " : رقم المستخدم ";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbLoginData
            // 
            this.gbLoginData.Controls.Add(this.cbUserType);
            this.gbLoginData.Controls.Add(this.lblUserType);
            this.gbLoginData.Controls.Add(this.tbPassword);
            this.gbLoginData.Controls.Add(this.lblPassword);
            this.gbLoginData.Controls.Add(this.tbUsername);
            this.gbLoginData.Controls.Add(this.lblUsername);
            this.gbLoginData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoginData.Location = new System.Drawing.Point(319, 45);
            this.gbLoginData.Name = "gbLoginData";
            this.gbLoginData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbLoginData.Size = new System.Drawing.Size(489, 163);
            this.gbLoginData.TabIndex = 35;
            this.gbLoginData.TabStop = false;
            this.gbLoginData.Text = "بيانات الدخول";
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.Location = new System.Drawing.Point(74, 36);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PlaceholderText = "";
            this.tbUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbUsername.SelectedText = "";
            this.tbUsername.Size = new System.Drawing.Size(239, 24);
            this.tbUsername.TabIndex = 38;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(324, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(140, 25);
            this.lblUsername.TabIndex = 37;
            this.lblUsername.Text = " : اسم المستخدم";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(74, 77);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(239, 24);
            this.tbPassword.TabIndex = 40;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(324, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPassword.Size = new System.Drawing.Size(115, 25);
            this.lblPassword.TabIndex = 39;
            this.lblPassword.Text = " : كلمة المرور";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.Black;
            this.lblUserType.Location = new System.Drawing.Point(324, 115);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserType.Size = new System.Drawing.Size(136, 25);
            this.lblUserType.TabIndex = 41;
            this.lblUserType.Text = " : نوع المستخدم";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbUserType
            // 
            this.cbUserType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUserType.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Location = new System.Drawing.Point(73, 112);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbUserType.Size = new System.Drawing.Size(240, 28);
            this.cbUserType.Sorted = true;
            this.cbUserType.TabIndex = 59;
            // 
            // gbUserData
            // 
            this.gbUserData.Controls.Add(this.tbSpecialize);
            this.gbUserData.Controls.Add(this.lblSpecialize);
            this.gbUserData.Controls.Add(this.tbPhoneNumber);
            this.gbUserData.Controls.Add(this.lblPhoneNumber);
            this.gbUserData.Controls.Add(this.tbLastName);
            this.gbUserData.Controls.Add(this.lblLastName);
            this.gbUserData.Controls.Add(this.tbFirstName);
            this.gbUserData.Controls.Add(this.lblFirstName);
            this.gbUserData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserData.Location = new System.Drawing.Point(38, 229);
            this.gbUserData.Name = "gbUserData";
            this.gbUserData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbUserData.Size = new System.Drawing.Size(770, 132);
            this.gbUserData.TabIndex = 60;
            this.gbUserData.TabStop = false;
            this.gbUserData.Text = "بيانات المستخدم";
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
            this.tbLastName.Location = new System.Drawing.Point(393, 80);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PlaceholderText = "";
            this.tbLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbLastName.SelectedText = "";
            this.tbLastName.Size = new System.Drawing.Size(239, 24);
            this.tbLastName.TabIndex = 40;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(643, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastName.Size = new System.Drawing.Size(119, 25);
            this.lblLastName.TabIndex = 39;
            this.lblLastName.Text = " : الاسم الثاني";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.tbFirstName.Location = new System.Drawing.Point(393, 39);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PlaceholderText = "";
            this.tbFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.Size = new System.Drawing.Size(239, 24);
            this.tbFirstName.TabIndex = 38;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(643, 38);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirstName.Size = new System.Drawing.Size(114, 25);
            this.lblFirstName.TabIndex = 37;
            this.lblFirstName.Text = " : الاسم الاول";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbSpecialize
            // 
            this.tbSpecialize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSpecialize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSpecialize.DefaultText = "";
            this.tbSpecialize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSpecialize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSpecialize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSpecialize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSpecialize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSpecialize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpecialize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSpecialize.Location = new System.Drawing.Point(26, 79);
            this.tbSpecialize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSpecialize.Name = "tbSpecialize";
            this.tbSpecialize.PlaceholderText = "";
            this.tbSpecialize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSpecialize.SelectedText = "";
            this.tbSpecialize.Size = new System.Drawing.Size(239, 24);
            this.tbSpecialize.TabIndex = 44;
            // 
            // lblSpecialize
            // 
            this.lblSpecialize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpecialize.AutoSize = true;
            this.lblSpecialize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialize.ForeColor = System.Drawing.Color.Black;
            this.lblSpecialize.Location = new System.Drawing.Point(276, 78);
            this.lblSpecialize.Name = "lblSpecialize";
            this.lblSpecialize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSpecialize.Size = new System.Drawing.Size(109, 25);
            this.lblSpecialize.TabIndex = 43;
            this.lblSpecialize.Text = " : الاختصاص";
            this.lblSpecialize.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.tbPhoneNumber.Location = new System.Drawing.Point(26, 38);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.PlaceholderText = "";
            this.tbPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPhoneNumber.SelectedText = "";
            this.tbPhoneNumber.Size = new System.Drawing.Size(239, 24);
            this.tbPhoneNumber.TabIndex = 42;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(276, 37);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhoneNumber.Size = new System.Drawing.Size(110, 25);
            this.lblPhoneNumber.TabIndex = 41;
            this.lblPhoneNumber.Text = " : رقم الهاتف";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.btnCancel.Location = new System.Drawing.Point(38, 138);
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
            this.btnSaveChanges.Location = new System.Drawing.Point(38, 45);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(105, 70);
            this.btnSaveChanges.TabIndex = 74;
            this.btnSaveChanges.Text = "حفظ";
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 387);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.gbUserData);
            this.Controls.Add(this.gbLoginData);
            this.Controls.Add(this.lblUserIDNum);
            this.Controls.Add(this.lblUserID);
            this.Name = "frmAddEditUser";
            this.Text = "اضافة مستخدم";
            this.gbLoginData.ResumeLayout(false);
            this.gbLoginData.PerformLayout();
            this.gbUserData.ResumeLayout(false);
            this.gbUserData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserIDNum;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.GroupBox gbLoginData;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserType;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cbUserType;
        private System.Windows.Forms.GroupBox gbUserData;
        private Guna.UI2.WinForms.Guna2TextBox tbSpecialize;
        private System.Windows.Forms.Label lblSpecialize;
        private Guna.UI2.WinForms.Guna2TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSaveChanges;
    }
}