namespace LibaryAppWF
{
    partial class Home
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcmLb = new System.Windows.Forms.Label();
            this.LoginLb = new System.Windows.Forms.Label();
            this.UserLb = new System.Windows.Forms.Label();
            this.AdminLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminPic = new System.Windows.Forms.PictureBox();
            this.UserPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcmLb
            // 
            this.WelcmLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WelcmLb.AutoSize = true;
            this.WelcmLb.BackColor = System.Drawing.Color.Transparent;
            this.WelcmLb.Font = new System.Drawing.Font("Mistral", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcmLb.ForeColor = System.Drawing.Color.Gold;
            this.WelcmLb.Location = new System.Drawing.Point(103, 61);
            this.WelcmLb.Name = "WelcmLb";
            this.WelcmLb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WelcmLb.Size = new System.Drawing.Size(600, 71);
            this.WelcmLb.TabIndex = 0;
            this.WelcmLb.Text = "Welcome to Hogwarts Library";
            this.WelcmLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginLb
            // 
            this.LoginLb.AutoSize = true;
            this.LoginLb.BackColor = System.Drawing.Color.Transparent;
            this.LoginLb.Font = new System.Drawing.Font("Pristina", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLb.ForeColor = System.Drawing.Color.Wheat;
            this.LoginLb.Location = new System.Drawing.Point(353, 132);
            this.LoginLb.Name = "LoginLb";
            this.LoginLb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginLb.Size = new System.Drawing.Size(93, 29);
            this.LoginLb.TabIndex = 1;
            this.LoginLb.Text = "Login as...";
            this.LoginLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserLb
            // 
            this.UserLb.AutoSize = true;
            this.UserLb.BackColor = System.Drawing.Color.Transparent;
            this.UserLb.Font = new System.Drawing.Font("Pristina", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLb.ForeColor = System.Drawing.Color.Wheat;
            this.UserLb.Location = new System.Drawing.Point(268, 295);
            this.UserLb.Name = "UserLb";
            this.UserLb.Size = new System.Drawing.Size(51, 29);
            this.UserLb.TabIndex = 4;
            this.UserLb.Text = "User";
            // 
            // AdminLb
            // 
            this.AdminLb.AutoSize = true;
            this.AdminLb.BackColor = System.Drawing.Color.Transparent;
            this.AdminLb.Font = new System.Drawing.Font("Pristina", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLb.ForeColor = System.Drawing.Color.Wheat;
            this.AdminLb.Location = new System.Drawing.Point(452, 295);
            this.AdminLb.Name = "AdminLb";
            this.AdminLb.Size = new System.Drawing.Size(68, 29);
            this.AdminLb.TabIndex = 5;
            this.AdminLb.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(325, 332);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "abcinfo@abc.com";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminPic
            // 
            this.AdminPic.BackColor = System.Drawing.Color.Transparent;
            this.AdminPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminPic.Image = global::LibaryAppWF.Properties.Resources.albus_dumbledore_lord_voldemort_drawing_chibi_freckles_png_1495e3e77d7279ed804bb36f609c0f38;
            this.AdminPic.Location = new System.Drawing.Point(400, 163);
            this.AdminPic.Name = "AdminPic";
            this.AdminPic.Size = new System.Drawing.Size(156, 129);
            this.AdminPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminPic.TabIndex = 3;
            this.AdminPic.TabStop = false;
            this.AdminPic.Click += new System.EventHandler(this.AdminPic_Click);
            // 
            // UserPic
            // 
            this.UserPic.BackColor = System.Drawing.Color.Transparent;
            this.UserPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserPic.Image = global::LibaryAppWF.Properties.Resources.remus_lupin_harry_potter_lord_voldemort_albus_dumbledore_chibi_harry_potter_82687862757315c1f0ca67eef48c3db9;
            this.UserPic.Location = new System.Drawing.Point(214, 163);
            this.UserPic.Name = "UserPic";
            this.UserPic.Size = new System.Drawing.Size(156, 129);
            this.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPic.TabIndex = 2;
            this.UserPic.TabStop = false;
            this.UserPic.Click += new System.EventHandler(this.UserPic_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LibaryAppWF.Properties.Resources.jefferson_bacquey_habrylo_jefferson_bacquey_hogwarts_library_005;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcmLb);
            this.Controls.Add(this.AdminLb);
            this.Controls.Add(this.UserLb);
            this.Controls.Add(this.AdminPic);
            this.Controls.Add(this.UserPic);
            this.Controls.Add(this.LoginLb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Library HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.AdminPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcmLb;
        private System.Windows.Forms.Label LoginLb;
        private System.Windows.Forms.PictureBox UserPic;
        private System.Windows.Forms.PictureBox AdminPic;
        private System.Windows.Forms.Label UserLb;
        private System.Windows.Forms.Label AdminLb;
        private System.Windows.Forms.Label label1;
    }
}

