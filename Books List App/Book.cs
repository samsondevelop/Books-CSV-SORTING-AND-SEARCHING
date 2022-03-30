using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_List_App
{
    internal class Book
    {
        public string strTextBook { get; set; }
        public string strSubject { get; set; }
        public string strSeller { get; set; }
        public string strPurchaser { get; set; }
        public double dPurchasePrice { get; set; }
        public string strSalePrice { get; set; }
        public string iRating { get; set; }
        public Book(string textbook, string subject, string seller, string purchaser, double purchaseprice, string saleprice, string rating)
        {
            this.dPurchasePrice = purchaseprice;
            this.strTextBook = textbook;
            this.strSubject = subject;
            this.strSeller = seller;
            this.strPurchaser = purchaser;
            this.dPurchasePrice = purchaseprice;
            this.strSalePrice = saleprice;
            this.iRating = rating;
        }
        public string[] toarr()
        {
            return new string[] { strTextBook, strSubject, strSeller, strPurchaser, dPurchasePrice.ToString(), strSalePrice, iRating };
        }
    }
}
