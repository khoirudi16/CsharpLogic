using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class DecimalToBinary
    {
        public static string ConvertDecimalToBinary(int decNumber)
        {
            string result = "";
            
            for (int i = 0; decNumber > 0; i++)
            {
                result = decNumber % 2 + result;
                decNumber = decNumber / 2;
            }

            return result;
        }
    }
}
