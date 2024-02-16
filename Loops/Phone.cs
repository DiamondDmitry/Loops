using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Phone
    {
        public string OperationSystem { get; set; }
        public string Color { get; set; }
        private decimal Price { get; set; }
        public string Brand { get; set; }
        private int LocalTax { get; set; } = 13;

        public Phone() 
        {
            Color = "Black";
            Price = 100.00m;
        }
        public Phone(string operationSystem, string color, decimal price, string brand)
        {
            OperationSystem = operationSystem;
            Color = color;
            Price = price;
            Brand = brand;
        }

        public void PhoneBoot()
        {
            Console.WriteLine(OperationSystem);
            Console.WriteLine(Color);
            Console.WriteLine(Price);
            Console.WriteLine(Brand);
        }

        public void SetPhonePrice(decimal newPrice)
        {
            Price = newPrice;
            Console.WriteLine("Цена на телефон установленна на: " + Price);
        }

        public decimal GetPhonePriceWithTax()
        {
            decimal priceWithTax = Price + (Price * LocalTax / 100);
            return priceWithTax;
        }

        public void SetProvinceTax(string nameofProvince)
        {
            switch (nameofProvince)
            {
                case "MB":
                    LocalTax = 13;
                    break;

                case "ON":
                    LocalTax = 12;
                    break;

                case "SK":
                    LocalTax = 10;
                    break;

                case "AB":
                    LocalTax = 8;
                    break;

                case "BC":
                    LocalTax = 11;
                    break;
            }

        }

    }
}
