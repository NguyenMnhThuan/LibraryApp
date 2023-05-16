using System;
using System.Collections.Generic;
using System.Linq;
using LibraryAppWF.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace LibraryAppWF.BL
{
    public class LoanBL
    {
        //VALIDATION METHOD FOR VALIDATE LOAN DETAILS
        //public string LoanValidate(string bookName, string Author, string Publisher, decimal publishYear, string purchaseDate, string Purchaser, int Iventory, int cateroryID, int createID)
        //{

        //    if (bookName.Equals(string.Empty))
        //    {
        //        return "Invalid book name, ";
        //    }
        //    else if (Author.Equals(string.Empty))
        //    {
        //        return "Invalid author name, ";
        //    }
        //    else if (Publisher.Equals(string.Empty))
        //    {
        //        return "Invalid book publisher, ";
        //    }
        //    else if (publishYear == 0)
        //    {
        //        return "Invalid book publishYear, ";
        //    }
        //    else if (Purchaser.Equals(string.Empty))
        //    {
        //        return "Invalid book Purchaser, ";
        //    }
        //    else if (Iventory == 0)
        //    {
        //        return "Invalid book price, ";
        //    }
        //    else if (cateroryID == 0)
        //    {
        //        return "Invalid book caterory, ";
        //    }
        //    else if (createID == 0)
        //    {
        //        return "Invalid book createID, ";
        //    }
        //    else
        //    {
        //        return "true";
        //    }

        //}
        //RETURN THE COMPLETE BOOKS FROM BOOK TABLE =>BL
        public DataSet GetAllLoansBL()
        {
            LoanDAL loanDal = new LoanDAL();
            DataSet ds = loanDal.GetAllLoansDAL();
            return ds;
        }
        public DataSet SearchLoansBL(string searchValues)
        {
            LoanDAL loanDal = new LoanDAL();
            DataSet ds = loanDal.SearchLoansDAL(searchValues);
            return ds;
        }
        
        //ADD LOAN INTO LOAN TABLE => BL
        //public string LendingBooksBL(string bookName, string Author, string Publisher, decimal publishYear, DateTime purchaseDate, string Purchaser, int Iventory, int cateroryID, int createID)
        //{
            //string isBookValid = LoanValidate( bookName, Author, Publisher, publishYear, purchaseDate.ToString(), Purchaser, Iventory, cateroryID, createID);
            //if (isBookValid == "true")
            //{
            //    BookDAL bookDAL = new BookDAL();
            //    bool isDone = bookDAL.AddBookDAL(bookName, Author, Publisher, publishYear, purchaseDate, Purchaser, Iventory, cateroryID, createID);
            //    if (isDone != true)
            //    {
            //        return "Server error, ";
            //    }
            //    else
            //    {
            //        return "true";
            //    }
            //}
            //else
            //{
            //    return isBookValid;
            //}

        //}
        //DELETE THE BOOK FROM BOOK TABLE =>BL
        public bool ReturnBooksBL(int loanId)
        {
            LoanDAL loanDAL = new LoanDAL();
            bool isDone = loanDAL.ReturnBooksDAL(loanId);
            return isDone;
        }

    }
}
