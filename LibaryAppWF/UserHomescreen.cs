using LibraryAppWF.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryAppWF
{
    public partial class UserHomescreen : Form
    {
        //DBの接続文字列
        public static string connectionString = @"Data Source=1803-13-001\SQLEXPRESSVER1;"    //SQLServerインスタンス
                                        + @"Initial Catalog=CompanyLibrary_DB;"               //使用するデータベース
                                        + @"User ID=sa;"                                      //ユーザー
                                        + @"Password=furutani-01";                            //パスワード
        public static int BookId;
        public static string bookName;
        public static string Author;
        public static string Publisher;
        public static decimal publishYear;
        public static DateTime purchaseDate;
        public static string Purchaser;
        public static int Iventory;
        public static int cateroryID;
        public static string cateroryName;

        public static int LoanId;
        public static string RequestedEmployeeID;
        public static string RequestedBookName;
        public static int RequestedQuantity;
        public UserHomescreen()
        {
            BookId = 0;
            LoanId = 0;

            InitializeComponent();
            this.FormClosing += UserHomescreen_FormClosing;
            BookBL bookBl = new BookBL();
            DataSet dsBook = bookBl.GetAllBooksBL();
            dgvBookDetails.DataSource = dsBook.Tables[0];

            LoanBL loanBl = new LoanBL();
            DataSet dsLoan = loanBl.GetAllLoansBL();
            dgvLoanDetails.DataSource = dsLoan.Tables[0];
        }

        private void UserHomescreen_Load(object sender, EventArgs e)
        {

        }

        //<< BOOK >>
        private void BookSearchBtn_Click(object sender, EventArgs e)
        {
            string searchValues = tBBookSearch.Text;
            BookBL bookBl = new BookBL();
            DataSet ds = bookBl.SearchBooksBL(searchValues);
            dgvBookDetails.DataSource = ds.Tables[0];

            tBBookSearch.Clear();
        }

        private void BookRefreshBtn_Click(object sender, EventArgs e)
        {
            BookBL bookBl = new BookBL();
            DataSet ds = bookBl.GetAllBooksBL();
            dgvBookDetails.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBookDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BookId = int.Parse(dgvBookDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                bookName = dgvBookDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                Author = dgvBookDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                Publisher = dgvBookDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
                publishYear = decimal.Parse(dgvBookDetails.Rows[e.RowIndex].Cells[4].Value.ToString());
                cateroryName = dgvBookDetails.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a book properly...");
            }

        }
        private void LendingBtn_Click(object sender, EventArgs e)
        {

            if (BookId > 0)
            {
                UserRequestBookScrn userRequestBook = new UserRequestBookScrn();
                userRequestBook.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a book to request...");
            }
        }


        //<< LOAN >>
        private void LoanSearchBtn_Click(object sender, EventArgs e)
        {
            string searchValues = tBLoanSearch.Text;
            LoanBL loanBl = new LoanBL();
            DataSet ds = loanBl.SearchLoansBL(searchValues);
            dgvLoanDetails.DataSource = ds.Tables[0];

            tBLoanSearch.Clear();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            if (LoanId > 0)
            {
                UserReturnBookScrn userReturnBook = new UserReturnBookScrn();
                userReturnBook.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a book to return...");
            }
        }

        private void LoanRefreshBtn_Click(object sender, EventArgs e)
        {
            LoanBL loanBl = new LoanBL();
            DataSet ds = loanBl.GetAllLoansBL();
            dgvLoanDetails.DataSource = ds.Tables[0];
        }
        private void dgvLoanDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                LoanId = int.Parse(dgvLoanDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                RequestedEmployeeID = dgvLoanDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                RequestedBookName = dgvLoanDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                RequestedQuantity = int.Parse(dgvLoanDetails.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Select a loan properly...");
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            home.Show();
            this.Hide();
        }
        
        private void UserHomescreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("画面を閉じてもよろしいですか？", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            Home home = new Home();
            home.Show();

        }
    }
}
