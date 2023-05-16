using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LibaryAppWF
{
    public partial class UserReturnBookScrn : Form
    {
        public static SqlConnection conn = new SqlConnection("Server=1803-13-001\\SQLEXPRESSVER1; Database=CompanyLibrary_DB; Integrated Security=true");

        public UserReturnBookScrn()
        {
            InitializeComponent();
            this.FormClosing += UserReturnBookScrn_FormClosing;
            BookNamelb.Text = UserHomescreen.RequestedBookName;
            EmployeeID.Text = UserHomescreen.RequestedEmployeeID;
            Quantity.Text = UserHomescreen.RequestedQuantity.ToString();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            string sql = @"DELETE FROM LOAN WHERE LOAN_ID = " + UserHomescreen.LoanId + ";";
            string returnBook = @"UPDATE BOOK SET IVENTORY = IVENTORY + "+ UserHomescreen.RequestedQuantity + " WHERE BOOK_NAME LIKE '" + UserHomescreen.RequestedBookName + "';";

            using (SqlCommand cmd = conn.CreateCommand())
            {
                DialogResult dialogResult = MessageBox.Show("この書籍を貸出しますか？", "確認メッセージ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.CommandText = sql;
                    // パラメータをセットする
                    conn.Open();
                    // INSERTを実行する
                    int cnt1 = cmd.ExecuteNonQuery();
                    conn.Close();
                    // 処理件数を表示する（※基本的に1）
                    Console.WriteLine(cnt1);

                    cmd.CommandText = returnBook;

                    conn.Open();
                    // INSERTを実行する
                    int cnt2 = cmd.ExecuteNonQuery();
                    conn.Close();
                    // 処理件数を表示する（※基本的に1）
                    Console.WriteLine(cnt2);
                    if (cnt1 + cnt2 > 0)
                    {
                        MessageBox.Show("Book returned successfuly..");
                    }
                    else
                    {
                        MessageBox.Show("Try again..");
                    }
                    UserHomescreen userHomescreen = new UserHomescreen();
                    userHomescreen.Show();
                    this.Hide();
                }
            }
        }
        private void UserReturnBookScrn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("画面を閉じてもよろしいですか？", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            UserHomescreen userHomescreen = new UserHomescreen();
            userHomescreen.Show();
        }
    }
}
