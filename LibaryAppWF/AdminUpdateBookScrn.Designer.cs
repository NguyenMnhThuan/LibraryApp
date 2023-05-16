namespace LibaryAppWF
{
    partial class AdminUpdateBookScrn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBName = new System.Windows.Forms.TextBox();
            this.tbBAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPulisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericCategory = new System.Windows.Forms.NumericUpDown();
            this.numericIventory = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbPurchaser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dTPurchasedDay = new System.Windows.Forms.DateTimePicker();
            this.adminBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBookDetails = new System.Windows.Forms.DataGridView();
            this.tbPulishedYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "書籍名";
            // 
            // tbBName
            // 
            this.tbBName.Location = new System.Drawing.Point(136, 12);
            this.tbBName.Name = "tbBName";
            this.tbBName.Size = new System.Drawing.Size(200, 22);
            this.tbBName.TabIndex = 1;
            // 
            // tbBAuthor
            // 
            this.tbBAuthor.Location = new System.Drawing.Point(136, 48);
            this.tbBAuthor.Name = "tbBAuthor";
            this.tbBAuthor.Size = new System.Drawing.Size(200, 22);
            this.tbBAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "著者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "発行年";
            // 
            // tbPulisher
            // 
            this.tbPulisher.Location = new System.Drawing.Point(136, 87);
            this.tbPulisher.Name = "tbPulisher";
            this.tbPulisher.Size = new System.Drawing.Size(200, 22);
            this.tbPulisher.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "発行者";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "在庫";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "更新";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "書籍";
            // 
            // numericCategory
            // 
            this.numericCategory.Location = new System.Drawing.Point(136, 295);
            this.numericCategory.Name = "numericCategory";
            this.numericCategory.Size = new System.Drawing.Size(38, 22);
            this.numericCategory.TabIndex = 12;
            // 
            // numericIventory
            // 
            this.numericIventory.Location = new System.Drawing.Point(136, 256);
            this.numericIventory.Name = "numericIventory";
            this.numericIventory.Size = new System.Drawing.Size(119, 22);
            this.numericIventory.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "1. コンピュータ",
            "2. プログラミング",
            "3. データベース",
            "4. ネットワーク",
            "5. ビジネス",
            "6. コミュニケーション",
            "7. リーダー",
            "8. コーチング"});
            this.listBox1.Location = new System.Drawing.Point(136, 323);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 94);
            this.listBox1.TabIndex = 14;
            // 
            // tbPurchaser
            // 
            this.tbPurchaser.Location = new System.Drawing.Point(136, 171);
            this.tbPurchaser.Name = "tbPurchaser";
            this.tbPurchaser.Size = new System.Drawing.Size(200, 22);
            this.tbPurchaser.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "購入者";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "購入日";
            // 
            // dTPurchasedDay
            // 
            this.dTPurchasedDay.Location = new System.Drawing.Point(136, 215);
            this.dTPurchasedDay.Name = "dTPurchasedDay";
            this.dTPurchasedDay.Size = new System.Drawing.Size(200, 22);
            this.dTPurchasedDay.TabIndex = 18;
            // 
            // adminBLBindingSource
            // 
            this.adminBLBindingSource.DataSource = typeof(LibraryAppWF.BL.AdminBL);
            // 
            // dgvBookDetails
            // 
            this.dgvBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookDetails.Location = new System.Drawing.Point(359, 450);
            this.dgvBookDetails.Name = "dgvBookDetails";
            this.dgvBookDetails.RowHeadersWidth = 51;
            this.dgvBookDetails.RowTemplate.Height = 24;
            this.dgvBookDetails.Size = new System.Drawing.Size(10, 10);
            this.dgvBookDetails.TabIndex = 19;
            // 
            // tbPulishedYear
            // 
            this.tbPulishedYear.Location = new System.Drawing.Point(136, 127);
            this.tbPulishedYear.Name = "tbPulishedYear";
            this.tbPulishedYear.Size = new System.Drawing.Size(200, 22);
            this.tbPulishedYear.TabIndex = 7;
            // 
            // AdminUpdateBookScrn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(381, 468);
            this.Controls.Add(this.dgvBookDetails);
            this.Controls.Add(this.dTPurchasedDay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPurchaser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericIventory);
            this.Controls.Add(this.numericCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPulishedYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPulisher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AdminUpdateBookScrn";
            this.Text = "Update Book";
            ((System.ComponentModel.ISupportInitialize)(this.numericCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBName;
        private System.Windows.Forms.TextBox tbBAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPulisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericCategory;
        private System.Windows.Forms.NumericUpDown numericIventory;
        private System.Windows.Forms.BindingSource adminBLBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbPurchaser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dTPurchasedDay;
        private System.Windows.Forms.DataGridView dgvBookDetails;
        private System.Windows.Forms.TextBox tbPulishedYear;
    }
}