using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public abstract class StoreManager
    {
        public abstract bool IsProductExpried(string product);
        public abstract int GetProductPrice(string product);
        public abstract string GetProductInfo(string productName);
        public void OrderProduct(string productName, int qnty, string supplierName)
        {
            Console.WriteLine($"Продукт {productName} заказан у {supplierName}, в количестве {qnty} едениц");
        }
    }

    public class FruitStore : StoreManager
    {
        public override bool IsProductExpried(string product)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            if (num > 50) return true;
            else return false;
        }

        public override int GetProductPrice(string product)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 11)*10;
            return num;
        }

        public override string GetProductInfo(string productName)
        {
            string madeIn = "India";
            return madeIn;
        }
    }

    public class LiquorMart : StoreManager
    {
        public override bool IsProductExpried(string product)
        {
            DateTime today = DateTime.Today;
            today = today.AddYears(2);
            Console.WriteLine(today.ToString("D"));
            return true;
        }

        public override int GetProductPrice(string product)
        {
            Random rnd = new Random();
            int num = rnd.Next(5, 21) * 16;
            return num;
        }

        public override string GetProductInfo(string productName)
        {
            string madeIn = productName + " Scotland";
            return madeIn;
        }
    }

    public class CheeseStore : StoreManager
    {
        public override bool IsProductExpried(string product)
        {
            if (product.Contains("gauda"))
            return true;
            else
                return false;
        }

        public override int GetProductPrice(string product)
        {
            Random rnd = new Random();
            int num = rnd.Next(33, 56) / 4;
            return num;
        }

        public override string GetProductInfo(string productName)
        {
            string madeIn = "Spain";
            if (productName.Contains("blue"))
            {
                madeIn = "France";
            }
            return madeIn;
        }
    }

}
