using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // ArrayList
using System.Windows.Forms;//For MessageBox
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
namespace OnlineBookStore
{
    class ShoppingCart
    {
        public int m_customerId;
        private ArrayList m_itemsToPurchase=new ArrayList();
        private double m_paymentAmount;
        private bool m_PaymentType;
        
        public int CustomerId
        {
            get
            {
                return m_customerId;
            }

            set
            {
                m_customerId = value;
            }
        }

        //public ArrayList ItemsToPurchase
        //{
        //    get
        //    {
        //        return m_itemsToPurchase;
        //    }

        //    set
        //    {
        //        m_itemsToPurchase = value;
        //    }
        //}

        public double PaymentAmount
        {
            get
            {
                return m_paymentAmount;
            }

            set
            {
                m_paymentAmount = value;
            }
        }

        public bool PaymentType
        {
            get
            {
                return m_PaymentType;
            }
            set
            {
                m_PaymentType = value;
            }
        }

        public string PrintProducts()
        {
            string Sum = "";
            for (int i = 0; i < m_itemsToPurchase.Count; i++)
            {
               Sum += "Name:" + ((Product)(m_itemsToPurchase[i])).name + " ID:" + ((Product)(m_itemsToPurchase[i])).id + " Price:" + ((Product)(m_itemsToPurchase[i])).price+Environment.NewLine;

            }


            MessageBox.Show(Sum.ToString(),"Products");

            return Sum;
        }



        public void AddProduct(Product itemToPurchase)
        {
          

            m_itemsToPurchase.Add(itemToPurchase);
           
        }
        public void RemoveProduct(Product itemToPurchase)
        {
            m_itemsToPurchase.Remove(itemToPurchase);

        }
        public void PlaceOrder()   // perform the payment for the items in the cart and send invoice to custumer’s email.
        {
            for (int i = 0; i < m_itemsToPurchase.Count; i++)
            {
                this.m_paymentAmount += ((Product)(m_itemsToPurchase[i])).price;

            }
         


            MessageBox.Show(PrintProducts()+ "Succesful your place Order:" + this.m_paymentAmount);
        }
        public void CancelOrder()
        {
          
            MessageBox.Show(PrintProducts() + "Cancelled your place Order:" + this.m_paymentAmount);
            m_itemsToPurchase.Clear();
        }
        public void SendinvoicebySMS()
        {

        }
        public void SendinvoicebyEmail()
        {
            
        }



    }
}
