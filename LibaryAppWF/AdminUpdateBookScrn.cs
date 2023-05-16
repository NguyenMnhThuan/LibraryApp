using LibraryAppWF.BL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryAppWF
{
    public partial class AdminUpdateBookScrn : Form
    {
        public int Id = AdminHomescreen.BookId;
        public static SqlConnection conn = new SqlConnection("Server=1803-13-001\\SQLEXPRESSVER1; Database=CompanyLibrary_DB; Integrated Security=true");
        public AdminUpdateBookScrn()
        {
            InitializeComponent();
            this.FormClosing += AdminUpdateBookScrn_FormClosing;
            string query = @"SELECT BOOK_ID, BOOK_NAME,AUTHOR,PUBLISHER,PUBLISH_YEAR,PURCHASE_DATE,PURCHASER,IVENTORY, CATEGORY_ID FROM BOOK B WHERE BOOK_ID = " + Id + ";";
            
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommand cmd = new SqlCommand(query, conn);
            DataSet ds = new DataSet("Books");
            da.Fill(ds);
            dgvBookDetails.Hide();
            dgvBookDetails.DataSource = ds.Tables[0];

            tbBName.Text = dgvBookDetails.Rows[0].Cells[1].Value.ToString();
            tbBAuthor.Text = dgvBookDetails.Rows[0].Cells[2].Value.ToString();
            tbPulisher.Text = dgvBookDetails.Rows[0].Cells[3].Value.ToString();
            tbPulishedYear.Text = dgvBookDetails.Rows[0].Cells[4].Value.ToString();
            dTPurchasedDay.Value = DateTime.Parse(dgvBookDetails.Rows[0].Cells[5].Value.ToString());
            tbPurchaser.Text = dgvBookDetails.Rows[0].Cells[6].Value.ToString();
            numericIventory.Value = int.Parse(dgvBookDetails.Rows[0].Cells[7].Value.ToString());
            numericCategory.Value = int.Parse(dgvBookDetails.Rows[0].Cells[8].Value.ToString());

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string bookName = tbBName.Text;
            string Author = tbBAuthor.Text;
            string Publisher = tbPulisher.Text;
            decimal publishYear = decimal.Parse(tbPulishedYear.Text);
            DateTime purchaseDate = dTPurchasedDay.Value;
            string Purchaser = tbPurchaser.Text;
            int Iventory = (int)numericIventory.Value;
            int cateroryID = (int)numericCategory.Value;

            BookBL bookBL = new BookBL();
            bool isDone = bookBL.UpdateBookBL(Id, bookName, Author, Publisher, publishYear, purchaseDate, Purchaser, Iventory, cateroryID);
            if (isDone == true)
            {
                MessageBox.Show("Book updated successfuly..");
                AdminHomescreen adminHomescreen = new AdminHomescreen();
                adminHomescreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Try again..");
            }

        }
        private void AdminUpdateBookScrn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("画面を閉じてもよろしいですか？", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            AdminHomescreen adminHomescreen = new AdminHomescreen();
            adminHomescreen.Show();

        }
    }
}
