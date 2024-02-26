using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public static class MathHelper
    {
        //Метод сложение
        public static double Addition(double firstNumber, double secondNumber)
        {
            double roundResault = Math.Round(firstNumber + secondNumber, 10);
            return roundResault;
        }

        //Метод вычитание
        public static double Subtraction(double firstNumber, double secondNumber)
        {
            double roundResault = Math.Round(firstNumber - secondNumber, 10);
            return roundResault;
        }

        //Метод умножение
        public static double Multiplication(double firstNumber, double secondNumber)
        {
            double roundResault = Math.Round(firstNumber * secondNumber, 10);
            return roundResault;
        }

        //Метод деление
        public static double Division(double firstNumber, double secondNumber)
        {
            double roundResault = Math.Round(firstNumber / secondNumber, 10);
            return roundResault;
        }

    }
}
