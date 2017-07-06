using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7.Demos
{
    public class ThrowExpressions
    {
        #region Methos versions previous to C# 7

        private readonly object _first;
        private readonly object _second;
        private readonly object _other;

        public ThrowExpressions(object first, object second)
        {
            if (first == null)
                throw new ArgumentNullException("first");

            if (second == null)
                throw new ArgumentNullException("second");

            _first = first;
            _second = second;
        }

        #endregion Methos versions previous to C# 7

        #region Methods version C# 7

        /// <summary>
        /// In C # 7 you can simplify the syntax because throw is considered an expression for compiling purposes. That is, with the latest version of C # we can 
        /// simplify the previous method as follows, and compile correctly
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="other"></param>
        public ThrowExpressions(object first, object second, object other)
        {
            _first = first ?? throw new ArgumentNullException("first");
            _second = second ?? throw new ArgumentNullException(nameof(second));
            _other = other ?? throw new ArgumentNullException("other");
        }

        /// <summary>
        /// Another example of use, although of doubtful utility and readability
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Divide(int a, int b)
        {
            return a / (b != 0 ? b : throw new ArgumentOutOfRangeException(nameof(b)));
        }

        #endregion Methods version C# 7
    }
}