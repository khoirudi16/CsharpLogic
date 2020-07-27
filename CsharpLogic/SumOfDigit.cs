using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class SumOfDigit
    {
        public static int GetSumOfDigitByLooping(int number)
        {
            int sum = 0, reminder;
            
            while(number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }

            return sum;
        }

        public static int GetSumOfDigitByRecursion(int number) //1234 = 10
        {
            int sum = 0;
            if(number != 0)
            {
                sum = (number % 10) + GetSumOfDigitByRecursion(number / 10);
            }
            else
            {
                return 0;
            }

            return sum;
        }

        public static int GetSumOfDigitByLinq(int number)
        {
            string str_number = number.ToString();
            var y = str_number.Select(x => int.Parse(x.ToString()));
            

            List<int> number_list = number.ToString().Select(x => int.Parse(x.ToString())).ToList();
            int sum = number_list.Sum();

            return sum;
        }

    }
}
