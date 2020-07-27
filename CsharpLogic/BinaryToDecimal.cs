using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class BinaryToDecimal
    {
        public static int ConvertBinaryToDecimal(int binaryNumber)
        {
            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            return decimalValue;
        }
    }
}
