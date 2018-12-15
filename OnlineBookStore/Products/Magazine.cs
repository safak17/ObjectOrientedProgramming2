using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //MessageBox

namespace OnlineBookStore.Products
{
    public enum magazineType { Actual, News, Sport, Computer, Technology }

    class Magazine : Product
    {
        /*  ATTRIBUTES      */
        private string issue;
        private magazineType type;

        public Magazine(string name, int id, double price, string issue, magazineType type) : base(name, id, price)
        {
            Issue = issue;
            Type = type;
        }

        /*  Getters & Setters   */
        public string Issue
        {
            get
            {
                return issue;
            }

            set
            {
                issue = value;
            }
        }

        public magazineType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public override void PrintProperties()
        {
            string properties = "Name: " + Name + Environment.NewLine + "ID: " + Id + Environment.NewLine +
                "Price: " + Price + Environment.NewLine + "Issue: " + Issue + Environment.NewLine + "Type: " + Type;

            MessageBox.Show(properties, "Properties", MessageBoxButtons.OK);
        }

        /*  SQL Commands For Magazine Class  */
        public static string GetSelectCommand()
        {
            return "SELECT * FROM tblMagazine";
        }
        public static string GetInsertCommand()
        {
            return "INSERT INTO tblMagazine values(@name, @id, @price, @issue, @type);";
        }
    }
}
