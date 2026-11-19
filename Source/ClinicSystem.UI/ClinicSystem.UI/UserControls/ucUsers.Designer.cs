namespace ClinicSystem.UI.UserControls
{
    partial class ucUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPaymentsLog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblPaymentsLog = new System.Windows.Forms.Label();
            this.btnEditPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeletePatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPatient = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaymentsLog
            // 
            this.dgvPaymentsLog.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvPaymentsLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPaymentsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPaymentsLog.ColumnHeadersHeight = 4;
            this.dgvPaymentsLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentsLog.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPaymentsLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPaymentsLog.Location = new System.Drawing.Point(106, 82);
            this.dgvPaymentsLog.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPaymentsLog.Name = "dgvPaymentsLog";
            this.dgvPaymentsLog.RowHeadersVisible = false;
            this.dgvPaymentsLog.RowTemplate.Height = 24;
            this.dgvPaymentsLog.Size = new System.Drawing.Size(664, 263);
            this.dgvPaymentsLog.TabIndex = 46;
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
            this.lblPaymentsLog.Location = new System.Drawing.Point(617, 24);
            this.lblPaymentsLog.Name = "lblPaymentsLog";
            this.lblPaymentsLog.Size = new System.Drawing.Size(171, 25);
            this.lblPaymentsLog.TabIndex = 45;
            this.lblPaymentsLog.Text = " :  جميع المستخدمين";
            this.lblPaymentsLog.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditPatient.FillColor = System.Drawing.Color.Silver;
            this.btnEditPatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditPatient.ForeColor = System.Drawing.Color.Black;
            this.btnEditPatient.Location = new System.Drawing.Point(106, 428);
            this.btnEditPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(180, 50);
            this.btnEditPatient.TabIndex = 49;
            this.btnEditPatient.Text = "حذف مستخدم";
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeletePatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletePatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletePatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeletePatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeletePatient.FillColor = System.Drawing.Color.Silver;
            this.btnDeletePatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDeletePatient.ForeColor = System.Drawing.Color.Black;
            this.btnDeletePatient.Location = new System.Drawing.Point(348, 428);
            this.btnDeletePatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(180, 50);
            this.btnDeletePatient.TabIndex = 48;
            this.btnDeletePatient.Text = "تعديل مستخدم";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPatient.FillColor = System.Drawing.Color.Silver;
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddPatient.ForeColor = System.Drawing.Color.Black;
            this.btnAddPatient.Location = new System.Drawing.Point(590, 428);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(180, 50);
            this.btnAddPatient.TabIndex = 47;
            this.btnAddPatient.Text = "اضافة مستخدم";
            // 
            // ucUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.dgvPaymentsLog);
            this.Controls.Add(this.lblPaymentsLog);
            this.Name = "ucUsers";
            this.Size = new System.Drawing.Size(877, 566);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvPaymentsLog;
        private System.Windows.Forms.Label lblPaymentsLog;
        private Guna.UI2.WinForms.Guna2Button btnEditPatient;
        private Guna.UI2.WinForms.Guna2Button btnDeletePatient;
        private Guna.UI2.WinForms.Guna2Button btnAddPatient;
    }
}
