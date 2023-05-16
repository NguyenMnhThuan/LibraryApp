using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace LibraryAppWF.DAL
{
    public class LoanDAL
    {
        public static SqlConnection conn = new SqlConnection("Server=1803-13-001\\SQLEXPRESSVER1; Database=CompanyLibrary_DB; Integrated Security=true");

        //RETURN THE COMPLETE LOANS FROM LOAN TABLE =>DAL
        public DataSet GetAllLoansDAL()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT LOAN_ID AS 'ID', EMPLOYEE_ID AS '社員番号'," +
                                                   "(SELECT BOOK_NAME FROM BOOK B WHERE B.BOOK_ID = L.BOOK_ID) AS '書籍名'," +
                                                   "LOANED_NUMS AS '数量'," +
                                                   "LOANED_DATE AS '貸出日付'," +
                                                   "RETURN_DATE AS '返却日付'," +
                                                   "CREATE_ID AS '担当番号'," +
                                                   "CREATE_TIMESTAMP AS '登録時点' FROM LOAN L;", conn);
            DataSet ds = new DataSet("Loans");
            da.Fill(ds);
            return ds;
        }
        public DataSet SearchLoansDAL(string searchValues)
        {
            string query = @"SELECT LOAN_ID AS 'ID', EMPLOYEE_ID AS '社員番号'," +
                                                   "(SELECT BOOK_NAME FROM BOOK B WHERE B.BOOK_ID = L.BOOK_ID) AS '書籍名'," +
                                                   "LOANED_NUMS AS '数量'," +
                                                   "LOANED_DATE AS '貸出日付'," +
                                                   "RETURN_DATE AS '返却日付'," +
                                                   "CREATE_ID AS '担当番号'," +
                                                   "CREATE_TIMESTAMP AS '登録時点' FROM LOAN L" +
                                                   " WHERE EMPLOYEE_ID LIKE '%"+ @searchValues + "%';";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@searchValues", searchValues);
            DataSet ds = new DataSet("Loans");
            da.Fill(ds);
            return ds;
        }
        //ADD LOAN INTO LOAN TABLE => DAL
        //public bool LendingBooksDAL(string bookName, string Author, string Publisher, decimal publishYear, DateTime purchaseDate, string Purchaser, int Iventory, int cateroryID, int createID )
        //{
        


        //    // コネクションをオープンする

        //    // コマンドを取得する
        //    using (SqlCommand cmd = conn.CreateCommand())
        //    {
        //        // SQL文をセットする
        //        cmd.CommandText = query;

        //        // パラメータをセットする
        //        cmd.Parameters.Add("@bookName", SqlDbType.VarChar, 100).Value = bookName;
        //        cmd.Parameters.Add("@Author", SqlDbType.VarChar, 100).Value = Author;
        //        cmd.Parameters.Add("@Publisher", SqlDbType.VarChar, 100).Value = Publisher;
        //        cmd.Parameters.Add("@publishYear", SqlDbType.Decimal, 4).Value = publishYear;
        //        cmd.Parameters.Add("@purchaseDate", SqlDbType.Date).Value = purchaseDate;
        //        cmd.Parameters.Add("@Purchaser", SqlDbType.VarChar, 60).Value = Purchaser;
        //        cmd.Parameters.Add("@Iventory", SqlDbType.Int).Value = Iventory;
        //        cmd.Parameters.Add("@cateroryID", SqlDbType.Int).Value = cateroryID;
        //        cmd.Parameters.Add("@createID", SqlDbType.Int).Value = createID;
        //        conn.Open();
        //        // INSERTを実行する
        //        int cnt = cmd.ExecuteNonQuery();
        //        conn.Close();
        //        // 処理件数を表示する（※基本的に1）
        //        Console.WriteLine(cnt);
        //        if (cnt == 1)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

        //}
        //DELETE THE LOAN FROM LOAN TABLE =>DAL
        public bool ReturnBooksDAL(int bookId)
        {
            string query = @"DELETE FROM BOOK WHERE BOOK_ID = @id;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@id", bookId));
            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
