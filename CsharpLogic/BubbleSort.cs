using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class BubbleSort
    {
        public static string SortingByBubbleSort(int[] data)
        {
            // 5, 8, 7, 3, 1
            string result = string.Empty;

            for(int i = 0; i < data.Length - 1; i++)
            {
                for(int j = 0; j < data.Length; j++)
                {
                    int a = j < data.Length - 1 ? data[j] : data[j-1];
                    int b = j < data.Length - 1 ? data[j + 1] : data[j];

                    if(a > b) // 8 > 5
                    {
                        int temp = b;
                        data[j + 1] = a;
                        data[j] = temp;
                    }
                }
            }

            foreach(int i in data)
            {
                result += i + ", ";
            }

            return result;
        }
    }
}
