using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class DuplicateCharacters
    {
        public static string RemoveCharacterSimple(string str)
        {
            string result = string.Empty;
            List<char> char_str = new List<char>();

            foreach(char c in str)
            {
                char cLower = Convert.ToChar(c.ToString().ToLower());
                if (!char_str.Contains(cLower))
                {
                    char_str.Add(cLower);
                }
            }

            result = new string(char_str.ToArray());

            return result;
        }

        public static string RemoveCharacterByHash(string str)
        {
            string result = string.Empty;
            HashSet<char> char_str = new HashSet<char>();

            foreach (char c in str)
            {
                char cLower = Convert.ToChar(c.ToString().ToLower());
                char_str.Add(cLower);
            }

            result = new string(char_str.ToArray());

            return result;
        }

        public static string RemoveCharacterByLinq(string str)
        {
            /*
             * 1. Convert string to Char Array
             * 2. Char array will be distinct
             * 3. char array will be stored into array form
             * 4. Convert array to string
             */
            char[] char_data = str.ToLower().ToCharArray().Distinct().ToArray();

            return new string(char_data);
            
        }

    }
}
