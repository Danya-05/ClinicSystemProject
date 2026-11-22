namespace ClinicSystem.UI.Forms
{
    partial class frmMedicalFile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPatientIDNum = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPreviousVisits = new System.Windows.Forms.Label();
            this.dgvPreviousVisits = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvPrescriptions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblAllPrescriptions = new System.Windows.Forms.Label();
            this.dgvDiagnoses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblAllDiagnoses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnoses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatientIDNum
            // 
            this.lblPatientIDNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPatientIDNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientIDNum.ForeColor = System.Drawing.Color.Black;
            this.lblPatientIDNum.Location = new System.Drawing.Point(322, 31);
            this.lblPatientIDNum.Name = "lblPatientIDNum";
            this.lblPatientIDNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatientIDNum.Size = new System.Drawing.Size(74, 33);
            this.lblPatientIDNum.TabIndex = 34;
            this.lblPatientIDNum.Text = "10";
            this.lblPatientIDNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPatientID
            // 
            this.lblPatientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.Black;
            this.lblPatientID.Location = new System.Drawing.Point(402, 29);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(116, 25);
            this.lblPatientID.TabIndex = 33;
            this.lblPatientID.Text = " : رقم مريض ";
            this.lblPatientID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(246, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 35;
            this.lblName.Text = " : الاسم";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(23, 29);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFullName.Size = new System.Drawing.Size(217, 29);
            this.lblFullName.TabIndex = 36;
            this.lblFullName.Text = "الاسم الاول و الثاني";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPreviousVisits
            // 
            this.lblPreviousVisits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreviousVisits.AutoSize = true;
            this.lblPreviousVisits.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousVisits.ForeColor = System.Drawing.Color.Black;
            this.lblPreviousVisits.Location = new System.Drawing.Point(364, 89);
            this.lblPreviousVisits.Name = "lblPreviousVisits";
            this.lblPreviousVisits.Size = new System.Drawing.Size(150, 25);
            this.lblPreviousVisits.TabIndex = 37;
            this.lblPreviousVisits.Text = " : الزيارات السابقة";
            this.lblPreviousVisits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvPreviousVisits
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPreviousVisits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreviousVisits.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreviousVisits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPreviousVisits.ColumnHeadersHeight = 4;
            this.dgvPreviousVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPreviousVisits.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPreviousVisits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPreviousVisits.Location = new System.Drawing.Point(23, 117);
            this.dgvPreviousVisits.Name = "dgvPreviousVisits";
            this.dgvPreviousVisits.RowHeadersVisible = false;
            this.dgvPreviousVisits.Size = new System.Drawing.Size(495, 124);
            this.dgvPreviousVisits.TabIndex = 38;
            this.dgvPreviousVisits.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPreviousVisits.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPreviousVisits.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPreviousVisits.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dgvPrescriptions
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrescriptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrescriptions.ColumnHeadersHeight = 4;
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrescriptions.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPrescriptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrescriptions.Location = new System.Drawing.Point(23, 285);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.RowHeadersVisible = false;
            this.dgvPrescriptions.Size = new System.Drawing.Size(495, 124);
            this.dgvPrescriptions.TabIndex = 40;
            this.dgvPrescriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPrescriptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblAllPrescriptions
            // 
            this.lblAllPrescriptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAllPrescriptions.AutoSize = true;
            this.lblAllPrescriptions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPrescriptions.ForeColor = System.Drawing.Color.Black;
            this.lblAllPrescriptions.Location = new System.Drawing.Point(317, 257);
            this.lblAllPrescriptions.Name = "lblAllPrescriptions";
            this.lblAllPrescriptions.Size = new System.Drawing.Size(197, 25);
            this.lblAllPrescriptions.TabIndex = 39;
            this.lblAllPrescriptions.Text = " : جميع الوصفات الطبية";
            this.lblAllPrescriptions.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvDiagnoses
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvDiagnoses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDiagnoses.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiagnoses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDiagnoses.ColumnHeadersHeight = 4;
            this.dgvDiagnoses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiagnoses.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDiagnoses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiagnoses.Location = new System.Drawing.Point(23, 454);
            this.dgvDiagnoses.Name = "dgvDiagnoses";
            this.dgvDiagnoses.RowHeadersVisible = false;
            this.dgvDiagnoses.Size = new System.Drawing.Size(495, 124);
            this.dgvDiagnoses.TabIndex = 42;
            this.dgvDiagnoses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiagnoses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiagnoses.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDiagnoses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblAllDiagnoses
            // 
            this.lblAllDiagnoses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAllDiagnoses.AutoSize = true;
            this.lblAllDiagnoses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllDiagnoses.ForeColor = System.Drawing.Color.Black;
            this.lblAllDiagnoses.Location = new System.Drawing.Point(356, 426);
            this.lblAllDiagnoses.Name = "lblAllDiagnoses";
            this.lblAllDiagnoses.Size = new System.Drawing.Size(162, 25);
            this.lblAllDiagnoses.TabIndex = 41;
            this.lblAllDiagnoses.Text = " : جميع التشخيصات";
            this.lblAllDiagnoses.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmMedicalFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 634);
            this.Controls.Add(this.dgvDiagnoses);
            this.Controls.Add(this.lblAllDiagnoses);
            this.Controls.Add(this.dgvPrescriptions);
            this.Controls.Add(this.lblAllPrescriptions);
            this.Controls.Add(this.dgvPreviousVisits);
            this.Controls.Add(this.lblPreviousVisits);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPatientIDNum);
            this.Controls.Add(this.lblPatientID);
            this.Name = "frmMedicalFile";
            this.Text = "الملف الطبي";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnoses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientIDNum;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPreviousVisits;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPreviousVisits;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPrescriptions;
        private System.Windows.Forms.Label lblAllPrescriptions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDiagnoses;
        private System.Windows.Forms.Label lblAllDiagnoses;
    }
}