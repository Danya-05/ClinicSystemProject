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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
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
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
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
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
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
