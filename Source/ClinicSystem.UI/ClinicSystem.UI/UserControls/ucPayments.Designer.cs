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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plNumbers = new Guna.UI2.WinForms.Guna2Panel();
            this.lblScheduledCount = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblScheduled = new System.Windows.Forms.Label();
            this.btnEditPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPayment = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPaymentsLog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblPaymentsLog = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsLog)).BeginInit();
            this.SuspendLayout();
            // 
            // plNumbers
            // 
            this.plNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plNumbers.Controls.Add(this.label1);
            this.plNumbers.Controls.Add(this.lblScheduledCount);
            this.plNumbers.Controls.Add(this.lblCompleted);
            this.plNumbers.Controls.Add(this.lblScheduled);
            this.plNumbers.Location = new System.Drawing.Point(52, 396);
            this.plNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.plNumbers.Name = "plNumbers";
            this.plNumbers.Size = new System.Drawing.Size(345, 109);
            this.plNumbers.TabIndex = 51;
            // 
            // lblScheduledCount
            // 
            this.lblScheduledCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScheduledCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledCount.ForeColor = System.Drawing.Color.Black;
            this.lblScheduledCount.Location = new System.Drawing.Point(25, 27);
            this.lblScheduledCount.Name = "lblScheduledCount";
            this.lblScheduledCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblScheduledCount.Size = new System.Drawing.Size(74, 33);
            this.lblScheduledCount.TabIndex = 31;
            this.lblScheduledCount.Text = "10 دأ";
            this.lblScheduledCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompleted
            // 
            this.lblCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.Black;
            this.lblCompleted.Location = new System.Drawing.Point(105, 61);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(153, 25);
            this.lblCompleted.TabIndex = 29;
            this.lblCompleted.Text = ":  مستحقات الشهر";
            this.lblCompleted.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScheduled
            // 
            this.lblScheduled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScheduled.AutoSize = true;
            this.lblScheduled.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduled.ForeColor = System.Drawing.Color.Black;
            this.lblScheduled.Location = new System.Drawing.Point(105, 27);
            this.lblScheduled.Name = "lblScheduled";
            this.lblScheduled.Size = new System.Drawing.Size(228, 25);
            this.lblScheduled.TabIndex = 28;
            this.lblScheduled.Text = ": اجمالي المدفوع هذا الشهر";
            this.lblScheduled.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // 
            // dgvPaymentsLog
            // 
            this.dgvPaymentsLog.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvPaymentsLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPaymentsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPaymentsLog.ColumnHeadersHeight = 4;
            this.dgvPaymentsLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentsLog.DefaultCellStyle = dataGridViewCellStyle9;
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
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(482, 381);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(287, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 52;
            this.comboBox1.Text = "ابحث عن مريض";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(74, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "10 دأ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.Label lblScheduledCount;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblScheduled;
        private Guna.UI2.WinForms.Guna2Button btnEditPayment;
        private Guna.UI2.WinForms.Guna2Button btnAddPayment;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPaymentsLog;
        private System.Windows.Forms.Label lblPaymentsLog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
