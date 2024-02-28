using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public static class Overloads
    {
        public static int Add(int num1, int mun2)
        {
            return num1 + mun2;
        }

        public static float Add(float num1, float mun2)
        {
            return num1 + mun2;
        }

        public static string Concatenate(string str1, string str2)
        {
            return str1 + str2;
        }

        public static string Concatenate(string str1, string str2, string str3)
        {
            return str1 + str2 + str3;
        }
        public static void PrintInfo(string name, int age)
        {
            Console.WriteLine($"Привет, {name}! Тебе {age} года.");
        }
        public static void PrintInfo(string name, int age, string address)
        {
            Console.WriteLine($"Привет, {name}! Тебе {age} лет и ты живешь по адрессу{address}.\n");
        }

        public static int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Calculate(int firstNumber, int secondNumber, char mathType = '+')
        {
            switch (mathType)
            {
                case '-':
                    return firstNumber - secondNumber;
                    break;
                case '*':
                    return firstNumber * secondNumber;
                    break;

                default:
                    return firstNumber + secondNumber;
                    break;
            }

        }
    }
}
