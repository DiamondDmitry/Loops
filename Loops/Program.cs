using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;

namespace Loops
{
    internal class Program
    {
        static void Main()
        {
            // Интерполяция строк
            // Задача 1: Простая интерполяция
            string name = "Justin";
            string city = "Winnipeg";
            int age = 33;
            Console.WriteLine($"Привет, {name}! Тебе {age} года и ты живешь в городе{city}.");

            // Задача 2: Математическая интерполяция

            float num1 = 2345.65F;
            float num2 = 12344.367F;

            Console.WriteLine();
            Console.WriteLine($"Сумма чисел {num1} и {num2} равна: {num1 + num2}");
            Console.WriteLine($"Разночть чисел {num1} и {num2} равна: {num1 - num2}");
            Console.WriteLine($"Произведение чисел {num1} и {num2} равно: {num1 * num2}");
            Console.WriteLine($"Частное чисел {num1} и {num2} равна: {num1 / num2}");

            // Задача 3: Длина строки и ее интерполяция

            string favoriteThought = "Работа — это не волк. Работа — ворк. А волк — это ходить!";

            Console.WriteLine();
            Console.WriteLine($"Длинна строки: {favoriteThought.Length}. Строка: {favoriteThought}");

            // Задача 4: Интерполяция для даты

            var curentDateTime = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine($"Сегодня {curentDateTime:D} и {curentDateTime:t}");

            // Статические классы и констатны
            // Задача 1: Создание статического класса

            double number1 = 935345.65345;
            double number2 = 41744.3672;

            Console.WriteLine();
            Console.WriteLine($"Результат использования метода 'сложения' равен: {MathHelper.Addition(number1, number2)}");
            Console.WriteLine($"Результат использования метода 'разности' равен: {MathHelper.Subtraction(number1, number2)}");
            Console.WriteLine($"Результат использования метода 'произведения' равен: {MathHelper.Multiplication(number1, number2)}");
            Console.WriteLine($"Результат использования метода 'деления' равен: {MathHelper.Division(number1, number2)}");

            // Задача 2: Создание статической утилиты

            string namePerson = "Дмитрий";
            Console.WriteLine();
            Console.WriteLine($"Ваше имя {namePerson} на оборот будет:{StringUtils.ReverseString(namePerson)}");

            // Задача 3: Работа с константами

            Console.WriteLine();
            Console.WriteLine($"Число PI = {Constants.PI}");
            Console.WriteLine($"Максимальное количество попыток в игре равно {Constants.maxTry}");
            Console.WriteLine($"Любимый сайт всея интернета = {Constants.url}");

            // Задача 4: Счетчик вызовов метода

            Counter.Increment();
            Counter.Increment();
            Counter.Increment();
            Console.WriteLine();
            Console.WriteLine($"Я вызвал метод Increment {Counter.callCount} раза");

            // Методы
            // Задача 1: Перегрузка метода для сложения чисел
            Console.WriteLine();
            Console.WriteLine(Overloads.Add(34453, 6723));
            Console.WriteLine(Overloads.Add(4345.645F, 31231.543F));

            // Задача 2: Перегрузка метода для объединения строк
            Console.WriteLine();
            Console.WriteLine(Overloads.Concatenate("Добрый ", "день! "));
            Console.WriteLine(Overloads.Concatenate("Добрый ", "день! ", "Как дела?"));

            // Задача 3: Перегрузка метода с различными параметрами
            Console.WriteLine();
            Overloads.PrintInfo("Василий", 64);
            Overloads.PrintInfo("Андрей", 36, " 3-я улица строителей, дом 25");

            //Задача 4: Перегрузка метода с параметрами по умолчанию
            Console.WriteLine();
            Console.WriteLine(Overloads.Calculate(12123, 67213));
            Console.WriteLine(Overloads.Calculate(4678, 2134));
            Console.WriteLine(Overloads.Calculate(4678, 2134, 'a'));
            Console.WriteLine(Overloads.Calculate(4678, 2134, '-'));
            Console.WriteLine(Overloads.Calculate(4678, 2134, '*'));

            // Наследование
            //Задание 1: Создание и использование наследования

            Car suv = new Car();
            suv.Year = 2018;
            suv.ModelName = "Explorer";
            suv.MaxSpeed = 250;
            suv.NumberOfDors = 4;
            
            Console.WriteLine();
            Console.WriteLine($"Название модели: {suv.ModelName}");
            Console.WriteLine($"Год выпуска: {suv.Year}");
            Console.WriteLine($"Максимальная скорость: {suv.MaxSpeed}");
            Console.WriteLine($"Количество дверей: {suv.NumberOfDors}");

            Car cabrio = new Car();
            cabrio.Year = 2012;
            cabrio.ModelName = "TT";
            cabrio.MaxSpeed = 280;
            cabrio.NumberOfDors = 2;

            Console.WriteLine();
            Console.WriteLine($"Название модели: {cabrio.ModelName}");
            Console.WriteLine($"Год выпуска: {cabrio.Year}");
            Console.WriteLine($"Максимальная скорость: {cabrio.MaxSpeed}");
            Console.WriteLine($"Количество дверей: {cabrio.NumberOfDors}");

            Car limo = new Car();
            limo.Year = 2008;
            limo.ModelName = "Town Car";
            limo.MaxSpeed = 180;
            limo.NumberOfDors = 5;

            Console.WriteLine();
            Console.WriteLine($"Название модели: {limo.ModelName}");
            Console.WriteLine($"Год выпуска: {limo.Year}");
            Console.WriteLine($"Максимальная скорость: {limo.MaxSpeed}");
            Console.WriteLine($"Количество дверей: {limo.NumberOfDors}");

            //Задание 2: Создание и использование наследования
            Meat chiken = new Meat();
            chiken.SkuCode = "mt123";
            chiken.ExpiryDate = DateTime.Now;
            chiken.Price = 12.99;
            chiken.StoredInTheFridge = true;

            Console.WriteLine();
            Console.WriteLine($"номер SKU: {chiken.SkuCode}");
            Console.WriteLine($"Использовать до: {chiken.ExpiryDate:D}");
            Console.WriteLine($"Цена: {chiken.Price}");
            Console.WriteLine($"Нужно ли хранить в холодильнике: {chiken.StoredInTheFridge}");

            Fish salmon = new Fish();
            salmon.SkuCode = "fs321";
            salmon.ExpiryDate = DateTime.Now;
            salmon.Price = 9.99;
            salmon.Farmed = false;

            Console.WriteLine();
            Console.WriteLine($"номер SKU: {salmon.SkuCode}");
            Console.WriteLine($"Использовать до: {salmon.ExpiryDate:D}");
            Console.WriteLine($"Цена: {salmon.Price}");
            Console.WriteLine($"Выращена была на ферме: {salmon.Farmed}");

        }
    }
}
