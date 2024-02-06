using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for
            var i = 0;
            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Число " + i + " является четным");
                }
                else
                {
                    Console.WriteLine("Число " + i + " является не четным");
                }
            }

            // while
            var count = 1;
            while (count <= 10)
            {
                if (count % 3 == 0)
                {
                    Console.WriteLine("Число " + count + " кратно 3");
                }
                count++;
            }

            //do-while
            int guess = 0;
            Random rnd = new Random();
            var secret = rnd.Next(1,10);
            i = 1;
            Console.WriteLine("Я загадал число от 1 до 10");

            Console.WriteLine("попробуйте отгадать у вас 5 попыток.");
            do
            {
                while (true)
                { 
                    Console.WriteLine("Введите число: ");
                    string text = Console.ReadLine();
                    if (int.TryParse(text, out guess))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                    }
                }
                i++;
                if (guess == secret)
                {
                    Console.WriteLine("Угадали!");
                    break;
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                if (i > 5)
                {
                    Console.WriteLine("Вы проиграли");
                }
            }
            while (i <= 5);

            // foreach

            int[] numbers = new int[5] { 10, 20, 30, 40, 50 };
            foreach (var item in numbers)
            {
                if (item > 30)
                { 
                    Console.WriteLine("Элемент " + item + " больше 30"); 
                }
                else 
                {
                    Console.WriteLine("Элемент " + item + " меньше  или равен 30");
                }
            }
        }
    }
}
