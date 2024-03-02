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
            int choice = Convert.ToInt32(Console.ReadLine());

            FruitStore bestFruits = new FruitStore();
            string fruit = "Orange";
            bestFruits.OrderProduct(fruit, 5, "Mexico Orange");
            Console.WriteLine($"Продукт годен: {bestFruits.IsProductExpried(fruit)}");
            Console.WriteLine($"Цена продукта: {bestFruits.GetProductPrice(fruit)}");
            Console.WriteLine($"Страна производитель: {bestFruits.GetProductInfo(fruit)}");

            LiquorMart liquorMart = new LiquorMart();
            string drink = "Scotch whisky";
            Console.WriteLine();
            liquorMart.OrderProduct(drink, 20, "Blue Label");
            Console.WriteLine($"Продукт годен: {liquorMart.IsProductExpried(drink)}");
            Console.WriteLine($"Цена продукта: {liquorMart.GetProductPrice(drink)}");
            Console.WriteLine($"Страна производитель: {liquorMart.GetProductInfo(drink)}");

            CheeseStore cheeseStore = new CheeseStore();
            string cheese = "Chesse gauda";
            //string cheese = "Dorblue";
            Console.WriteLine();
            cheeseStore.OrderProduct(cheese, 20, "European Cheeses");
            Console.WriteLine($"Продукт годен: {cheeseStore.IsProductExpried(cheese)}");
            Console.WriteLine($"Цена продукта: {cheeseStore.GetProductPrice(cheese)}");
            Console.WriteLine($"Страна производитель: {cheeseStore.GetProductInfo(cheese)}");

        }
    }
}
