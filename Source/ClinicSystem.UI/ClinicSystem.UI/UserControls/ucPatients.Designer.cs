namespace ClinicSystem.UI.UserControls
{
    partial class ucPatients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShowAllPayments = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddVisite = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowMedicalFile = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeletePatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPatient = new Guna.UI2.WinForms.Guna2Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbSearchPatient = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPatientSearch = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAllPayments
            // 
            this.btnShowAllPayments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowAllPayments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAllPayments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAllPayments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowAllPayments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowAllPayments.FillColor = System.Drawing.Color.Silver;
            this.btnShowAllPayments.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnShowAllPayments.ForeColor = System.Drawing.Color.Black;
            this.btnShowAllPayments.Location = new System.Drawing.Point(162, 599);
            this.btnShowAllPayments.Name = "btnShowAllPayments";
            this.btnShowAllPayments.Size = new System.Drawing.Size(158, 62);
            this.btnShowAllPayments.TabIndex = 25;
            this.btnShowAllPayments.Text = "عرض الدفعات السابقة";
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPayment.FillColor = System.Drawing.Color.Silver;
            this.btnAddPayment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddPayment.ForeColor = System.Drawing.Color.Black;
            this.btnAddPayment.Location = new System.Drawing.Point(391, 599);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(158, 62);
            this.btnAddPayment.TabIndex = 24;
            this.btnAddPayment.Text = "اضافة دفعة";
            // 
            // btnAddVisite
            // 
            this.btnAddVisite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddVisite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddVisite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddVisite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddVisite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddVisite.FillColor = System.Drawing.Color.Silver;
            this.btnAddVisite.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddVisite.ForeColor = System.Drawing.Color.Black;
            this.btnAddVisite.Location = new System.Drawing.Point(620, 599);
            this.btnAddVisite.Name = "btnAddVisite";
            this.btnAddVisite.Size = new System.Drawing.Size(158, 62);
            this.btnAddVisite.TabIndex = 23;
            this.btnAddVisite.Text = "اضافة زيارة";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAppointment.FillColor = System.Drawing.Color.Silver;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddAppointment.ForeColor = System.Drawing.Color.Black;
            this.btnAddAppointment.Location = new System.Drawing.Point(849, 599);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(158, 62);
            this.btnAddAppointment.TabIndex = 22;
            this.btnAddAppointment.Text = "اضافة موعد";
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
            this.btnShowMedicalFile.Location = new System.Drawing.Point(162, 499);
            this.btnShowMedicalFile.Name = "btnShowMedicalFile";
            this.btnShowMedicalFile.Size = new System.Drawing.Size(158, 62);
            this.btnShowMedicalFile.TabIndex = 21;
            this.btnShowMedicalFile.Text = "عرض الملف الطبي لمريض";
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditPatient.FillColor = System.Drawing.Color.Silver;
            this.btnEditPatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditPatient.ForeColor = System.Drawing.Color.Black;
            this.btnEditPatient.Location = new System.Drawing.Point(391, 499);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(158, 62);
            this.btnEditPatient.TabIndex = 20;
            this.btnEditPatient.Text = "تعديل مريض";
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletePatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletePatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletePatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeletePatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeletePatient.FillColor = System.Drawing.Color.Silver;
            this.btnDeletePatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDeletePatient.ForeColor = System.Drawing.Color.Black;
            this.btnDeletePatient.Location = new System.Drawing.Point(620, 499);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(158, 62);
            this.btnDeletePatient.TabIndex = 19;
            this.btnDeletePatient.Text = "حذف مريض";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPatient.FillColor = System.Drawing.Color.Silver;
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddPatient.ForeColor = System.Drawing.Color.Black;
            this.btnAddPatient.Location = new System.Drawing.Point(849, 499);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(158, 62);
            this.btnAddPatient.TabIndex = 18;
            this.btnAddPatient.Text = "اضافة مريض";
            // 
            // lblNote
            // 
            this.lblNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(780, 446);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(227, 20);
            this.lblNote.TabIndex = 17;
            this.lblNote.Text = " حدد المريض من الجدول قبل الاختيار *";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(162, 107);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(845, 324);
            this.guna2DataGridView1.TabIndex = 16;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            // 
            // tbSearchPatient
            // 
            this.tbSearchPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchPatient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchPatient.DefaultText = "ادخل اسم المريض او رقم الهاتف";
            this.tbSearchPatient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchPatient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchPatient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchPatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchPatient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchPatient.Location = new System.Drawing.Point(284, 36);
            this.tbSearchPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearchPatient.Name = "tbSearchPatient";
            this.tbSearchPatient.PlaceholderText = "";
            this.tbSearchPatient.SelectedText = "";
            this.tbSearchPatient.Size = new System.Drawing.Size(553, 30);
            this.tbSearchPatient.TabIndex = 15;
            this.tbSearchPatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPatientSearch
            // 
            this.lblPatientSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatientSearch.AutoSize = true;
            this.lblPatientSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientSearch.ForeColor = System.Drawing.Color.Black;
            this.lblPatientSearch.Location = new System.Drawing.Point(844, 36);
            this.lblPatientSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientSearch.Name = "lblPatientSearch";
            this.lblPatientSearch.Size = new System.Drawing.Size(163, 25);
            this.lblPatientSearch.TabIndex = 14;
            this.lblPatientSearch.Text = " : البحث عن مريض ";
            this.lblPatientSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Silver;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(162, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 30);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "تفريغ";
            // 
            // ucPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowAllPayments);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.btnAddVisite);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnShowMedicalFile);
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.tbSearchPatient);
            this.Controls.Add(this.lblPatientSearch);
            this.Name = "ucPatients";
            this.Size = new System.Drawing.Size(1169, 697);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnShowAllPayments;
        private Guna.UI2.WinForms.Guna2Button btnAddPayment;
        private Guna.UI2.WinForms.Guna2Button btnAddVisite;
        private Guna.UI2.WinForms.Guna2Button btnAddAppointment;
        private Guna.UI2.WinForms.Guna2Button btnShowMedicalFile;
        private Guna.UI2.WinForms.Guna2Button btnEditPatient;
        private Guna.UI2.WinForms.Guna2Button btnDeletePatient;
        private Guna.UI2.WinForms.Guna2Button btnAddPatient;
        private System.Windows.Forms.Label lblNote;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchPatient;
        private System.Windows.Forms.Label lblPatientSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
    }
}
