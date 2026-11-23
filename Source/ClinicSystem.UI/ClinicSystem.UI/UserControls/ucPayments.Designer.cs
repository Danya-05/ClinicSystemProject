namespace ClinicSystem.UI.UserControls
{
    partial class ucPayments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plNumbers = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMonthlyDuesCount = new System.Windows.Forms.Label();
            this.lblTotalPayedCount = new System.Windows.Forms.Label();
            this.lblMonthlyDues = new System.Windows.Forms.Label();
            this.lblTotalPayed = new System.Windows.Forms.Label();
            this.btnEditPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPayment = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPaymentsLog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblPaymentsLog = new System.Windows.Forms.Label();
            this.cbSearchPatient = new System.Windows.Forms.ComboBox();
            this.plNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsLog)).BeginInit();
            this.SuspendLayout();
            // 
            // plNumbers
            // 
            this.plNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plNumbers.Controls.Add(this.lblMonthlyDuesCount);
            this.plNumbers.Controls.Add(this.lblTotalPayedCount);
            this.plNumbers.Controls.Add(this.lblMonthlyDues);
            this.plNumbers.Controls.Add(this.lblTotalPayed);
            this.plNumbers.Location = new System.Drawing.Point(52, 396);
            this.plNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.plNumbers.Name = "plNumbers";
            this.plNumbers.Size = new System.Drawing.Size(345, 109);
            this.plNumbers.TabIndex = 51;
            // 
            // lblMonthlyDuesCount
            // 
            this.lblMonthlyDuesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthlyDuesCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyDuesCount.ForeColor = System.Drawing.Color.Black;
            this.lblMonthlyDuesCount.Location = new System.Drawing.Point(25, 61);
            this.lblMonthlyDuesCount.Name = "lblMonthlyDuesCount";
            this.lblMonthlyDuesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMonthlyDuesCount.Size = new System.Drawing.Size(74, 33);
            this.lblMonthlyDuesCount.TabIndex = 33;
            this.lblMonthlyDuesCount.Text = "10 دأ";
            this.lblMonthlyDuesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPayedCount
            // 
            this.lblTotalPayedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPayedCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayedCount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPayedCount.Location = new System.Drawing.Point(25, 27);
            this.lblTotalPayedCount.Name = "lblTotalPayedCount";
            this.lblTotalPayedCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPayedCount.Size = new System.Drawing.Size(74, 33);
            this.lblTotalPayedCount.TabIndex = 31;
            this.lblTotalPayedCount.Text = "10 دأ";
            this.lblTotalPayedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMonthlyDues
            // 
            this.lblMonthlyDues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthlyDues.AutoSize = true;
            this.lblMonthlyDues.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyDues.ForeColor = System.Drawing.Color.Black;
            this.lblMonthlyDues.Location = new System.Drawing.Point(105, 61);
            this.lblMonthlyDues.Name = "lblMonthlyDues";
            this.lblMonthlyDues.Size = new System.Drawing.Size(153, 25);
            this.lblMonthlyDues.TabIndex = 29;
            this.lblMonthlyDues.Text = ":  مستحقات الشهر";
            this.lblMonthlyDues.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalPayed
            // 
            this.lblTotalPayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPayed.AutoSize = true;
            this.lblTotalPayed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayed.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPayed.Location = new System.Drawing.Point(105, 27);
            this.lblTotalPayed.Name = "lblTotalPayed";
            this.lblTotalPayed.Size = new System.Drawing.Size(228, 25);
            this.lblTotalPayed.TabIndex = 28;
            this.lblTotalPayed.Text = ": اجمالي المدفوع هذا الشهر";
            this.lblTotalPayed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEditPayment
            // 
            this.btnEditPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditPayment.FillColor = System.Drawing.Color.Silver;
            this.btnEditPayment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditPayment.ForeColor = System.Drawing.Color.Black;
            this.btnEditPayment.Location = new System.Drawing.Point(482, 451);
            this.btnEditPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPayment.Name = "btnEditPayment";
            this.btnEditPayment.Size = new System.Drawing.Size(118, 50);
            this.btnEditPayment.TabIndex = 48;
            this.btnEditPayment.Text = "تعديل دفعة";
            this.btnEditPayment.Click += new System.EventHandler(this.btnEditPayment_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPayment.FillColor = System.Drawing.Color.Silver;
            this.btnAddPayment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddPayment.ForeColor = System.Drawing.Color.Black;
            this.btnAddPayment.Location = new System.Drawing.Point(649, 451);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(118, 50);
            this.btnAddPayment.TabIndex = 46;
            this.btnAddPayment.Text = "اضافة دفعة";
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // dgvPaymentsLog
            // 
            this.dgvPaymentsLog.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPaymentsLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaymentsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPaymentsLog.ColumnHeadersHeight = 4;
            this.dgvPaymentsLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentsLog.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPaymentsLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPaymentsLog.Location = new System.Drawing.Point(106, 87);
            this.dgvPaymentsLog.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPaymentsLog.Name = "dgvPaymentsLog";
            this.dgvPaymentsLog.RowHeadersVisible = false;
            this.dgvPaymentsLog.RowTemplate.Height = 24;
            this.dgvPaymentsLog.Size = new System.Drawing.Size(664, 263);
            this.dgvPaymentsLog.TabIndex = 44;
            this.dgvPaymentsLog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPaymentsLog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPaymentsLog.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPaymentsLog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPaymentsLog.ThemeStyle.RowsStyle.Height = 24;
            // 
            // lblPaymentsLog
            // 
            this.lblPaymentsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentsLog.AutoSize = true;
            this.lblPaymentsLog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentsLog.ForeColor = System.Drawing.Color.Black;
            this.lblPaymentsLog.Location = new System.Drawing.Point(617, 29);
            this.lblPaymentsLog.Name = "lblPaymentsLog";
            this.lblPaymentsLog.Size = new System.Drawing.Size(141, 25);
            this.lblPaymentsLog.TabIndex = 42;
            this.lblPaymentsLog.Text = " :  سجل الدفعات";
            this.lblPaymentsLog.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbSearchPatient
            // 
            this.cbSearchPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSearchPatient.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.cbSearchPatient.FormattingEnabled = true;
            this.cbSearchPatient.Location = new System.Drawing.Point(482, 381);
            this.cbSearchPatient.Name = "cbSearchPatient";
            this.cbSearchPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSearchPatient.Size = new System.Drawing.Size(287, 28);
            this.cbSearchPatient.Sorted = true;
            this.cbSearchPatient.TabIndex = 52;
            this.cbSearchPatient.Text = "ابحث عن مريض";
            // 
            // ucPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbSearchPatient);
            this.Controls.Add(this.plNumbers);
            this.Controls.Add(this.btnEditPayment);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.dgvPaymentsLog);
            this.Controls.Add(this.lblPaymentsLog);
            this.Name = "ucPayments";
            this.Size = new System.Drawing.Size(877, 566);
            this.plNumbers.ResumeLayout(false);
            this.plNumbers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel plNumbers;
        private System.Windows.Forms.Label lblTotalPayedCount;
        private System.Windows.Forms.Label lblMonthlyDues;
        private System.Windows.Forms.Label lblTotalPayed;
        private Guna.UI2.WinForms.Guna2Button btnEditPayment;
        private Guna.UI2.WinForms.Guna2Button btnAddPayment;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPaymentsLog;
        private System.Windows.Forms.Label lblPaymentsLog;
        private System.Windows.Forms.ComboBox cbSearchPatient;
        private System.Windows.Forms.Label lblMonthlyDuesCount;
    }
}
