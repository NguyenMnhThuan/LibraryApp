using System;
using System.Collections.Generic;
using LibraryAppWF.DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppWF.BL
{
    //CHECK THE ADMIN LOGIN CREDENTIALS =>BL
    public class AdminBL
    {
        public bool AdminLoginBL(string adminEmail, string adminPass)
        {
            AdminDAL adminDal = new AdminDAL();
            bool isDone = adminDal.AdminLoginDAL(adminEmail, adminPass);
            return isDone;
        }
        public bool LoginBL(string adminEmail, string adminPass)
        {
            AdminDAL adminDal = new AdminDAL();
            bool isDone = adminDal.LoginDAL(adminEmail, adminPass);
            return isDone;
        }
    }
}
