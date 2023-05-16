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
    public class BookDAL
    {
        public static SqlConnection conn = new SqlConnection("Server=1803-13-001\\SQLEXPRESSVER1; Database=CompanyLibrary_DB; Integrated Security=true");

        //RETURN THE COMPLETE BOOKS FROM BOOK TABLE =>DAL
        public DataSet GetAllBooksDAL()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT BOOK_ID AS 'ID', " +
                                                "BOOK_NAME AS '書籍名'," +
                                                "AUTHOR AS '著者'," +
                                                "PUBLISHER AS '発行者'," +
                                                "PUBLISH_YEAR AS '発行年'," +
                                                "IVENTORY　AS '在庫'," +
                                                "(SELECT CATEGORY_NAME FROM CATEGORY C WHERE C.CATEGORY_ID = B.CATEGORY_ID) AS '書籍'" +
                                                " FROM BOOK B;", conn);
            DataSet ds = new DataSet("Books");
            da.Fill(ds);
            return ds;
        }
        public DataSet SearchBooksDAL(string searchValues)
        {
            string query = @"SELECT BOOK_ID AS 'ID', " +
                                    "BOOK_NAME AS '書籍名'," +
                                    "AUTHOR AS '著者'," +
                                    "PUBLISHER AS '発行者'," +
                                    "PUBLISH_YEAR AS '発行年'," +
                                    "IVENTORY　AS '在庫'," +
                                    "(SELECT CATEGORY_NAME FROM [CATEGORY] WHERE [CATEGORY].CATEGORY_ID = [BOOK].CATEGORY_ID) AS '書籍'" +
                                    "FROM [BOOK]" +
                                    "WHERE BOOK_NAME LIKE '%"+ @searchValues + "%';";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@searchValues", searchValues);
            DataSet ds = new DataSet("Books");
            da.Fill(ds);
            return ds;
        }
        //ADD BOOK INTO BOOK TABLE => DAL
        public bool AddBookDAL(string bookName, string Author, string Publisher, decimal publishYear, DateTime purchaseDate, string Purchaser, int Iventory, int cateroryID, int createID )
        {
            string query = @"IF NOT EXISTS (SELECT * FROM [BOOK] " +
                    "WHERE BOOK_NAME = @bookName AND AUTHOR = @Author)\r\n   " +
                    "BEGIN\r\n       " +
                    "INSERT INTO BOOK(BOOK_NAME,AUTHOR,PUBLISHER,PUBLISH_YEAR,PURCHASE_DATE,PURCHASER,IVENTORY,CATEGORY_ID,CREATE_ID) " +
                    "VALUES (@bookName,@Author,@Publisher,@publishYear,@purchaseDate, @Purchaser, @Iventory, @cateroryID, @createID);\r\n   " +
                    "END";


            // コネクションをオープンする

            // コマンドを取得する
            using (SqlCommand cmd = conn.CreateCommand())
            {
                // SQL文をセットする
                cmd.CommandText = query;

                // パラメータをセットする
                cmd.Parameters.Add("@bookName", SqlDbType.VarChar, 100).Value = bookName;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar, 100).Value = Author;
                cmd.Parameters.Add("@Publisher", SqlDbType.VarChar, 100).Value = Publisher;
                cmd.Parameters.Add("@publishYear", SqlDbType.Decimal, 4).Value = publishYear;
                cmd.Parameters.Add("@purchaseDate", SqlDbType.Date).Value = purchaseDate;
                cmd.Parameters.Add("@Purchaser", SqlDbType.VarChar, 60).Value = Purchaser;
                cmd.Parameters.Add("@Iventory", SqlDbType.Int).Value = Iventory;
                cmd.Parameters.Add("@cateroryID", SqlDbType.Int).Value = cateroryID;
                cmd.Parameters.Add("@createID", SqlDbType.Int).Value = createID;
                conn.Open();
                // INSERTを実行する
                int cnt = cmd.ExecuteNonQuery();
                conn.Close();
                // 処理件数を表示する（※基本的に1）
                Console.WriteLine(cnt);
                if (cnt == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        //UPDATE THE BOOK FROM BOOK TABLE =>DAL
        public bool UpdateBookDAL(int BookId,string bookName, string Author, string Publisher, decimal publishYear, DateTime purchaseDate, string Purchaser, int Iventory, int cateroryID)
        {
            string query = @"UPDATE BOOK SET BOOK_NAME = @bookName," +
                            "                AUTHOR = @Author," +
                            "                PUBLISHER = @Publisher," +
                            "                PUBLISH_YEAR = @publishYear," +
                            "                PURCHASE_DATE = @purchaseDate," +
                            "                PURCHASER = @Purchaser," +
                            "                IVENTORY = @Iventory," +
                            "                CATEGORY_ID = @cateroryID " +
                            "WHERE BOOK_ID = " + BookId + ";";

            // コネクションをオープンする

            // コマンドを取得する
            using (SqlCommand cmd = conn.CreateCommand())
            {
                // SQL文をセットする
                cmd.CommandText = query;

                // パラメータをセットする
                cmd.Parameters.Add("@bookName", SqlDbType.VarChar, 100).Value = bookName;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar, 100).Value = Author;
                cmd.Parameters.Add("@Publisher", SqlDbType.VarChar, 100).Value = Publisher;
                cmd.Parameters.Add("@publishYear", SqlDbType.Decimal, 4).Value = publishYear;
                cmd.Parameters.Add("@purchaseDate", SqlDbType.Date).Value = purchaseDate;
                cmd.Parameters.Add("@Purchaser", SqlDbType.VarChar, 60).Value = Purchaser;
                cmd.Parameters.Add("@Iventory", SqlDbType.Int).Value = Iventory;
                cmd.Parameters.Add("@cateroryID", SqlDbType.Int).Value = cateroryID;
                conn.Open();
                // INSERTを実行する
                int cnt = cmd.ExecuteNonQuery();
                conn.Close();
                // 処理件数を表示する（※基本的に1）
                Console.WriteLine(cnt);
                if (cnt == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //DELETE THE BOOK FROM BOOK TABLE =>DAL
        public bool DeleteBookDAL(int bookId)
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
