using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // MessageBox

namespace OnlineBookStore.Products
{
    class Book : Product
    {
        public int isbn;
        public string author;
        public string publisher;
        public int page;

        public Book(string name, int id, double price, int isbn, string author, string publisher, int page) : base(name, id, price)
        {
            Isbn = isbn;
            Author = author;
            Publisher = publisher;
            Page = page;
        }

        public int Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value;
            }
        }

        public int Page
        {
            get
            {
                return page;
            }

            set
            {
                page = value;
            }
        }

        public override void PrintProperties()
        {
            string properties = "Name: " + Name + Environment.NewLine + "ID: " + Id + Environment.NewLine +
                "Price: " + Price + Environment.NewLine + "ISBN Number: " + Isbn + Environment.NewLine +
                "Author: " + Author + Environment.NewLine + "Publisher: " + Publisher + Environment.NewLine + "Page Number: " + Page;

            MessageBox.Show(properties, "Properties", MessageBoxButtons.OK);
        }

     

        public static string GetSelectCommand()
        {
            return "SELECT * FROM tblBook";
        }
        public static string GetInsertCommand()
        {
            return "INSERT INTO tblBook values(@name, @id, @price, @isbn, @author, @publisher, @page);";
        }
    }
}