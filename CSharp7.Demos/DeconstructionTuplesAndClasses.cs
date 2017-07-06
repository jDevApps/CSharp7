using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7.Demos
{
    public class DeconstructionTuplesAndClasses
    {
        #region Methods version C# 7

        public void Test()
        {
            var sum = Sum(1, 3);
            Console.WriteLine($"Sum: {sum}");

            int Sum(int a, int b)
            {
                return a + b;
            }
        }

        /// <summary>
        /// The var keyword can be used to indicate to the compiler that it is the one that is responsible for inferring the types of the elements of the tuple
        /// </summary>
        public void Test_2()
        {
            var (add, sub, mul, div) = Calculate(1, 3);
            Console.WriteLine($"Sum: {add}");

            (int add, int sub, int mul, int div) Calculate(int a, int b)
            {
                return (a + b, a - b, a * b, a / b);
            }
        }

        /// <summary>
        /// Defining the type of each variable separately
        /// </summary>
        public void Test_3()
        {
            (int add, int sub, int mul, int div) = Calculate(1, 3);
            (var add, var sub, var mul, var div) = Calculate(1, 3);
            var (add, sub, mul, div) = Calculate(1, 3);
        }

        /// <summary>
        /// You can deconstruct on previously existing variables
        /// </summary>
        public void Test_4()
        {
            int add, sub, mul, div;
            (add, sub, mul, div) = Calculate(1, 3);
            Console.WriteLine($"Sum: {add}");
        }

        #endregion Methods version C# 7
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public void Deconstruct(out string name, out int age, out string email)
        {
            name = Name;
            age = Age;
            email = Email;
        }
    }
}