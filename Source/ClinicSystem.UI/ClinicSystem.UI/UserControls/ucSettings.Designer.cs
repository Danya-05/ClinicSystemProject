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
            this.lblClinicName = new System.Windows.Forms.Label();
            this.lblMainImage = new System.Windows.Forms.Label();
            this.lblSmallImage = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveChanges = new Guna.UI2.WinForms.Guna2Button();
            this.tbClinicName = new Guna.UI2.WinForms.Guna2TextBox();
            this.picbSmallImage = new System.Windows.Forms.PictureBox();
            this.picbMainImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbSmallImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClinicName
            // 
            this.lblClinicName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClinicName.AutoSize = true;
            this.lblClinicName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinicName.ForeColor = System.Drawing.Color.Black;
            this.lblClinicName.Location = new System.Drawing.Point(653, 68);
            this.lblClinicName.Name = "lblClinicName";
            this.lblClinicName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClinicName.Size = new System.Drawing.Size(160, 37);
            this.lblClinicName.TabIndex = 1;
            this.lblClinicName.Text = "اسم العيادة :";
            // 
            // lblMainImage
            // 
            this.lblMainImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMainImage.AutoSize = true;
            this.lblMainImage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainImage.ForeColor = System.Drawing.Color.Black;
            this.lblMainImage.Location = new System.Drawing.Point(617, 146);
            this.lblMainImage.Name = "lblMainImage";
            this.lblMainImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMainImage.Size = new System.Drawing.Size(207, 37);
            this.lblMainImage.TabIndex = 2;
            this.lblMainImage.Text = "الصورة الرئيسية :";
            // 
            // lblSmallImage
            // 
            this.lblSmallImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSmallImage.AutoSize = true;
            this.lblSmallImage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallImage.ForeColor = System.Drawing.Color.Black;
            this.lblSmallImage.Location = new System.Drawing.Point(617, 348);
            this.lblSmallImage.Name = "lblSmallImage";
            this.lblSmallImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSmallImage.Size = new System.Drawing.Size(216, 37);
            this.lblSmallImage.TabIndex = 3;
            this.lblSmallImage.Text = "الصورة المصغرة :";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Silver;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(37, 471);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 50);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "تعديل";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChanges.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveChanges.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveChanges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveChanges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveChanges.FillColor = System.Drawing.Color.Silver;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(222, 471);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(118, 50);
            this.btnSaveChanges.TabIndex = 20;
            this.btnSaveChanges.Text = "حفظ";
            // 
            // tbClinicName
            // 
            this.tbClinicName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbClinicName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbClinicName.DefaultText = "";
            this.tbClinicName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbClinicName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbClinicName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbClinicName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbClinicName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbClinicName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClinicName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbClinicName.Location = new System.Drawing.Point(346, 68);
            this.tbClinicName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbClinicName.Name = "tbClinicName";
            this.tbClinicName.PlaceholderText = "";
            this.tbClinicName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbClinicName.SelectedText = "";
            this.tbClinicName.Size = new System.Drawing.Size(258, 36);
            this.tbClinicName.TabIndex = 22;
            // 
            // picbSmallImage
            // 
            this.picbSmallImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picbSmallImage.Location = new System.Drawing.Point(515, 348);
            this.picbSmallImage.Name = "picbSmallImage";
            this.picbSmallImage.Size = new System.Drawing.Size(89, 82);
            this.picbSmallImage.TabIndex = 24;
            this.picbSmallImage.TabStop = false;
            // 
            // picbMainImage
            // 
            this.picbMainImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picbMainImage.Location = new System.Drawing.Point(424, 157);
            this.picbMainImage.Name = "picbMainImage";
            this.picbMainImage.Size = new System.Drawing.Size(180, 146);
            this.picbMainImage.TabIndex = 23;
            this.picbMainImage.TabStop = false;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picbSmallImage);
            this.Controls.Add(this.picbMainImage);
            this.Controls.Add(this.tbClinicName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblSmallImage);
            this.Controls.Add(this.lblMainImage);
            this.Controls.Add(this.lblClinicName);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(877, 566);
            ((System.ComponentModel.ISupportInitialize)(this.picbSmallImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClinicName;
        private System.Windows.Forms.Label lblMainImage;
        private System.Windows.Forms.Label lblSmallImage;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnSaveChanges;
        private Guna.UI2.WinForms.Guna2TextBox tbClinicName;
        private System.Windows.Forms.PictureBox picbMainImage;
        private System.Windows.Forms.PictureBox picbSmallImage;
    }
}
