namespace ClinicSystem.UI.UserControls
{
    partial class ucAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddVisite = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.dgvAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbAppointmentSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAppointmentSearch = new System.Windows.Forms.Label();
            this.plNumbers = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCancelledCount = new System.Windows.Forms.Label();
            this.lblCompletedCount = new System.Windows.Forms.Label();
            this.lblScheduledCount = new System.Windows.Forms.Label();
            this.lblCancelled = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblScheduled = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.plNumbers.SuspendLayout();
            this.SuspendLayout();
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
            this.btnClear.Location = new System.Drawing.Point(162, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 30);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "تفريغ";
            // 
            // btnAddVisite
            // 
            this.btnAddVisite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnAddVisite.TabIndex = 34;
            this.btnAddVisite.Text = "انشاء زيارة";
            // 
            // btnEditAppointment
            // 
            this.btnEditAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditAppointment.FillColor = System.Drawing.Color.Silver;
            this.btnEditAppointment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditAppointment.ForeColor = System.Drawing.Color.Black;
            this.btnEditAppointment.Location = new System.Drawing.Point(849, 599);
            this.btnEditAppointment.Name = "btnEditAppointment";
            this.btnEditAppointment.Size = new System.Drawing.Size(158, 62);
            this.btnEditAppointment.TabIndex = 33;
            this.btnEditAppointment.Text = "تعديل موعد";
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelAppointment.FillColor = System.Drawing.Color.Silver;
            this.btnCancelAppointment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelAppointment.ForeColor = System.Drawing.Color.Black;
            this.btnCancelAppointment.Location = new System.Drawing.Point(620, 499);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(158, 62);
            this.btnCancelAppointment.TabIndex = 32;
            this.btnCancelAppointment.Text = "الغاء موعد";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAppointment.FillColor = System.Drawing.Color.Silver;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddAppointment.ForeColor = System.Drawing.Color.Black;
            this.btnAddAppointment.Location = new System.Drawing.Point(849, 499);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(158, 62);
            this.btnAddAppointment.TabIndex = 31;
            this.btnAddAppointment.Text = "اضافة موعد";
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(780, 446);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(218, 20);
            this.lblNote.TabIndex = 30;
            this.lblNote.Text = " حدد الموعد من الجدول قبل الاختيار *";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToOrderColumns = true;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvAppointments.ColumnHeadersHeight = 4;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.Location = new System.Drawing.Point(162, 107);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.Size = new System.Drawing.Size(845, 324);
            this.dgvAppointments.TabIndex = 29;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.ThemeStyle.RowsStyle.Height = 24;
            // 
            // tbAppointmentSearchBar
            // 
            this.tbAppointmentSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAppointmentSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAppointmentSearchBar.DefaultText = "اختار تاريخ من التقويم";
            this.tbAppointmentSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAppointmentSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAppointmentSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAppointmentSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAppointmentSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAppointmentSearchBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAppointmentSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAppointmentSearchBar.Location = new System.Drawing.Point(284, 36);
            this.tbAppointmentSearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAppointmentSearchBar.Name = "tbAppointmentSearchBar";
            this.tbAppointmentSearchBar.PlaceholderText = "";
            this.tbAppointmentSearchBar.SelectedText = "";
            this.tbAppointmentSearchBar.Size = new System.Drawing.Size(553, 30);
            this.tbAppointmentSearchBar.TabIndex = 28;
            this.tbAppointmentSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAppointmentSearch
            // 
            this.lblAppointmentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppointmentSearch.AutoSize = true;
            this.lblAppointmentSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentSearch.ForeColor = System.Drawing.Color.Black;
            this.lblAppointmentSearch.Location = new System.Drawing.Point(844, 36);
            this.lblAppointmentSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentSearch.Name = "lblAppointmentSearch";
            this.lblAppointmentSearch.Size = new System.Drawing.Size(153, 25);
            this.lblAppointmentSearch.TabIndex = 27;
            this.lblAppointmentSearch.Text = " : البحث عن موعد ";
            this.lblAppointmentSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // plNumbers
            // 
            this.plNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plNumbers.Controls.Add(this.lblCancelledCount);
            this.plNumbers.Controls.Add(this.lblCompletedCount);
            this.plNumbers.Controls.Add(this.lblScheduledCount);
            this.plNumbers.Controls.Add(this.lblCancelled);
            this.plNumbers.Controls.Add(this.lblCompleted);
            this.plNumbers.Controls.Add(this.lblScheduled);
            this.plNumbers.Location = new System.Drawing.Point(162, 499);
            this.plNumbers.Name = "plNumbers";
            this.plNumbers.Size = new System.Drawing.Size(377, 162);
            this.plNumbers.TabIndex = 40;
            // 
            // lblCancelledCount
            // 
            this.lblCancelledCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancelledCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelledCount.ForeColor = System.Drawing.Color.Black;
            this.lblCancelledCount.Location = new System.Drawing.Point(16, 93);
            this.lblCancelledCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelledCount.Name = "lblCancelledCount";
            this.lblCancelledCount.Size = new System.Drawing.Size(105, 38);
            this.lblCancelledCount.TabIndex = 33;
            this.lblCancelledCount.Text = "10";
            this.lblCancelledCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCompletedCount
            // 
            this.lblCompletedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompletedCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedCount.ForeColor = System.Drawing.Color.Black;
            this.lblCompletedCount.Location = new System.Drawing.Point(16, 51);
            this.lblCompletedCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompletedCount.Name = "lblCompletedCount";
            this.lblCompletedCount.Size = new System.Drawing.Size(105, 42);
            this.lblCompletedCount.TabIndex = 32;
            this.lblCompletedCount.Text = "10";
            this.lblCompletedCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScheduledCount
            // 
            this.lblScheduledCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScheduledCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledCount.ForeColor = System.Drawing.Color.Black;
            this.lblScheduledCount.Location = new System.Drawing.Point(12, 9);
            this.lblScheduledCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScheduledCount.Name = "lblScheduledCount";
            this.lblScheduledCount.Size = new System.Drawing.Size(109, 41);
            this.lblScheduledCount.TabIndex = 31;
            this.lblScheduledCount.Text = "10";
            this.lblScheduledCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCancelled
            // 
            this.lblCancelled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancelled.AutoSize = true;
            this.lblCancelled.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelled.ForeColor = System.Drawing.Color.Black;
            this.lblCancelled.Location = new System.Drawing.Point(128, 93);
            this.lblCancelled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelled.Name = "lblCancelled";
            this.lblCancelled.Size = new System.Drawing.Size(160, 25);
            this.lblCancelled.TabIndex = 30;
            this.lblCancelled.Text = ":    المواعيد الملغاه";
            this.lblCancelled.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCompleted
            // 
            this.lblCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.Black;
            this.lblCompleted.Location = new System.Drawing.Point(128, 51);
            this.lblCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(161, 25);
            this.lblCompleted.TabIndex = 29;
            this.lblCompleted.Text = ":  المواعيد المكتملة";
            this.lblCompleted.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScheduled
            // 
            this.lblScheduled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScheduled.AutoSize = true;
            this.lblScheduled.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduled.ForeColor = System.Drawing.Color.Black;
            this.lblScheduled.Location = new System.Drawing.Point(129, 9);
            this.lblScheduled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScheduled.Name = "lblScheduled";
            this.lblScheduled.Size = new System.Drawing.Size(160, 25);
            this.lblScheduled.TabIndex = 28;
            this.lblScheduled.Text = ": المواعيد المجدولة";
            this.lblScheduled.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.LightGray;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(284, 36);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(255, 30);
            this.guna2DateTimePicker1.TabIndex = 41;
            this.guna2DateTimePicker1.UseTransparentBackground = true;
            this.guna2DateTimePicker1.Value = new System.DateTime(2026, 11, 18, 15, 27, 27, 776);
            // 
            // ucAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.plNumbers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddVisite);
            this.Controls.Add(this.btnEditAppointment);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.tbAppointmentSearchBar);
            this.Controls.Add(this.lblAppointmentSearch);
            this.Name = "ucAppointments";
            this.Size = new System.Drawing.Size(1169, 697);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.plNumbers.ResumeLayout(false);
            this.plNumbers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnAddVisite;
        private Guna.UI2.WinForms.Guna2Button btnEditAppointment;
        private Guna.UI2.WinForms.Guna2Button btnCancelAppointment;
        private Guna.UI2.WinForms.Guna2Button btnAddAppointment;
        private System.Windows.Forms.Label lblNote;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppointments;
        private Guna.UI2.WinForms.Guna2TextBox tbAppointmentSearchBar;
        private System.Windows.Forms.Label lblAppointmentSearch;
        private Guna.UI2.WinForms.Guna2Panel plNumbers;
        private System.Windows.Forms.Label lblCancelled;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblScheduled;
        private System.Windows.Forms.Label lblCancelledCount;
        private System.Windows.Forms.Label lblCompletedCount;
        private System.Windows.Forms.Label lblScheduledCount;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}
