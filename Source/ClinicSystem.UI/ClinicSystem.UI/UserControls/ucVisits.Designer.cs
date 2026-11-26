namespace ClinicSystem.UI.UserControls
{
    partial class ucVisits
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
            this.dtpCalendar = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddVisit = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditVisit = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowVisitDetails = new Guna.UI2.WinForms.Guna2Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.dgvVisits = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbVisitSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVisitSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpCalendar
            // 
            this.dtpCalendar.BackColor = System.Drawing.Color.Transparent;
            this.dtpCalendar.Checked = true;
            this.dtpCalendar.FillColor = System.Drawing.Color.LightGray;
            this.dtpCalendar.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCalendar.Location = new System.Drawing.Point(206, 29);
            this.dtpCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCalendar.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCalendar.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCalendar.Name = "dtpCalendar";
            this.dtpCalendar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpCalendar.Size = new System.Drawing.Size(191, 24);
            this.dtpCalendar.TabIndex = 52;
            this.dtpCalendar.UseTransparentBackground = true;
            this.dtpCalendar.Value = new System.DateTime(2026, 11, 18, 15, 27, 27, 776);
            // 
            // btnClear
            // 
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Silver;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(115, 29);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 24);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "تفريغ";
            // 
            // btnAddVisit
            // 
            this.btnAddVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVisit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddVisit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddVisit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddVisit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddVisit.FillColor = System.Drawing.Color.Silver;
            this.btnAddVisit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddVisit.ForeColor = System.Drawing.Color.Black;
            this.btnAddVisit.Location = new System.Drawing.Point(661, 405);
            this.btnAddVisit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddVisit.Name = "btnAddVisit";
            this.btnAddVisit.Size = new System.Drawing.Size(118, 50);
            this.btnAddVisit.TabIndex = 49;
            this.btnAddVisit.Text = "انشاء زيارة";
            this.btnAddVisit.Click += new System.EventHandler(this.btnAddVisit_Click);
            // 
            // btnEditVisit
            // 
            this.btnEditVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditVisit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditVisit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditVisit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditVisit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditVisit.FillColor = System.Drawing.Color.Silver;
            this.btnEditVisit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditVisit.ForeColor = System.Drawing.Color.Black;
            this.btnEditVisit.Location = new System.Drawing.Point(489, 405);
            this.btnEditVisit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditVisit.Name = "btnEditVisit";
            this.btnEditVisit.Size = new System.Drawing.Size(118, 50);
            this.btnEditVisit.TabIndex = 48;
            this.btnEditVisit.Text = "تعديل زيارة";
            this.btnEditVisit.Click += new System.EventHandler(this.btnEditVisit_Click);
            // 
            // btnShowVisitDetails
            // 
            this.btnShowVisitDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowVisitDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowVisitDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowVisitDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowVisitDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowVisitDetails.FillColor = System.Drawing.Color.Silver;
            this.btnShowVisitDetails.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnShowVisitDetails.ForeColor = System.Drawing.Color.Black;
            this.btnShowVisitDetails.Location = new System.Drawing.Point(317, 405);
            this.btnShowVisitDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowVisitDetails.Name = "btnShowVisitDetails";
            this.btnShowVisitDetails.Size = new System.Drawing.Size(118, 50);
            this.btnShowVisitDetails.TabIndex = 46;
            this.btnShowVisitDetails.Text = "عرض تفاصيل زيارة";
            this.btnShowVisitDetails.Click += new System.EventHandler(this.btnShowVisit_Click);
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(561, 362);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(269, 25);
            this.lblNote.TabIndex = 45;
            this.lblNote.Text = " حدد الزيارة من الجدول قبل الاختيار *";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvVisits
            // 
            this.dgvVisits.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVisits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVisits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVisits.ColumnHeadersHeight = 4;
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisits.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVisits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVisits.Location = new System.Drawing.Point(115, 87);
            this.dgvVisits.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.RowHeadersVisible = false;
            this.dgvVisits.RowHeadersWidth = 51;
            this.dgvVisits.RowTemplate.Height = 24;
            this.dgvVisits.Size = new System.Drawing.Size(664, 263);
            this.dgvVisits.TabIndex = 44;
            this.dgvVisits.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVisits.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVisits.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvVisits.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVisits.ThemeStyle.RowsStyle.Height = 24;
            // 
            // tbVisitSearchBar
            // 
            this.tbVisitSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVisitSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbVisitSearchBar.DefaultText = "اختار تاريخ من التقويم";
            this.tbVisitSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbVisitSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbVisitSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbVisitSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbVisitSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbVisitSearchBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVisitSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbVisitSearchBar.Location = new System.Drawing.Point(206, 29);
            this.tbVisitSearchBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbVisitSearchBar.Name = "tbVisitSearchBar";
            this.tbVisitSearchBar.PlaceholderText = "";
            this.tbVisitSearchBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbVisitSearchBar.SelectedText = "";
            this.tbVisitSearchBar.Size = new System.Drawing.Size(415, 24);
            this.tbVisitSearchBar.TabIndex = 43;
            // 
            // lblVisitSearch
            // 
            this.lblVisitSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVisitSearch.AutoSize = true;
            this.lblVisitSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitSearch.ForeColor = System.Drawing.Color.Black;
            this.lblVisitSearch.Location = new System.Drawing.Point(626, 29);
            this.lblVisitSearch.Name = "lblVisitSearch";
            this.lblVisitSearch.Size = new System.Drawing.Size(190, 32);
            this.lblVisitSearch.TabIndex = 42;
            this.lblVisitSearch.Text = " : البحث عن زيارة ";
            this.lblVisitSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ucVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpCalendar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddVisit);
            this.Controls.Add(this.btnEditVisit);
            this.Controls.Add(this.btnShowVisitDetails);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.dgvVisits);
            this.Controls.Add(this.tbVisitSearchBar);
            this.Controls.Add(this.lblVisitSearch);
            this.Name = "ucVisits";
            this.Size = new System.Drawing.Size(877, 566);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCalendar;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnAddVisit;
        private Guna.UI2.WinForms.Guna2Button btnEditVisit;
        private Guna.UI2.WinForms.Guna2Button btnShowVisitDetails;
        private System.Windows.Forms.Label lblNote;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVisits;
        private Guna.UI2.WinForms.Guna2TextBox tbVisitSearchBar;
        private System.Windows.Forms.Label lblVisitSearch;
    }
}
