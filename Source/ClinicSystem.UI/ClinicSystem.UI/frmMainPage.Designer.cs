namespace ClinicSystem.UI
{
    partial class frmMainMenu
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
            this.PanelMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.PanelLogo = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTitleBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnVisits = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.PanelMenu.Controls.Add(this.btnLogout);
            this.PanelMenu.Controls.Add(this.btnSettings);
            this.PanelMenu.Controls.Add(this.btnUsers);
            this.PanelMenu.Controls.Add(this.btnPayments);
            this.PanelMenu.Controls.Add(this.btnVisits);
            this.PanelMenu.Controls.Add(this.btnAppointments);
            this.PanelMenu.Controls.Add(this.btnPatients);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelMenu.Location = new System.Drawing.Point(877, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(221, 646);
            this.PanelMenu.TabIndex = 0;
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PanelLogo.Controls.Add(this.label1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(221, 80);
            this.PanelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(75, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "عيادة عامة";
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.PanelTitleBar.Controls.Add(this.lblTitle);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(877, 80);
            this.PanelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(354, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "الصفحة الرئيسية";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(877, 566);
            this.panelDesktop.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = global::ClinicSystem.UI.Resources.log_out_outline_32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(0, 586);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnLogout.Size = new System.Drawing.Size(221, 60);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "تسجيل خروج";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Image = global::ClinicSystem.UI.Resources.settings_outline_32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(0, 380);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnSettings.Size = new System.Drawing.Size(221, 60);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "الاعدادات";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsers.Image = global::ClinicSystem.UI.Resources.person_circle_outline_32;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.Location = new System.Drawing.Point(0, 320);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnUsers.Size = new System.Drawing.Size(221, 60);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "المستخدمين";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPayments.Image = global::ClinicSystem.UI.Resources.cash_outline_32;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayments.Location = new System.Drawing.Point(0, 260);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnPayments.Size = new System.Drawing.Size(221, 60);
            this.btnPayments.TabIndex = 6;
            this.btnPayments.Text = "الدفعات";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnVisits
            // 
            this.btnVisits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisits.FlatAppearance.BorderSize = 0;
            this.btnVisits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisits.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisits.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVisits.Image = global::ClinicSystem.UI.Resources.bed_outline_32;
            this.btnVisits.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisits.Location = new System.Drawing.Point(0, 200);
            this.btnVisits.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisits.Name = "btnVisits";
            this.btnVisits.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnVisits.Size = new System.Drawing.Size(221, 60);
            this.btnVisits.TabIndex = 5;
            this.btnVisits.Text = "الزيارات";
            this.btnVisits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisits.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVisits.UseVisualStyleBackColor = true;
            this.btnVisits.Click += new System.EventHandler(this.btnVisits_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointments.FlatAppearance.BorderSize = 0;
            this.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointments.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAppointments.Image = global::ClinicSystem.UI.Resources.calendar_32;
            this.btnAppointments.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppointments.Location = new System.Drawing.Point(0, 140);
            this.btnAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnAppointments.Size = new System.Drawing.Size(221, 60);
            this.btnAppointments.TabIndex = 4;
            this.btnAppointments.Text = "المواعيد";
            this.btnAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppointments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatients.FlatAppearance.BorderSize = 0;
            this.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatients.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPatients.Image = global::ClinicSystem.UI.Resources.people_outline_32;
            this.btnPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatients.Location = new System.Drawing.Point(0, 80);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnPatients.Size = new System.Drawing.Size(221, 60);
            this.btnPatients.TabIndex = 3;
            this.btnPatients.Text = "المرضى";
            this.btnPatients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 646);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainMenu";
            this.Text = "frmMainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel PanelMenu;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelLogo;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnVisits;
        private System.Windows.Forms.Button btnAppointments;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
    }
}