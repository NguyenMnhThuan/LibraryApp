﻿namespace LibaryAppWF
{
    partial class AdminForm
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
            this.AdminEmail = new System.Windows.Forms.Label();
            this.AdminPass = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.tbAdminEmail = new System.Windows.Forms.TextBox();
            this.alertAdmin = new System.Windows.Forms.Label();
            this.tbAdminPass = new System.Windows.Forms.TextBox();
            this.AdminLoginPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLoginPic)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminEmail
            // 
            this.AdminEmail.AutoSize = true;
            this.AdminEmail.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminEmail.Location = new System.Drawing.Point(211, 22);
            this.AdminEmail.Name = "AdminEmail";
            this.AdminEmail.Size = new System.Drawing.Size(94, 29);
            this.AdminEmail.TabIndex = 2;
            this.AdminEmail.Text = "Email ID";
            // 
            // AdminPass
            // 
            this.AdminPass.AutoSize = true;
            this.AdminPass.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPass.Location = new System.Drawing.Point(211, 97);
            this.AdminPass.Name = "AdminPass";
            this.AdminPass.Size = new System.Drawing.Size(86, 29);
            this.AdminPass.TabIndex = 4;
            this.AdminPass.Text = "Password";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(184, 201);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(68, 23);
            this.btnAdminLogin.TabIndex = 6;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // tbAdminEmail
            // 
            this.tbAdminEmail.Location = new System.Drawing.Point(215, 59);
            this.tbAdminEmail.Name = "tbAdminEmail";
            this.tbAdminEmail.Size = new System.Drawing.Size(149, 22);
            this.tbAdminEmail.TabIndex = 7;
            // 
            // alertAdmin
            // 
            this.alertAdmin.AutoSize = true;
            this.alertAdmin.Location = new System.Drawing.Point(217, 209);
            this.alertAdmin.Name = "alertAdmin";
            this.alertAdmin.Size = new System.Drawing.Size(0, 15);
            this.alertAdmin.TabIndex = 8;
            // 
            // tbAdminPass
            // 
            this.tbAdminPass.Location = new System.Drawing.Point(215, 141);
            this.tbAdminPass.Name = "tbAdminPass";
            this.tbAdminPass.PasswordChar = '*';
            this.tbAdminPass.Size = new System.Drawing.Size(149, 22);
            this.tbAdminPass.TabIndex = 5;
            // 
            // AdminLoginPic
            // 
            this.AdminLoginPic.BackgroundImage = global::LibaryAppWF.Properties.Resources.albus_dumbledore_lord_voldemort_drawing_chibi_freckles_png_1495e3e77d7279ed804bb36f609c0f38;
            this.AdminLoginPic.Image = global::LibaryAppWF.Properties.Resources.albus_dumbledore_lord_voldemort_drawing_chibi_freckles_png_1495e3e77d7279ed804bb36f609c0f38;
            this.AdminLoginPic.Location = new System.Drawing.Point(22, 24);
            this.AdminLoginPic.Name = "AdminLoginPic";
            this.AdminLoginPic.Size = new System.Drawing.Size(158, 166);
            this.AdminLoginPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminLoginPic.TabIndex = 1;
            this.AdminLoginPic.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(386, 242);
            this.Controls.Add(this.tbAdminEmail);
            this.Controls.Add(this.alertAdmin);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.tbAdminPass);
            this.Controls.Add(this.AdminPass);
            this.Controls.Add(this.AdminEmail);
            this.Controls.Add(this.AdminLoginPic);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Admin Login";
            ((System.ComponentModel.ISupportInitialize)(this.AdminLoginPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox AdminLoginPic;
        private System.Windows.Forms.Label AdminEmail;
        private System.Windows.Forms.Label AdminPass;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.TextBox tbAdminEmail;
        private System.Windows.Forms.Label alertAdmin;
        private System.Windows.Forms.TextBox tbAdminPass;
    }
}