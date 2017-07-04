using System;

namespace CSharp7.Demos
{
    public class LocalFunctions
    {
        #region Methods version previous to C# 7

        public int CalculateSomething_1(int n, int m)
        {
            var fixedN = n < 0 ? 0 : n < 11 ? 10 : n < 21 ? 20 : n % 20;
            var fixedM = m < 0 ? 0 : m < 11 ? 10 : m < 21 ? 20 : m % 20;
            return fixedN + fixedM;
        }

        public int CalculateSomething_2(int n, int m)
        {
            var fixedN = FixValueForCalculate(n);
            var fixedM = FixValueForCalculate(m);
            return fixedN + fixedM;
        }

        private int FixValueForCalculate(int n)
        {
            return n < 0 ? 0 : n < 11 ? 10 : n < 21 ? 20 : n % 20;
        }

        public int CalculateSomething_3(int n, int m)
        {
            Func<int, int> fixValue = k => k < 0 ? 0 : k < 11 ? 10 : k < 21 ? 20 : k % 20;
            var fixedN = fixValue(n);
            var fixedM = fixValue(m);
            return fixedN + fixedM;
        }

        #endregion Methods version previous to C# 7

        #region Methods Version C# 7

        /// <summary>
        /// Local functions new version C# 7
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public int CalculateSomething_4(int n, int m)
        {
            var fixedN = fixValue(n);
            var fixedM = fixValue(m);
            return fixedN + fixedM;

            int fixValue(int k) => k < 0 ? 0 : k < 11 ? 10 : k < 21 ? 20 : k % 20;
        }

        #endregion Methods Version C# 7
    }
}