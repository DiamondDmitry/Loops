using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public static class Counter
    {
        public static int callCount = 0;

        public static void Increment() 
        {
            callCount++;
        }
    }
}
