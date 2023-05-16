namespace LibaryAppWF
{
    partial class UserRequestBookScrn
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericIventory = new System.Windows.Forms.NumericUpDown();
            this.BookNamelb = new System.Windows.Forms.Label();
            this.Authorlb = new System.Windows.Forms.Label();
            this.Publisherlb = new System.Windows.Forms.Label();
            this.PublishYearlb = new System.Windows.Forms.Label();
            this.Categorylb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.dgvEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.AcceptEmployeeID = new System.Windows.Forms.Button();
            this.EmployeeSearchBtn = new System.Windows.Forms.Button();
            this.adminBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericIventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "著者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "発行年";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "発行者";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "数量";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(148, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "確定";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "書籍";
            // 
            // numericIventory
            // 
            this.numericIventory.Location = new System.Drawing.Point(148, 209);
            this.numericIventory.Name = "numericIventory";
            this.numericIventory.Size = new System.Drawing.Size(141, 22);
            this.numericIventory.TabIndex = 13;
            // 
            // BookNamelb
            // 
            this.BookNamelb.AutoSize = true;
            this.BookNamelb.BackColor = System.Drawing.Color.Transparent;
            this.BookNamelb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookNamelb.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BookNamelb.ForeColor = System.Drawing.Color.Black;
            this.BookNamelb.Location = new System.Drawing.Point(148, 24);
            this.BookNamelb.Name = "BookNamelb";
            this.BookNamelb.Size = new System.Drawing.Size(84, 17);
            this.BookNamelb.TabIndex = 15;
            this.BookNamelb.Text = "Harry おはよ";
            // 
            // Authorlb
            // 
            this.Authorlb.AutoSize = true;
            this.Authorlb.BackColor = System.Drawing.Color.Transparent;
            this.Authorlb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Authorlb.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.Authorlb.ForeColor = System.Drawing.Color.Black;
            this.Authorlb.Location = new System.Drawing.Point(148, 62);
            this.Authorlb.Name = "Authorlb";
            this.Authorlb.Size = new System.Drawing.Size(88, 17);
            this.Authorlb.TabIndex = 16;
            this.Authorlb.Text = "Harry Potter";
            // 
            // Publisherlb
            // 
            this.Publisherlb.AutoSize = true;
            this.Publisherlb.BackColor = System.Drawing.Color.Transparent;
            this.Publisherlb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Publisherlb.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.Publisherlb.ForeColor = System.Drawing.Color.Black;
            this.Publisherlb.Location = new System.Drawing.Point(148, 102);
            this.Publisherlb.Name = "Publisherlb";
            this.Publisherlb.Size = new System.Drawing.Size(88, 17);
            this.Publisherlb.TabIndex = 17;
            this.Publisherlb.Text = "Harry Potter";
            // 
            // PublishYearlb
            // 
            this.PublishYearlb.AutoSize = true;
            this.PublishYearlb.BackColor = System.Drawing.Color.Transparent;
            this.PublishYearlb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PublishYearlb.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.PublishYearlb.ForeColor = System.Drawing.Color.Black;
            this.PublishYearlb.Location = new System.Drawing.Point(148, 141);
            this.PublishYearlb.Name = "PublishYearlb";
            this.PublishYearlb.Size = new System.Drawing.Size(88, 17);
            this.PublishYearlb.TabIndex = 18;
            this.PublishYearlb.Text = "Harry Potter";
            // 
            // Categorylb
            // 
            this.Categorylb.AutoSize = true;
            this.Categorylb.BackColor = System.Drawing.Color.Transparent;
            this.Categorylb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Categorylb.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.Categorylb.ForeColor = System.Drawing.Color.Black;
            this.Categorylb.Location = new System.Drawing.Point(148, 179);
            this.Categorylb.Name = "Categorylb";
            this.Categorylb.Size = new System.Drawing.Size(88, 17);
            this.Categorylb.TabIndex = 19;
            this.Categorylb.Text = "Harry Potter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "社員番号";
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(148, 249);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(119, 22);
            this.EmployeeID.TabIndex = 21;
            // 
            // dgvEmployeeDetails
            // 
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(51, 276);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            this.dgvEmployeeDetails.RowHeadersWidth = 51;
            this.dgvEmployeeDetails.RowTemplate.Height = 24;
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(216, 64);
            this.dgvEmployeeDetails.TabIndex = 22;
            this.dgvEmployeeDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployeeDetails_RowHeaderMouseClick);
            // 
            // AcceptEmployeeID
            // 
            this.AcceptEmployeeID.Location = new System.Drawing.Point(267, 277);
            this.AcceptEmployeeID.Name = "AcceptEmployeeID";
            this.AcceptEmployeeID.Size = new System.Drawing.Size(22, 63);
            this.AcceptEmployeeID.TabIndex = 23;
            this.AcceptEmployeeID.Text = "↑";
            this.AcceptEmployeeID.UseVisualStyleBackColor = true;
            this.AcceptEmployeeID.Click += new System.EventHandler(this.AcceptEmployeeID_Click);
            // 
            // EmployeeSearchBtn
            // 
            this.EmployeeSearchBtn.BackgroundImage = global::LibaryAppWF.Properties.Resources.search;
            this.EmployeeSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EmployeeSearchBtn.Location = new System.Drawing.Point(267, 248);
            this.EmployeeSearchBtn.Name = "EmployeeSearchBtn";
            this.EmployeeSearchBtn.Size = new System.Drawing.Size(22, 23);
            this.EmployeeSearchBtn.TabIndex = 24;
            this.EmployeeSearchBtn.UseVisualStyleBackColor = true;
            this.EmployeeSearchBtn.Click += new System.EventHandler(this.EmployeeSearchBtn_Click);
            // 
            // adminBLBindingSource
            // 
            this.adminBLBindingSource.DataSource = typeof(LibraryAppWF.BL.AdminBL);
            // 
            // UserRequestBookScrn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(381, 380);
            this.Controls.Add(this.EmployeeSearchBtn);
            this.Controls.Add(this.AcceptEmployeeID);
            this.Controls.Add(this.dgvEmployeeDetails);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Categorylb);
            this.Controls.Add(this.PublishYearlb);
            this.Controls.Add(this.Publisherlb);
            this.Controls.Add(this.Authorlb);
            this.Controls.Add(this.BookNamelb);
            this.Controls.Add(this.numericIventory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "UserRequestBookScrn";
            this.Text = "Request Book";
            ((System.ComponentModel.ISupportInitialize)(this.numericIventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericIventory;
        private System.Windows.Forms.BindingSource adminBLBindingSource;
        private System.Windows.Forms.Label BookNamelb;
        private System.Windows.Forms.Label Authorlb;
        private System.Windows.Forms.Label Publisherlb;
        private System.Windows.Forms.Label PublishYearlb;
        private System.Windows.Forms.Label Categorylb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.DataGridView dgvEmployeeDetails;
        private System.Windows.Forms.Button AcceptEmployeeID;
        private System.Windows.Forms.Button EmployeeSearchBtn;
    }
}