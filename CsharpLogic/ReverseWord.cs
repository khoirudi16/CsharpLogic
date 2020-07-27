using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class ReverseWord
    {
        public static string ReverseWordNormal(string word)
        {
            string result = string.Empty;

            foreach(string s in word.Split(' '))
            {
                string reverse = string.Empty;
                foreach(char c in s)
                {
                    reverse = c + reverse;
                }

                result = result == string.Empty ? reverse : result + " " + reverse;
            }

            return "Reverse from " + word + " is " + result;
        }

        public static string ReverseWordByStack(string word)//abcde
        {
            string result = string.Empty;
            string reverse = string.Empty;

            Stack<char> stc_char = new Stack<char>();

            foreach(char s in word)
            {
                stc_char.Push(s);
            }

            while(stc_char.Count > 0)
            {
                reverse = reverse + stc_char.Pop();
            }

            foreach(string s in reverse.Split(' '))
            {
                result = s + " " + result;
            }
            

            return result;
        }

        public static string ReverseWordByLinq(string word)
        {
            string result = string.Join(" ", word.Split(' ').Select(x => new String(x.Reverse().ToArray())));

            return result;
        }

    }
}
