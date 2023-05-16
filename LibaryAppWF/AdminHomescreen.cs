using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAppWF.BL;
using System.Net;

namespace LibaryAppWF
{
    public partial class AdminHomescreen : Form
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

        public AdminHomescreen()
        {
            BookId = 0;
            InitializeComponent();
            this.FormClosing += AdminHomescreen_FormClosing;
            BookBL bookBl = new BookBL();
            DataSet ds = bookBl.GetAllBooksBL();
            dgvBookDetails.DataSource = ds.Tables[0];

            var conn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM EMPLOYEE;", conn);
            DataSet dsEmp = new DataSet("Employees");
            da.Fill(dsEmp);
            dgvEmployeeDetails.DataSource = dsEmp.Tables[0];
        }

        private void AdminHomescreen_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn doWork = new DataGridViewCheckBoxColumn();
            doWork.HeaderText = "選択";
            dgvBookDetails.Columns.Insert(0, doWork);
            foreach (DataGridViewRow row in dgvBookDetails.Rows)
            {
                row.Cells[doWork.Name].Value = false;
            }
        }


        private void UserCreatBtn_Click(object sender, EventArgs e)
        {
            
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            string kanaName = tbKanaName.Text;
            string phone = tbPhone.Text;
            DateTime birthDay = dateTPbirthday.Value;
            string sql = @"IF NOT EXISTS (SELECT * FROM [USER_LOGIN] " +
                    "WHERE USER_NAME = @userName AND PASSWORD = @password)\r\n   " +
                    "BEGIN\r\n       " +
                    "INSERT INTO USER_LOGIN(USER_NAME,PASSWORD,FULL_NAME,BIRTHDAY,PHONE) " +
                    "VALUES (@userName,@password,@kanaName,@birthDay,@phone);\r\n   " +
                    "END";

            try
            {
                // コネクションを取得する
                using (var conn = new SqlConnection(connectionString))
                {
                    // コネクションをオープンする
                    conn.Open();

                    // コマンドを取得する
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        // SQL文をセットする
                        cmd.CommandText = sql;

                        // パラメータをセットする
                        cmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = userName;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = password;
                        cmd.Parameters.Add("@kanaName", SqlDbType.VarChar, 50).Value = kanaName;
                        cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = phone;
                        cmd.Parameters.Add("@birthDay", SqlDbType.Date).Value = birthDay;

                        MessageBox.Show("User created successfuly...");

                        // INSERTを実行する
                        int cnt = cmd.ExecuteNonQuery();

                        // 処理件数を表示する（※基本的に1）
                        Console.WriteLine(cnt);

                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            tbUserName.Clear();
            tbPassword.Clear();
            tbKanaName.Clear();
            tbPhone.Clear();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchValues = tBSearch.Text;
            BookBL bookBl = new BookBL();
            DataSet ds = bookBl.SearchBooksBL(searchValues);
            dgvBookDetails.DataSource = ds.Tables[0];

            tBSearch.Clear();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AdminAddBookScrn adminAddBookScrn = new AdminAddBookScrn();
            adminAddBookScrn.Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBookDetails.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    BookId = int.Parse(row.Cells[1].Value.ToString());
                    if (BookId > 0)
                    {
                        AdminUpdateBookScrn adminUpdateBook = new AdminUpdateBookScrn();
                        adminUpdateBook.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Select a book to update...");
                    }
                }
            }
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvBookDetails.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    rows_with_checked_column.Add(row);
                }
            }
            bool isDone = false;
            foreach (DataGridViewRow rows in rows_with_checked_column)
            {
                BookId = int.Parse(rows.Cells[1].Value.ToString());
                if (BookId > 0)
                {
                    BookBL bookBL = new BookBL();
                    bookBL.DeleteBookBL(BookId);
                    isDone = true; 
                }
                else
                {
                    MessageBox.Show("Select a book to delete...");
                }
            }
            if(isDone == true)
            {
                MessageBox.Show("All Selected Book was deleted successfuly..");
            }
            
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            BookBL bookBl = new BookBL();
            DataSet ds = bookBl.GetAllBooksBL();
            dgvBookDetails.DataSource = ds.Tables[0];
        }
        private void dgvBookDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BookId = int.Parse(dgvBookDetails.Rows[e.RowIndex].Cells[1].Value.ToString());
                Iventory = int.Parse(dgvBookDetails.Rows[e.RowIndex].Cells[6].Value.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Select a book properly...");
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void AdminHomescreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("画面を閉じてもよろしいですか？", "確認メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            Home home = new Home();
            home.Show();

        }




        //クエリベージ

        //private void BtnExecute_Click(object sender, EventArgs e)
        //{
        //    //DBの接続文字列
        //    string connectionString = @"Data Source=1803-13-001\SQLEXPRESSVER1;"    //SQLServerインスタンス
        //                            + @"Initial Catalog=CompanyLibrary_DB;"         //使用するデータベース
        //                            + @"User ID=sa;"                                //ユーザー
        //                            + @"Password=furutani-01";                      //パスワード

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    using (SqlCommand command = connection.CreateCommand())
        //    {
        //        DataTable table = new DataTable();
        //        string sql = TxtSQL.Text;

        //        try
        //        {
        //            //データベースの接続開始
        //            connection.Open();
        //            //SQLの設定
        //            command.CommandText = sql;

        //            //入力されたSQLがSELECTで始まる場合
        //            //データを取得してグリッドに表示
        //            if (sql.Trim().ToUpper().StartsWith("SELECT"))
        //            {
        //                // SQLの実行
        //                var adapter = new SqlDataAdapter(command);
        //                adapter.Fill(table);

        //                this.DgvResult.DataSource = table;
        //            }
        //            //SELECT以外の場合は結果をメッセージボックスに表示
        //            else
        //            {
        //                int result = command.ExecuteNonQuery();
        //                MessageBox.Show(string.Format("{0}件処理しました", result));
        //            }
        //        }
        //        catch (Exception exception)
        //        {
        //            MessageBox.Show(exception.Message);
        //        }
        //        finally
        //        {
        //            // データベースの接続終了
        //            connection.Close();
        //        }
        //    }
        //}

    }
}
