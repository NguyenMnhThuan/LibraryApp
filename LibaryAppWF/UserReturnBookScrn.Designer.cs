namespace LibaryAppWF
{
    partial class UserReturnBookScrn
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.BookNamelb = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.adminBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adminBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "書籍名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "数量";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(144, 136);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "確定";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // BookNamelb
            // 
            this.BookNamelb.AutoSize = true;
            this.BookNamelb.BackColor = System.Drawing.Color.Transparent;
            this.BookNamelb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookNamelb.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BookNamelb.ForeColor = System.Drawing.Color.Black;
            this.BookNamelb.Location = new System.Drawing.Point(144, 24);
            this.BookNamelb.Name = "BookNamelb";
            this.BookNamelb.Size = new System.Drawing.Size(88, 17);
            this.BookNamelb.TabIndex = 15;
            this.BookNamelb.Text = "Harry Potter";
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.EmployeeID.ForeColor = System.Drawing.Color.Black;
            this.EmployeeID.Location = new System.Drawing.Point(144, 59);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(88, 17);
            this.EmployeeID.TabIndex = 16;
            this.EmployeeID.Text = "Harry Potter";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.BackColor = System.Drawing.Color.Transparent;
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Quantity.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.Quantity.ForeColor = System.Drawing.Color.Black;
            this.Quantity.Location = new System.Drawing.Point(144, 93);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(88, 17);
            this.Quantity.TabIndex = 17;
            this.Quantity.Text = "Harry Potter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "社員番号";
            // 
            // adminBLBindingSource
            // 
            this.adminBLBindingSource.DataSource = typeof(LibraryAppWF.BL.AdminBL);
            // 
            // UserReturnBookScrn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(381, 174);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.BookNamelb);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "UserReturnBookScrn";
            this.Text = "Return Book";
            ((System.ComponentModel.ISupportInitialize)(this.adminBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.BindingSource adminBLBindingSource;
        private System.Windows.Forms.Label BookNamelb;
        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label11;
    }
}