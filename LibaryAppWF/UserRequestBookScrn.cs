using LibraryAppWF.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryAppWF
{
    public partial class UserRequestBookScrn : Form
    {
        public static SqlConnection conn = new SqlConnection("Server=1803-13-001\\SQLEXPRESSVER1; Database=CompanyLibrary_DB; Integrated Security=true");
        public int RequestBookId = UserHomescreen.BookId;
        public string EmpID = "";
        public string RequestEmployeeID;

        public UserRequestBookScrn()
        {
            InitializeComponent();
            this.FormClosing += UserRequestBookScrn_FormClosing;
            BookNamelb.Text = UserHomescreen.bookName;
            Authorlb.Text = UserHomescreen.Author;
            Publisherlb.Text = UserHomescreen.Publisher;
            PublishYearlb.Text = (UserHomescreen.publishYear).ToString();
            Categorylb.Text = UserHomescreen.cateroryName;
        }
        private void EmployeeSearchBtn_Click(object sender, EventArgs e)
        {
            string query = @"SELECT EMPLOYEE_ID, EMPLOYEE_KANA FROM EMPLOYEE WHERE EMPLOYEE_KANA LIKE '%" + EmployeeID.Text + "%';";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommand cmd = new SqlCommand(query, conn);
            DataSet ds = new DataSet("Employees");
            da.Fill(ds);
            dgvEmployeeDetails.DataSource = ds.Tables[0];

            EmployeeID.Clear();
        }
        private void dgvEmployeeDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                EmpID = dgvEmployeeDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a employee properly...");
            }

        }
        private void AcceptEmployeeID_Click(object sender, EventArgs e)
        {
            EmployeeID.Text = this.EmpID.ToString();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            //LoanBL loanBL = new LoanBL();
            //bool isDone = loanBL.LendingBookBL();
            //if (isDone == true)
            //{
            //    MessageBox.Show("Book requested successfuly..");
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Try again..");
            //}
            string checkQuery = @"SELECT (IVENTORY - "+ numericIventory.Value + ") AS 'result' FROM BOOK WHERE BOOK_ID = "+RequestBookId+ ";";
            string checkExist = "SELECT * FROM [EMPLOYEE] WHERE EMPLOYEE_ID LIKE '%"+EmployeeID.Text+"%';";
            string sql = @"INSERT INTO LOAN(EMPLOYEE_ID,BOOK_ID,LOANED_NUMS,CREATE_ID) " +
                           "VALUES ((SELECT EMPLOYEE_ID FROM EMPLOYEE E WHERE E.EMPLOYEE_ID = @employeeID ),(SELECT BOOK_ID FROM BOOK B WHERE B.BOOK_ID = @bookID ),@nums,@createID);";
            string query = @"UPDATE BOOK SET IVENTORY = @Iventory WHERE BOOK_ID = " + RequestBookId + ";";
            // コマンドを取得する
            using (SqlCommand cmd = conn.CreateCommand())
            {

                if (numericIventory.Value == 0)
                {
                    MessageBox.Show("Please select a quantity greater than 0..");
                }
                else if (EmployeeID.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Please Enter EmployeeID..");
                }
                else
                {
                    // SQL文をセットする
                    // check employeeID
                    cmd.CommandText = checkExist;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        RequestEmployeeID = EmployeeID.Text;
                    }
                    else
                    {
                        RequestEmployeeID = this.EmpID;
                    }
                    //check stock
                    cmd.CommandText = checkQuery;
                    conn.Open();
                    int check = (int)cmd.ExecuteScalar();
                    conn.Close();

                    if (check >= 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("この書籍を貸出しますか？", "確認メッセージ", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (RequestEmployeeID.Equals(""))
                            {
                                MessageBox.Show("Please Choose the correct EmployeeID..");
                            }
                            else
                            {
                                cmd.CommandText = sql;
                                // パラメータをセットする
                                cmd.Parameters.Add("@employeeID", SqlDbType.VarChar, 10).Value = RequestEmployeeID;
                                cmd.Parameters.Add("@bookID", SqlDbType.Int).Value = RequestBookId;
                                cmd.Parameters.Add("@nums", SqlDbType.Int).Value = numericIventory.Value;
                                cmd.Parameters.Add("@createID", SqlDbType.Int).Value = 2;
                                conn.Open();
                                // INSERTを実行する
                                int cnt1 = cmd.ExecuteNonQuery();
                                conn.Close();
                                // 処理件数を表示する（※基本的に1）
                                Console.WriteLine(cnt1);

                                cmd.CommandText = query;

                                cmd.Parameters.Add("@Iventory", SqlDbType.Int).Value = check;
                                conn.Open();
                                // INSERTを実行する
                                int cnt2 = cmd.ExecuteNonQuery();
                                conn.Close();
                                // 処理件数を表示する（※基本的に1）
                                Console.WriteLine(cnt2);
                                if (cnt1 + cnt2 > 0)
                                {
                                    MessageBox.Show("Book requested successfuly..");
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
                    else
                    {
                        MessageBox.Show("Not enough stock...");
                    }
                }

            }

        }

        private void UserRequestBookScrn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("画面を閉じてもよろしいですか？","確認メッセージ",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            UserHomescreen userHomescreen = new UserHomescreen();
            userHomescreen.Show();
            
        }


    }
}
