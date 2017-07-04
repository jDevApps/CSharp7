using System;

namespace CSharp7.Demos
{
    public class InlineOutVariables
    {
        #region Methods Versions previous to C# 7

        public void ShowInteger_1(string str)
        {
            int number;
            if (int.TryParse(str, out number))
            {
                Console.WriteLine("Number: " + number);
            }
        }

        #endregion Methods Versions previous to C# 7

        #region Methods Version C# 7

        public void ShowInteger_2(string str)
        {
            if (int.TryParse(str, out int number))
                Console.WriteLine($"Number: {number}");
        }

        public void ShowInteger_3(string str)
        {
            if (int.TryParse(str, out var number))
                Console.WriteLine($"Number: {number}");
        }

        public static void GetSomething(out int x, out double y, out string z)
        {
            x = 100;
            y = 100.0;
            z = "hello";
        }

        /// <summary>
        /// There are times when we invoke a method with output parameters whose values we will not use later. In order not to force us to declare more variables
        /// in the account, we can use the wildcard "_" (underscore) to indicate to the compiler that it can ignore these values
        /// </summary>
        public static void Example1()
        {
            GetSomething(out var x, out _, out _);
            Console.WriteLine(x); // Shows "100"
        }

        #endregion Methods Version C# 7
    }
}