namespace ClinicSystem.UI.Forms
{
    partial class frmAddEditPayment
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPatientIDNum = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlNumbers = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRemainingNum = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblTotalPayedNum = new System.Windows.Forms.Label();
            this.lblTotalAmountNum = new System.Windows.Forms.Label();
            this.lblTotalPayed = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPayed = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.pnlMethods = new Guna.UI2.WinForms.Guna2Panel();
            this.rbClick = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbVisa = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbCash = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveChanges = new Guna.UI2.WinForms.Guna2Button();
            this.rtbPayed = new System.Windows.Forms.RichTextBox();
            this.pnlNumbers.SuspendLayout();
            this.pnlMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(172, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFullName.Size = new System.Drawing.Size(217, 29);
            this.lblFullName.TabIndex = 67;
            this.lblFullName.Text = "الاسم الاول و الثاني";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(395, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 25);
            this.lblName.TabIndex = 66;
            this.lblName.Text = " : المريض";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPatientIDNum
            // 
            this.lblPatientIDNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPatientIDNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientIDNum.ForeColor = System.Drawing.Color.Black;
            this.lblPatientIDNum.Location = new System.Drawing.Point(504, 5);
            this.lblPatientIDNum.Name = "lblPatientIDNum";
            this.lblPatientIDNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatientIDNum.Size = new System.Drawing.Size(74, 33);
            this.lblPatientIDNum.TabIndex = 65;
            this.lblPatientIDNum.Text = "10";
            this.lblPatientIDNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPatientID
            // 
            this.lblPatientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.Black;
            this.lblPatientID.Location = new System.Drawing.Point(591, 9);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(127, 25);
            this.lblPatientID.TabIndex = 64;
            this.lblPatientID.Text = " : رقم المريض ";
            this.lblPatientID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(640, 105);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 25);
            this.lblTime.TabIndex = 71;
            this.lblTime.Text = " : الوقت";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpTime
            // 
            this.dtpTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTime.BackColor = System.Drawing.Color.Transparent;
            this.dtpTime.Checked = true;
            this.dtpTime.CustomFormat = "hh:mm tt";
            this.dtpTime.FillColor = System.Drawing.Color.LightGray;
            this.dtpTime.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(395, 106);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(240, 24);
            this.dtpTime.TabIndex = 70;
            this.dtpTime.UseTransparentBackground = true;
            this.dtpTime.Value = new System.DateTime(2026, 11, 18, 15, 27, 27, 776);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.Color.LightGray;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(395, 69);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpDate.Size = new System.Drawing.Size(240, 24);
            this.dtpDate.TabIndex = 69;
            this.dtpDate.UseTransparentBackground = true;
            this.dtpDate.Value = new System.DateTime(2026, 11, 18, 15, 27, 27, 776);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(637, 68);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 25);
            this.lblDate.TabIndex = 68;
            this.lblDate.Text = " : التاريخ ";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlNumbers
            // 
            this.pnlNumbers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlNumbers.Controls.Add(this.lblRemainingNum);
            this.pnlNumbers.Controls.Add(this.lblRemaining);
            this.pnlNumbers.Controls.Add(this.lblTotalPayedNum);
            this.pnlNumbers.Controls.Add(this.lblTotalAmountNum);
            this.pnlNumbers.Controls.Add(this.lblTotalPayed);
            this.pnlNumbers.Controls.Add(this.lblTotalAmount);
            this.pnlNumbers.Location = new System.Drawing.Point(397, 161);
            this.pnlNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNumbers.Name = "pnlNumbers";
            this.pnlNumbers.Size = new System.Drawing.Size(320, 126);
            this.pnlNumbers.TabIndex = 72;
            // 
            // lblRemainingNum
            // 
            this.lblRemainingNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemainingNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingNum.ForeColor = System.Drawing.Color.Black;
            this.lblRemainingNum.Location = new System.Drawing.Point(155, 90);
            this.lblRemainingNum.Name = "lblRemainingNum";
            this.lblRemainingNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRemainingNum.Size = new System.Drawing.Size(74, 33);
            this.lblRemainingNum.TabIndex = 35;
            this.lblRemainingNum.Text = "10 دأ";
            this.lblRemainingNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemaining
            // 
            this.lblRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.ForeColor = System.Drawing.Color.Black;
            this.lblRemaining.Location = new System.Drawing.Point(235, 90);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(82, 25);
            this.lblRemaining.TabIndex = 34;
            this.lblRemaining.Text = ": المتبقي";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalPayedNum
            // 
            this.lblTotalPayedNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPayedNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayedNum.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPayedNum.Location = new System.Drawing.Point(87, 47);
            this.lblTotalPayedNum.Name = "lblTotalPayedNum";
            this.lblTotalPayedNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPayedNum.Size = new System.Drawing.Size(74, 33);
            this.lblTotalPayedNum.TabIndex = 33;
            this.lblTotalPayedNum.Text = "10 دأ";
            this.lblTotalPayedNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmountNum
            // 
            this.lblTotalAmountNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmountNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountNum.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmountNum.Location = new System.Drawing.Point(102, 9);
            this.lblTotalAmountNum.Name = "lblTotalAmountNum";
            this.lblTotalAmountNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalAmountNum.Size = new System.Drawing.Size(74, 33);
            this.lblTotalAmountNum.TabIndex = 31;
            this.lblTotalAmountNum.Text = "10 دأ";
            this.lblTotalAmountNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPayed
            // 
            this.lblTotalPayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPayed.AutoSize = true;
            this.lblTotalPayed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayed.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPayed.Location = new System.Drawing.Point(167, 51);
            this.lblTotalPayed.Name = "lblTotalPayed";
            this.lblTotalPayed.Size = new System.Drawing.Size(150, 25);
            this.lblTotalPayed.TabIndex = 29;
            this.lblTotalPayed.Text = ":  اجمالي المدفوع";
            this.lblTotalPayed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(182, 9);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(135, 25);
            this.lblTotalAmount.TabIndex = 28;
            this.lblTotalAmount.Text = ": اجمالي الرسوم";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPayed
            // 
            this.lblPayed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayed.AutoSize = true;
            this.lblPayed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayed.ForeColor = System.Drawing.Color.Black;
            this.lblPayed.Location = new System.Drawing.Point(233, 69);
            this.lblPayed.Name = "lblPayed";
            this.lblPayed.Size = new System.Drawing.Size(141, 25);
            this.lblPayed.TabIndex = 74;
            this.lblPayed.Text = " : المبلغ المدفوع";
            this.lblPayed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.lblPaymentMethod.Location = new System.Drawing.Point(248, 107);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(126, 25);
            this.lblPaymentMethod.TabIndex = 75;
            this.lblPaymentMethod.Text = " : طريقة الدفع";
            this.lblPaymentMethod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlMethods
            // 
            this.pnlMethods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMethods.Controls.Add(this.rbClick);
            this.pnlMethods.Controls.Add(this.rbVisa);
            this.pnlMethods.Controls.Add(this.rbCash);
            this.pnlMethods.Location = new System.Drawing.Point(7, 105);
            this.pnlMethods.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMethods.Name = "pnlMethods";
            this.pnlMethods.Size = new System.Drawing.Size(232, 38);
            this.pnlMethods.TabIndex = 76;
            // 
            // rbClick
            // 
            this.rbClick.AutoSize = true;
            this.rbClick.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbClick.CheckedState.BorderThickness = 0;
            this.rbClick.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbClick.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbClick.CheckedState.InnerOffset = -4;
            this.rbClick.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClick.Location = new System.Drawing.Point(3, 3);
            this.rbClick.Name = "rbClick";
            this.rbClick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbClick.Size = new System.Drawing.Size(66, 29);
            this.rbClick.TabIndex = 59;
            this.rbClick.Text = "كليك";
            this.rbClick.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbClick.UncheckedState.BorderThickness = 2;
            this.rbClick.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbClick.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbVisa
            // 
            this.rbVisa.AutoSize = true;
            this.rbVisa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbVisa.CheckedState.BorderThickness = 0;
            this.rbVisa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbVisa.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbVisa.CheckedState.InnerOffset = -4;
            this.rbVisa.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVisa.Location = new System.Drawing.Point(90, 3);
            this.rbVisa.Name = "rbVisa";
            this.rbVisa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbVisa.Size = new System.Drawing.Size(54, 29);
            this.rbVisa.TabIndex = 58;
            this.rbVisa.Text = "فيزا";
            this.rbVisa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbVisa.UncheckedState.BorderThickness = 2;
            this.rbVisa.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbVisa.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbCash.CheckedState.BorderThickness = 0;
            this.rbCash.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbCash.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbCash.CheckedState.InnerOffset = -4;
            this.rbCash.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(165, 3);
            this.rbCash.Name = "rbCash";
            this.rbCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbCash.Size = new System.Drawing.Size(64, 29);
            this.rbCash.TabIndex = 57;
            this.rbCash.Text = "كاش";
            this.rbCash.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbCash.UncheckedState.BorderThickness = 2;
            this.rbCash.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbCash.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
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
            this.btnCancel.Location = new System.Drawing.Point(11, 206);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 70);
            this.btnCancel.TabIndex = 78;
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
            this.btnSaveChanges.Location = new System.Drawing.Point(176, 206);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(105, 70);
            this.btnSaveChanges.TabIndex = 77;
            this.btnSaveChanges.Text = "حفظ";
            // 
            // rtbPayed
            // 
            this.rtbPayed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbPayed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPayed.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rtbPayed.Location = new System.Drawing.Point(7, 69);
            this.rtbPayed.Name = "rtbPayed";
            this.rtbPayed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbPayed.Size = new System.Drawing.Size(232, 31);
            this.rtbPayed.TabIndex = 85;
            this.rtbPayed.Text = "15";
            // 
            // frmAddEditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 298);
            this.Controls.Add(this.rtbPayed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.pnlMethods);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblPayed);
            this.Controls.Add(this.pnlNumbers);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPatientIDNum);
            this.Controls.Add(this.lblPatientID);
            this.Name = "frmAddEditPayment";
            this.Text = "اضافة دفعة";
            this.pnlNumbers.ResumeLayout(false);
            this.pnlNumbers.PerformLayout();
            this.pnlMethods.ResumeLayout(false);
            this.pnlMethods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPatientIDNum;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2Panel pnlNumbers;
        private System.Windows.Forms.Label lblTotalPayedNum;
        private System.Windows.Forms.Label lblTotalAmountNum;
        private System.Windows.Forms.Label lblTotalPayed;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblRemainingNum;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblPayed;
        private System.Windows.Forms.Label lblPaymentMethod;
        private Guna.UI2.WinForms.Guna2Panel pnlMethods;
        private Guna.UI2.WinForms.Guna2RadioButton rbClick;
        private Guna.UI2.WinForms.Guna2RadioButton rbVisa;
        private Guna.UI2.WinForms.Guna2RadioButton rbCash;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSaveChanges;
        private System.Windows.Forms.RichTextBox rtbPayed;
    }
}