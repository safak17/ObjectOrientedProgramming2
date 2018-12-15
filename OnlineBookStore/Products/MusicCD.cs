using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //MessageBox

namespace OnlineBookStore.Products
{
    public enum musicType { Romance, HardRock, Country }

    class MusicCD : Product
    {
        private string singer;
        private musicType type;

        public MusicCD(string name, int id, double price, string singer, musicType type) : base(name, id, price)
        {
            Singer = singer;
            Type = type;
        }

        public string Singer
        {
            get
            {
                return singer;
            }

            set
            {
                singer = value;
            }
        }

        public musicType Type
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
                "Price: " + Price + Environment.NewLine + "Singer: " + Singer + Environment.NewLine + "Type: " + Type;

            MessageBox.Show(properties, "Properties", MessageBoxButtons.OK);
        }

        /*  SQL Commands For Magazine Class  */
        public static string GetSelectCommand()
        {
            return "SELECT * FROM tblMusicCD";
        }
        public static string GetInsertCommand()
        {
            return "INSERT INTO tblMusicCD values(@name, @id, @price, @singer, @type);";
        }
    }
}
