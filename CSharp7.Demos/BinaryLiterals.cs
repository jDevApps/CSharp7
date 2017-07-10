using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7.Demos
{
    public class BinaryLiterals
    {
        #region Methods version C# 7

        /// <summary>
        /// New way of defining binary and numerical variables
        /// </summary>
        public void SetBinaries()
        {
            var binary = 0b101010111100110111101111;
            var binary2 = 0b1010_1011_1100_1101_1110_1111;

            var dec = 999_999;
            var hex = 0xFF_FF_FF;

            Console.WriteLine(123_456 == 1_2_3_4_5_6); // True
            Console.WriteLine(0b1111_1111_1111_1111 == 0xFF_FF); // True
        }

        #endregion Methods version C# 7
    }
}