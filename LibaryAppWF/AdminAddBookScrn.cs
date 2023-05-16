using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using LibraryAppWF.BL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibaryAppWF
{
    public partial class AdminAddBookScrn : Form
    {
        public AdminAddBookScrn()
        {
            InitializeComponent();
            dTPPublishYear.Format = DateTimePickerFormat.Custom;
            dTPPublishYear.CustomFormat = "yyyy";
            this.FormClosing += AdminAddBookScrn_FormClosing;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void AdminAddBookScrn_Load(object sender, EventArgs e)
        {

        }
        //ADD THE BOOKS DETAILS INTO BOOK TABEL =>PL
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bookName = tbBName.Text;
            string Author = tbBAuthor.Text;
            string Publisher = tbPulisher.Text;
            decimal publishYear = dTPPublishYear.Value.Year;
            DateTime purchaseDate = dTPurchasedDay.Value;
            string Purchaser = tbPurchaser.Text;
            int Iventory = (int)numericIventory.Value;
            int cateroryID = (int)numericCategory.Value;
            int createID = 2;
            if (bookName != string.Empty && Author != string.Empty && Publisher != string.Empty && publishYear != 0
                && Purchaser != string.Empty && Iventory != 0 && cateroryID != 0)
            {
                try
                {
                    BookBL bookBL = new BookBL();
                    string isDone = bookBL.AddBookBL(bookName, Author, Publisher, publishYear, purchaseDate, Purchaser, Iventory, cateroryID, createID);
                    if (isDone == "true")
                    {
                        MessageBox.Show("Book added successfuly..");
                        AdminHomescreen adminHomescreen = new AdminHomescreen();
                        adminHomescreen.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(isDone + "Try again..");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Enter the fields properly...");
                }
            }
            else
            {
                MessageBox.Show("Enter the fields properly..");
            }
        }
        private void AdminAddBookScrn_FormClosing(object sender, FormClosingEventArgs e)
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
