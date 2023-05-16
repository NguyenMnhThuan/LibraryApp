namespace LibaryAppWF
{
    partial class UserHomescreen
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBookDetails = new System.Windows.Forms.DataGridView();
            this.LendingBtn = new System.Windows.Forms.Button();
            this.BookSearchBtn = new System.Windows.Forms.Button();
            this.BookRefreshBtn = new System.Windows.Forms.Button();
            this.tBBookSearch = new System.Windows.Forms.TextBox();
            this.Book_lb = new System.Windows.Forms.Label();
            this.UserPage = new System.Windows.Forms.TabPage();
            this.dgvLoanDetails = new System.Windows.Forms.DataGridView();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.LoanSearchBtn = new System.Windows.Forms.Button();
            this.LoanRefreshBtn = new System.Windows.Forms.Button();
            this.tBLoanSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            EmployeePage = new System.Windows.Forms.TabControl();
            EmployeePage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).BeginInit();
            this.UserPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeePage
            // 
            EmployeePage.Controls.Add(this.tabPage1);
            EmployeePage.Controls.Add(this.UserPage);
            EmployeePage.Location = new System.Drawing.Point(12, 14);
            EmployeePage.Name = "EmployeePage";
            EmployeePage.SelectedIndex = 0;
            EmployeePage.Size = new System.Drawing.Size(803, 500);
            EmployeePage.TabIndex = 5;
            EmployeePage.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Wheat;
            this.tabPage1.Controls.Add(this.dgvBookDetails);
            this.tabPage1.Controls.Add(this.LendingBtn);
            this.tabPage1.Controls.Add(this.BookSearchBtn);
            this.tabPage1.Controls.Add(this.BookRefreshBtn);
            this.tabPage1.Controls.Add(this.tBBookSearch);
            this.tabPage1.Controls.Add(this.Book_lb);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "貸出処理";
            // 
            // dgvBookDetails
            // 
            this.dgvBookDetails.AccessibleName = "BooksDetails";
            this.dgvBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookDetails.Location = new System.Drawing.Point(6, 90);
            this.dgvBookDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvBookDetails.Name = "dgvBookDetails";
            this.dgvBookDetails.RowHeadersWidth = 51;
            this.dgvBookDetails.Size = new System.Drawing.Size(700, 370);
            this.dgvBookDetails.TabIndex = 18;
            this.dgvBookDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBookDetails_RowHeaderMouseClick);
            // 
            // LendingBtn
            // 
            this.LendingBtn.Location = new System.Drawing.Point(713, 90);
            this.LendingBtn.Name = "LendingBtn";
            this.LendingBtn.Size = new System.Drawing.Size(75, 23);
            this.LendingBtn.TabIndex = 17;
            this.LendingBtn.Text = "貸出";
            this.LendingBtn.UseVisualStyleBackColor = true;
            this.LendingBtn.Click += new System.EventHandler(this.LendingBtn_Click);
            // 
            // BookSearchBtn
            // 
            this.BookSearchBtn.Location = new System.Drawing.Point(651, 58);
            this.BookSearchBtn.Name = "BookSearchBtn";
            this.BookSearchBtn.Size = new System.Drawing.Size(55, 23);
            this.BookSearchBtn.TabIndex = 16;
            this.BookSearchBtn.Text = "検索";
            this.BookSearchBtn.UseVisualStyleBackColor = true;
            this.BookSearchBtn.Click += new System.EventHandler(this.BookSearchBtn_Click);
            // 
            // BookRefreshBtn
            // 
            this.BookRefreshBtn.BackgroundImage = global::LibaryAppWF.Properties.Resources.reload;
            this.BookRefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookRefreshBtn.Location = new System.Drawing.Point(713, 437);
            this.BookRefreshBtn.Name = "BookRefreshBtn";
            this.BookRefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.BookRefreshBtn.TabIndex = 15;
            this.BookRefreshBtn.UseVisualStyleBackColor = true;
            this.BookRefreshBtn.Click += new System.EventHandler(this.BookRefreshBtn_Click);
            // 
            // tBBookSearch
            // 
            this.tBBookSearch.Location = new System.Drawing.Point(6, 58);
            this.tBBookSearch.Name = "tBBookSearch";
            this.tBBookSearch.Size = new System.Drawing.Size(639, 23);
            this.tBBookSearch.TabIndex = 14;
            // 
            // Book_lb
            // 
            this.Book_lb.AutoSize = true;
            this.Book_lb.Font = new System.Drawing.Font("Pristina", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_lb.ForeColor = System.Drawing.Color.DimGray;
            this.Book_lb.Location = new System.Drawing.Point(271, 11);
            this.Book_lb.Name = "Book_lb";
            this.Book_lb.Size = new System.Drawing.Size(197, 33);
            this.Book_lb.TabIndex = 13;
            this.Book_lb.Text = "「書籍」一覧表";
            // 
            // UserPage
            // 
            this.UserPage.BackColor = System.Drawing.Color.Wheat;
            this.UserPage.Controls.Add(this.dgvLoanDetails);
            this.UserPage.Controls.Add(this.ReturnBtn);
            this.UserPage.Controls.Add(this.LoanSearchBtn);
            this.UserPage.Controls.Add(this.LoanRefreshBtn);
            this.UserPage.Controls.Add(this.tBLoanSearch);
            this.UserPage.Controls.Add(this.label1);
            this.UserPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPage.Location = new System.Drawing.Point(4, 26);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserPage.Size = new System.Drawing.Size(795, 470);
            this.UserPage.TabIndex = 1;
            this.UserPage.Text = "貸出状況";
            // 
            // dgvLoanDetails
            // 
            this.dgvLoanDetails.AccessibleName = "BooksDetails";
            this.dgvLoanDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanDetails.Location = new System.Drawing.Point(6, 90);
            this.dgvLoanDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvLoanDetails.Name = "dgvLoanDetails";
            this.dgvLoanDetails.RowHeadersWidth = 51;
            this.dgvLoanDetails.Size = new System.Drawing.Size(700, 370);
            this.dgvLoanDetails.TabIndex = 24;
            this.dgvLoanDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLoanDetails_RowHeaderMouseClick);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(713, 90);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.ReturnBtn.TabIndex = 23;
            this.ReturnBtn.Text = "返却";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // LoanSearchBtn
            // 
            this.LoanSearchBtn.Location = new System.Drawing.Point(651, 58);
            this.LoanSearchBtn.Name = "LoanSearchBtn";
            this.LoanSearchBtn.Size = new System.Drawing.Size(55, 23);
            this.LoanSearchBtn.TabIndex = 22;
            this.LoanSearchBtn.Text = "検索";
            this.LoanSearchBtn.UseVisualStyleBackColor = true;
            this.LoanSearchBtn.Click += new System.EventHandler(this.LoanSearchBtn_Click);
            // 
            // LoanRefreshBtn
            // 
            this.LoanRefreshBtn.BackgroundImage = global::LibaryAppWF.Properties.Resources.reload;
            this.LoanRefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoanRefreshBtn.Location = new System.Drawing.Point(713, 437);
            this.LoanRefreshBtn.Name = "LoanRefreshBtn";
            this.LoanRefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.LoanRefreshBtn.TabIndex = 21;
            this.LoanRefreshBtn.UseVisualStyleBackColor = true;
            this.LoanRefreshBtn.Click += new System.EventHandler(this.LoanRefreshBtn_Click);
            // 
            // tBLoanSearch
            // 
            this.tBLoanSearch.Location = new System.Drawing.Point(6, 58);
            this.tBLoanSearch.Name = "tBLoanSearch";
            this.tBLoanSearch.Size = new System.Drawing.Size(639, 23);
            this.tBLoanSearch.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(271, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "「貸出」一覧表";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(730, 11);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "ログアウト";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // UserHomescreen
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
            this.Name = "UserHomescreen";
            this.Text = "UserHomescreen";
            EmployeePage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).EndInit();
            this.UserPage.ResumeLayout(false);
            this.UserPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvBookDetails;
        private System.Windows.Forms.Button LendingBtn;
        private System.Windows.Forms.Button BookSearchBtn;
        private System.Windows.Forms.Button BookRefreshBtn;
        private System.Windows.Forms.TextBox tBBookSearch;
        private System.Windows.Forms.Label Book_lb;
        private System.Windows.Forms.TabPage UserPage;
        private System.Windows.Forms.DataGridView dgvLoanDetails;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button LoanSearchBtn;
        private System.Windows.Forms.Button LoanRefreshBtn;
        private System.Windows.Forms.TextBox tBLoanSearch;
        private System.Windows.Forms.Label label1;
    }
}