using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Simple
    {
        public static int Add(int x, int y) => x + y;
        public static int Sub(int x, int y) => x - y;
        public static int Mul(int x, int y) => x * y;
        public static int Div(int x, int y) => x / y;

        public static int SafeAdd(int x, int y)
        {
            checked 
            {
                return x + y;
            }
        }
    }
}
