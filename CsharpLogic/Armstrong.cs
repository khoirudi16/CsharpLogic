using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class Armstrong
    {
        public static bool IsArmstrong(int number)
        {
            bool is_armstrong = false;
            double result = 0;
            string str_number = Convert.ToString(number);

            foreach(char item in str_number)
            {
                result += Math.Pow((double)int.Parse(item.ToString()),(double)str_number.Length) ;
            }

            if(result.Equals(number))
            {
                is_armstrong = true;
            }

            return is_armstrong;
        }

        public static bool IsArmstrongWithoutString(int number)
        {
            int natural_number = number;
            int sum = 0, reminder;
            int length_digit = Convert.ToString(number).Length;

            while(number > 0)
            {
                reminder = number % 10;
                sum += (int)Math.Pow(reminder, length_digit);
                number = number / 10;
            }

            return natural_number == sum ? true : false;
        }
    }
}
