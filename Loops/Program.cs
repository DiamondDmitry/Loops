using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;

namespace Loops
{
    internal class Program
    {
        static void Main()
        {
            var stringToTest = "Apple is red";
            var stringToTest2 = "Banana is yellow";
            var resault = RedUtility.IsContainsWordRed(stringToTest);
            var resault2 = RedUtility.IsContainsWordRed(stringToTest2);
            var price = RedUtility.Pi;
            Console.WriteLine(RedUtility.Pi);
            Console.WriteLine(resault);
            Console.WriteLine(resault2);
            var updateString = MyMethod(stringToTest);
            Console.WriteLine(updateString);
            Console.WriteLine($"Pi equals :{RedUtility.Pi}");


        }

        public static string MyMethod(string stringToUpdate)
        {
            return RedUtility.UpdateString(stringToUpdate);
        }
    }
}
