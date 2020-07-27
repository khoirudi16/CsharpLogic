using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class PossibleSubstring
    {
        public static List<string> PossibleStringNormal(string str)
        {
            List<string> list_result = new List<string>();
            char[] char_str = str.ToUpper().ToCharArray();
            string char_combine = string.Empty;

            for(int i = 0; i < char_str.Count(); i++)
            {
                for(int j = i; j < char_str.Count(); j++)
                {
                    if(char_str[i] == char_str[j])
                    {
                        char_combine = char_str[i].ToString();
                    }
                    else
                    {
                        char_combine = char_str[i].ToString() + char_str[j].ToString();
                    }

                    if(!list_result.Contains(char_combine))
                    {
                        list_result.Add(char_combine);
                    }
                }
            }

            return list_result;
        }
    }
}
