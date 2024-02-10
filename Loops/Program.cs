using System;

namespace Loops
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в магазин");
            Console.WriteLine("У нас есть бутылка");
            
            var bottle = new Bottle();
            bottle.Volume = 100;
            bottle.FormFactor = "плоская";
            bottle.Material = "пластикова";

            Console.WriteLine("Это бутылка " +  bottle.Material);
            Console.WriteLine("Она " + bottle.FormFactor);
            Console.WriteLine("Ее обьем " + bottle.Volume);
        }
    }
}
