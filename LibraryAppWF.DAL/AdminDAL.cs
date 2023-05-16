using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppWF.DAL
{
    public class AdminDAL
    {
        public static SqlConnection conn = new SqlConnection("Server=1803-13-001\\SQLEXPRESSVER1; Database=CompanyLibrary_DB; Integrated Security=true");
            
        //CHECK THE ADMIN LOGIN CREDENTIALS =>DAL
        public bool AdminLoginDAL(string adminEmail, string adminPass)
        {
            
            string query = "SELECT * FROM [USER_LOGIN] WHERE USER_NAME = @name AND PASSWORD = @pass";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", adminEmail);
            cmd.Parameters.AddWithValue("@pass", adminPass);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count==1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool LoginDAL(string adminEmail, string adminPass)
        {

            string query = "SELECT * FROM [ADMIN_LOGIN] WHERE ADMIN_NAME = @name AND PASSWORD = @pass";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", adminEmail);
            cmd.Parameters.AddWithValue("@pass", adminPass);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
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
