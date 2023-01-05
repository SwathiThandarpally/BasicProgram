using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class SwappingNumbers
    {

        public static void SwapingTheNumbers()
        {
            int a = 2, b = 5;
            Console.WriteLine("Before swap a=" + a + " b = " + b);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After swap a=" + a + " b = " + b);

        }
    }
}
