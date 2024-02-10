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

    class Car
    {
        string CarClass { get; set; }
        int NumbersOfDoors {  get; set; }
        bool IsCabriolet {  get; set; }

        void StartEngine ()
        {
            Console.WriteLine("Врум врум");
        }

        void StopEngine()
        {
            Console.WriteLine("Заглушил двигатель");
        }

        void Drive()
        {
            Console.WriteLine("Машина едет");
        }
    }


}
