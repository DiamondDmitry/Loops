using System;

namespace Loops
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в магазин");
            Console.WriteLine("У нас есть машина");
            
            var suv = new Car(4, "Black");
            var suv1 = new Car(11);

            int numberOfDoors = suv.GetNumberOfDoors();
            int numberOfDoors1 = suv1.GetNumberOfDoors();


            Console.WriteLine("У нее дверей: " + numberOfDoors);
            Console.WriteLine("У нее цвет: " + suv.CarColor);

            Console.WriteLine("\nУ нас есть еще одна машина");

            Car cabriolet = new Car(2,"White");
            Console.WriteLine("У нее дверей: " + numberOfDoors1);
            Console.WriteLine("У нее цвет: " + cabriolet.CarColor);

        }
    }
}
