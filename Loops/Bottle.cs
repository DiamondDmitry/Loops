using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Bottle
    {
        public int Volume {  get; set; }
        public string Material {  get; set; }
        public string FormFactor { get; set; }

        public void Fall()
        {
            Console.WriteLine("Упс бутылка упала");
        }

        public void Razlojilas()
        {
            Console.WriteLine("Бутылка разложилась");
        }
    }

    class Cup
    {
        int Volume { get; set; }
        string Material { get; set; }
        string Color { get; set; }

        void Break()
        {
            Console.WriteLine("Упс стакан разбился");
        }

        void FillUp()
        {
            Console.WriteLine("Наполнил стакан");
        }
    }

    public class Car
    {
        public Car(int numberOfDoors)
        {
            NumbersOfDoors = numberOfDoors;
        }
        public Car(int numberOfDoors, string carColor)
        {
            NumbersOfDoors = numberOfDoors;
            CarColor = carColor;
        }
        public string CarClass { get; set; }
        private int NumbersOfDoors {  get; set; }
        public bool IsCabriolet {  get; set; }
        public string CarColor { get; set; }

        public int GetNumberOfDoors()
        {
            return NumbersOfDoors;
        }
        public void StartEngine ()
        {
            Console.WriteLine("Врум врум");
        }

        public void StopEngine()
        {
            Console.WriteLine("Заглушил двигатель");
        }

        public void Drive()
        {
            Console.WriteLine("Машина едет");
        }
    }


}
