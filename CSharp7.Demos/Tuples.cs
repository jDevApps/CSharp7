using System;

namespace CSharp7.Demos
{
    public class Tuples
    {
        #region Methods versions previous to C# 7

        public void TupleTest()
        {
            // Tuple with two integers
            var coords = new Tuple<int, int>(100, 200);
            // Creation using factory with type inference
            var coords2 = Tuple.Create(100, 200);
            // With three elements
            var coords3d = Tuple.Create(100, 200, 300);
            // With four elements of different type
            var person = Tuple.Create("John", new DateTime(1997, 2, 3), 1.68m, true);

            Console.WriteLine(coords.Item2); // 200
            Console.WriteLine(coords3d.Item3); // 300
            Console.WriteLine(person.Item4); // True
        }

        #endregion Methods versions previous to C# 7

        #region Methods version C# 7

        /// <summary>
        /// Examples for constructing tuples and using them as parameters in functions
        /// </summary>
        public void TupleTest_1()
        {
            var coords3d = ValueTuple.Create(100, 200, 300);
            Console.WriteLine(coords3d.Item1); // 100

            // Creating tuples - form 1
            var person = ("John", 34);
            Console.WriteLine(person.Item1);  // John
            Console.WriteLine(person.Item2);  // 34

            // Form 2
            var person2 = (name: "John", age: 34);
            Console.WriteLine(person2.name); // John
            Console.WriteLine(person2.age);  // 34
            Console.WriteLine(person2.GetType()); // System.ValueTuple`2[System.String,System.Int32]

            show(person2);

            void show((string name, int age) prs)
            {
                Console.WriteLine($"Name: {prs.name}");
                Console.WriteLine($"Age: {prs.age}");
            }
        }

        /// <summary>
        /// To consume a method that returns a tuple with named members
        /// </summary>
        private void TupleTest_2()
        {
            var person = create();
            Console.WriteLine(person.age); // 23

            (string name, int age) create() =>
                 (name: "Test", age: 23);
        }

        /// <summary>
        /// Deconstruction of tuples
        /// </summary>
        private void TupleTest_3()
        {
            // Form 1
            (var name, var age, var height) = create();
            // Form 2
            var (name1, age1, height1) = create();

            Console.WriteLine($"{name} is {age} years old");

            (string name, int age, decimal height) create() => (name: "John", age: 23, height: 1.68m);
        }

        #endregion Methods version C# 7
    }
}