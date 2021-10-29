using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic.classes
{
    class Calculator : ICalculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public double Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
