using System;

namespace Calc.UI.Cnsl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator in C# ");
            //Console.WriteLine(Calculator.Simple.Add(2, 3));
            //TestOverflow();
            //CatchOverflow();
            //MaybeThisTimeWeCanCatchIt();
            SetTheNameRight();
        }

        static void TestOverflow()
        {
            uint x = uint.MaxValue;
            Console.WriteLine($"max value: {x}");
            Console.WriteLine(Calculator.Simple.Add(x, 1));
        }

        static void CatchOverflow()
        {
            checked
            {
                try
                {
                    Console.WriteLine(Calculator.Simple.Add(int.MaxValue, 1));
                }
                catch (OverflowException)
                {
                    throw;
                }
            }
        }

        static void MaybeThisTimeWeCanCatchIt()
        {
            Console.WriteLine(Calculator.Simple.SafeAdd(int.MaxValue, 3));
        }

        static void SetTheNameRight()
        {
            string name = "jay";
            Console.WriteLine(name);
            string fixedName = name.Capitalize();
            Console.WriteLine(fixedName);
        }
    }

    static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            return input.Substring(0, 1).ToUpper() +
                    input.Substring(1);
        }
    }
}
