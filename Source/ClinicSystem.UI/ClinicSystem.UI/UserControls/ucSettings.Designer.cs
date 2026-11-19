namespace ClinicSystem.UI.UserControls
{
    partial class ucSettings
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPatient = new Guna.UI2.WinForms.Guna2Button();
            this.tbPatientSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(653, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(129, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "اسم العيادة :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(617, 146);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "الصورة الرئيسية :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(617, 348);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(174, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "الصورة المصغرة :";
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditPatient.FillColor = System.Drawing.Color.Silver;
            this.btnEditPatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditPatient.ForeColor = System.Drawing.Color.Black;
            this.btnEditPatient.Location = new System.Drawing.Point(37, 471);
            this.btnEditPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(118, 50);
            this.btnEditPatient.TabIndex = 21;
            this.btnEditPatient.Text = "حفظ";
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
            this.btnAddPatient.Location = new System.Drawing.Point(222, 471);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(118, 50);
            this.btnAddPatient.TabIndex = 20;
            this.btnAddPatient.Text = "تعديل";
            // 
            // tbPatientSearchBar
            // 
            this.tbPatientSearchBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbPatientSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPatientSearchBar.DefaultText = "";
            this.tbPatientSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPatientSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPatientSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPatientSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPatientSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPatientSearchBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPatientSearchBar.Location = new System.Drawing.Point(346, 68);
            this.tbPatientSearchBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPatientSearchBar.Name = "tbPatientSearchBar";
            this.tbPatientSearchBar.PlaceholderText = "";
            this.tbPatientSearchBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPatientSearchBar.SelectedText = "";
            this.tbPatientSearchBar.Size = new System.Drawing.Size(258, 36);
            this.tbPatientSearchBar.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Location = new System.Drawing.Point(515, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 82);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(424, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 146);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPatientSearchBar);
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(877, 566);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnEditPatient;
        private Guna.UI2.WinForms.Guna2Button btnAddPatient;
        private Guna.UI2.WinForms.Guna2TextBox tbPatientSearchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
