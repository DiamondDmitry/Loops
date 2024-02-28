using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public static class StringUtils
    {
        public static string ReverseString(string stringToReverse)
        {
            char[] stringArray = stringToReverse.ToCharArray();
            Array.Reverse(stringArray);
            return new string(stringArray);
        }
    }
}
