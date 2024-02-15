using System;

namespace Loops
{
    internal class Program
    {
        static void Main()
        {
            var phone = new Phone();

            phone.PhoneBoot();
            phone.SetProvinceTax("AB");
            Console.WriteLine("Цена телефона с налогом: " + phone.GetPhonePriceWithTax());
            phone.SetPhonePrice(88.88m);
            Console.WriteLine("Новая цена телефона с налогом: " + phone.GetPhonePriceWithTax());

        }
    }
}
