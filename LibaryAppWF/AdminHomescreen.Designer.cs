namespace LibaryAppWF
{
    partial class AdminHomescreen
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
            System.Windows.Forms.TabControl EmployeePage;
            this.bookPage = new System.Windows.Forms.TabPage();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.dgvBookDetails = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserPage = new System.Windows.Forms.TabPage();
            this.UserCreatBtn = new System.Windows.Forms.Button();
            this.dateTPbirthday = new System.Windows.Forms.DateTimePicker();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbKanaName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.phoneLB = new System.Windows.Forms.Label();
            this.birthdayLB = new System.Windows.Forms.Label();
            this.namaeLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameLB = new System.Windows.Forms.Label();
            this.passwordLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.UserLoginPic = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.EmployeeSearchBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tBEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            EmployeePage = new System.Windows.Forms.TabControl();
            EmployeePage.SuspendLayout();
            this.bookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).BeginInit();
            this.UserPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserLoginPic)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeePage
            // 
            EmployeePage.Controls.Add(this.bookPage);
            EmployeePage.Controls.Add(this.UserPage);
            EmployeePage.Controls.Add(this.tabPage1);
            EmployeePage.Location = new System.Drawing.Point(12, 12);
            EmployeePage.Name = "EmployeePage";
            EmployeePage.SelectedIndex = 0;
            EmployeePage.Size = new System.Drawing.Size(803, 500);
            EmployeePage.TabIndex = 3;
            EmployeePage.Tag = "";
            // 
            // bookPage
            // 
            this.bookPage.BackColor = System.Drawing.Color.Wheat;
            this.bookPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookPage.Controls.Add(this.DeleteBtn);
            this.bookPage.Controls.Add(this.UpdateBtn);
            this.bookPage.Controls.Add(this.dgvBookDetails);
            this.bookPage.Controls.Add(this.AddBtn);
            this.bookPage.Controls.Add(this.SearchBtn);
            this.bookPage.Controls.Add(this.RefreshBtn);
            this.bookPage.Controls.Add(this.tBSearch);
            this.bookPage.Controls.Add(this.label3);
            this.bookPage.Location = new System.Drawing.Point(4, 26);
            this.bookPage.Name = "bookPage";
            this.bookPage.Padding = new System.Windows.Forms.Padding(3);
            this.bookPage.Size = new System.Drawing.Size(795, 470);
            this.bookPage.TabIndex = 2;
            this.bookPage.Text = "書籍処理";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(714, 182);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "削除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(714, 137);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.Text = "更新";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // dgvBookDetails
            // 
            this.dgvBookDetails.AccessibleName = "BooksDetails";
            this.dgvBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookDetails.Location = new System.Drawing.Point(7, 94);
            this.dgvBookDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvBookDetails.Name = "dgvBookDetails";
            this.dgvBookDetails.RowHeadersWidth = 51;
            this.dgvBookDetails.Size = new System.Drawing.Size(700, 370);
            this.dgvBookDetails.TabIndex = 10;
            this.dgvBookDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBookDetails_RowHeaderMouseClick);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(714, 94);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "追加";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(652, 62);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(55, 23);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "検索";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackgroundImage = global::LibaryAppWF.Properties.Resources.reload;
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshBtn.Location = new System.Drawing.Point(714, 441);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 7;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(7, 62);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(639, 23);
            this.tBSearch.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pristina", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(272, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "「書籍」の在庫状況";
            // 
            // UserPage
            // 
            this.UserPage.BackColor = System.Drawing.Color.Wheat;
            this.UserPage.Controls.Add(this.UserCreatBtn);
            this.UserPage.Controls.Add(this.dateTPbirthday);
            this.UserPage.Controls.Add(this.tbPhone);
            this.UserPage.Controls.Add(this.tbKanaName);
            this.UserPage.Controls.Add(this.tbPassword);
            this.UserPage.Controls.Add(this.tbUserName);
            this.UserPage.Controls.Add(this.phoneLB);
            this.UserPage.Controls.Add(this.birthdayLB);
            this.UserPage.Controls.Add(this.namaeLB);
            this.UserPage.Controls.Add(this.label2);
            this.UserPage.Controls.Add(this.userNameLB);
            this.UserPage.Controls.Add(this.passwordLB);
            this.UserPage.Controls.Add(this.label1);
            this.UserPage.Controls.Add(this.labelTitle1);
            this.UserPage.Controls.Add(this.UserLoginPic);
            this.UserPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPage.Location = new System.Drawing.Point(4, 26);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserPage.Size = new System.Drawing.Size(795, 470);
            this.UserPage.TabIndex = 1;
            this.UserPage.Text = "ユーザー登録";
            // 
            // UserCreatBtn
            // 
            this.UserCreatBtn.Font = new System.Drawing.Font("Pristina", 13F, System.Drawing.FontStyle.Bold);
            this.UserCreatBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UserCreatBtn.Location = new System.Drawing.Point(329, 410);
            this.UserCreatBtn.Name = "UserCreatBtn";
            this.UserCreatBtn.Size = new System.Drawing.Size(165, 36);
            this.UserCreatBtn.TabIndex = 20;
            this.UserCreatBtn.Text = "<作成>";
            this.UserCreatBtn.UseVisualStyleBackColor = true;
            this.UserCreatBtn.Click += new System.EventHandler(this.UserCreatBtn_Click);
            // 
            // dateTPbirthday
            // 
            this.dateTPbirthday.Location = new System.Drawing.Point(28, 353);
            this.dateTPbirthday.Name = "dateTPbirthday";
            this.dateTPbirthday.Size = new System.Drawing.Size(200, 23);
            this.dateTPbirthday.TabIndex = 19;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(28, 295);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(149, 23);
            this.tbPhone.TabIndex = 18;
            // 
            // tbKanaName
            // 
            this.tbKanaName.Location = new System.Drawing.Point(28, 237);
            this.tbKanaName.Name = "tbKanaName";
            this.tbKanaName.Size = new System.Drawing.Size(149, 23);
            this.tbKanaName.TabIndex = 13;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(28, 133);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(149, 23);
            this.tbPassword.TabIndex = 9;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(28, 75);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(149, 23);
            this.tbUserName.TabIndex = 8;
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLB.Location = new System.Drawing.Point(23, 263);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(122, 29);
            this.phoneLB.TabIndex = 17;
            this.phoneLB.Text = "電話番号：";
            // 
            // birthdayLB
            // 
            this.birthdayLB.AutoSize = true;
            this.birthdayLB.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLB.Location = new System.Drawing.Point(23, 321);
            this.birthdayLB.Name = "birthdayLB";
            this.birthdayLB.Size = new System.Drawing.Size(122, 29);
            this.birthdayLB.TabIndex = 16;
            this.birthdayLB.Text = "生年月日：";
            // 
            // namaeLB
            // 
            this.namaeLB.AutoSize = true;
            this.namaeLB.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaeLB.Location = new System.Drawing.Point(23, 205);
            this.namaeLB.Name = "namaeLB";
            this.namaeLB.Size = new System.Drawing.Size(74, 29);
            this.namaeLB.TabIndex = 12;
            this.namaeLB.Text = "名前：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(23, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "個人情報(任意)";
            // 
            // userNameLB
            // 
            this.userNameLB.AutoSize = true;
            this.userNameLB.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLB.Location = new System.Drawing.Point(23, 43);
            this.userNameLB.Name = "userNameLB";
            this.userNameLB.Size = new System.Drawing.Size(105, 29);
            this.userNameLB.TabIndex = 6;
            this.userNameLB.Text = "User_name";
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLB.Location = new System.Drawing.Point(23, 101);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(86, 29);
            this.passwordLB.TabIndex = 5;
            this.passwordLB.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(23, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 4;
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.ForeColor = System.Drawing.Color.DimGray;
            this.labelTitle1.Location = new System.Drawing.Point(23, 14);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(266, 29);
            this.labelTitle1.TabIndex = 3;
            this.labelTitle1.Text = "ログイン用アカウント(必要)";
            // 
            // UserLoginPic
            // 
            this.UserLoginPic.BackColor = System.Drawing.Color.Transparent;
            this.UserLoginPic.Image = global::LibaryAppWF.Properties.Resources.remus_lupin_harry_potter_lord_voldemort_albus_dumbledore_chibi_harry_potter_82687862757315c1f0ca67eef48c3db9;
            this.UserLoginPic.Location = new System.Drawing.Point(377, 43);
            this.UserLoginPic.Name = "UserLoginPic";
            this.UserLoginPic.Size = new System.Drawing.Size(393, 321);
            this.UserLoginPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserLoginPic.TabIndex = 11;
            this.UserLoginPic.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Wheat;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dgvEmployeeDetails);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.EmployeeSearchBtn);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.tBEmployee);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "社員管理";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "削除";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "更新";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeeDetails
            // 
            this.dgvEmployeeDetails.AccessibleName = "BooksDetails";
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(6, 90);
            this.dgvEmployeeDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            this.dgvEmployeeDetails.RowHeadersWidth = 51;
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(700, 370);
            this.dgvEmployeeDetails.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "追加";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EmployeeSearchBtn
            // 
            this.EmployeeSearchBtn.Location = new System.Drawing.Point(651, 58);
            this.EmployeeSearchBtn.Name = "EmployeeSearchBtn";
            this.EmployeeSearchBtn.Size = new System.Drawing.Size(55, 23);
            this.EmployeeSearchBtn.TabIndex = 16;
            this.EmployeeSearchBtn.Text = "検索";
            this.EmployeeSearchBtn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::LibaryAppWF.Properties.Resources.reload;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(713, 437);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tBEmployee
            // 
            this.tBEmployee.Location = new System.Drawing.Point(6, 58);
            this.tBEmployee.Name = "tBEmployee";
            this.tBEmployee.Size = new System.Drawing.Size(639, 23);
            this.tBEmployee.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pristina", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(271, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "「社員」一覧表";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(730, 9);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "ログアウト";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AdminHomescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 524);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(EmployeePage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AdminHomescreen";
            this.Text = "AdminHomescreen";
            this.Load += new System.EventHandler(this.AdminHomescreen_Load);
            EmployeePage.ResumeLayout(false);
            this.bookPage.ResumeLayout(false);
            this.bookPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).EndInit();
            this.UserPage.ResumeLayout(false);
            this.UserPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserLoginPic)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TabPage bookPage;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridView dgvBookDetails;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage UserPage;
        private System.Windows.Forms.Button UserCreatBtn;
        private System.Windows.Forms.DateTimePicker dateTPbirthday;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbKanaName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label phoneLB;
        private System.Windows.Forms.Label birthdayLB;
        private System.Windows.Forms.Label namaeLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userNameLB;
        private System.Windows.Forms.Label passwordLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.PictureBox UserLoginPic;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvEmployeeDetails;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button EmployeeSearchBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tBEmployee;
        private System.Windows.Forms.Label label4;
    }
}