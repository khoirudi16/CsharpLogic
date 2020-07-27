using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class Factorial
    {
        public static int GetFactorial(int number)
        {
            int result = 1;

            int i = 1;
            while(i <= number)
            {
                result *= i;
                i++;
            }

            return result;
        }

        public static int GetFactorialByRecursive(int number)
        {
            if(number == 1)
            {
                return 1;
            }
            else
            {
                return number * GetFactorialByRecursive(number - 1);
            }
        }
    }
}
