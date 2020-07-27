using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class ReverseString
    {
        public static string ReverseStringResult(string str)
        {
            string reverse = String.Empty;

            for(int i = str.Length-1; i >= 0; i--)
            {
                reverse += str[i];
            }

            return reverse;
        }

        public static string ReverseStringForEach(string str)
        {
            string reverse = String.Empty;

            foreach(char c in str)
            {
                reverse = c + reverse;
            }

            return reverse;
        }

        public static string ReverseStringMethod(string str)
        {
            char[] char_str =  str.ToCharArray();
            Array.Reverse(char_str);

            return new string(char_str);
        }

        
    }
}
