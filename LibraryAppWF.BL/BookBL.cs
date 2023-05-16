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
    public class BookBL
    {
        //VALIDATION METHOD FOR VALIDATE BOOK DETAILS
        public string BookValidate(string bookName, string Author, string Publisher, decimal publishYear, string purchaseDate, string Purchaser, int Iventory, int cateroryID, int createID)
        {

            if (bookName.Equals(string.Empty))
            {
                return "Invalid book name, ";
            }
            else if (Author.Equals(string.Empty))
            {
                return "Invalid author name, ";
            }
            else if (Publisher.Equals(string.Empty))
            {
                return "Invalid book publisher, ";
            }
            else if (publishYear == 0)
            {
                return "Invalid book publishYear, ";
            }
            else if (Purchaser.Equals(string.Empty))
            {
                return "Invalid book Purchaser, ";
            }
            else if (Iventory == 0)
            {
                return "Invalid book price, ";
            }
            else if (cateroryID == 0)
            {
                return "Invalid book caterory, ";
            }
            else if (createID == 0)
            {
                return "Invalid book createID, ";
            }
            else
            {
                return "true";
            }

        }
        //RETURN THE COMPLETE BOOKS FROM BOOK TABLE =>BL
        public DataSet GetAllBooksBL()
        {
            BookDAL bookDal = new BookDAL();
            DataSet ds = bookDal.GetAllBooksDAL();
            return ds;
        }
        public DataSet SearchBooksBL(string searchValues)
        {
            BookDAL bookDal = new BookDAL();
            DataSet ds = bookDal.SearchBooksDAL(searchValues);
            return ds;
        }
        
        //ADD BOOK INTO BOOK TABLE => BL
        public string AddBookBL(string bookName, string Author, string Publisher, decimal publishYear, DateTime purchaseDate, string Purchaser, int Iventory, int cateroryID, int createID)
        {
            string isBookValid = BookValidate( bookName, Author, Publisher, publishYear, purchaseDate.ToString(), Purchaser, Iventory, cateroryID, createID);
            if (isBookValid == "true")
            {
                BookDAL bookDAL = new BookDAL();
                bool isDone = bookDAL.AddBookDAL(bookName, Author, Publisher, publishYear, purchaseDate, Purchaser, Iventory, cateroryID, createID);
                if (isDone != true)
                {
                    return "Server error, ";
                }
                else
                {
                    return "true";
                }
            }
            else
            {
                return isBookValid;
            }

        }
        public bool UpdateBookBL(int BookId, string bookName, string Author, string Publisher, decimal publishYear, DateTime purchaseDate, string Purchaser, int Iventory, int cateroryID)
        {
            BookDAL bookDAL = new BookDAL();
            bool isDone = bookDAL.UpdateBookDAL(BookId, bookName, Author, Publisher, publishYear, purchaseDate, Purchaser, Iventory, cateroryID);
            return isDone;
        }
        //DELETE THE BOOK FROM BOOK TABLE =>BL
        public bool DeleteBookBL(int bookId)
        {
            BookDAL bookDAL = new BookDAL();
            bool isDone = bookDAL.DeleteBookDAL(bookId);
            return isDone;
        }

    }
}
