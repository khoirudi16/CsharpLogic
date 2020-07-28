using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class Arrays
    {
        public static string LeftRotation(int count, int[] data)
        {
            //1,2,3,4,5,6
            /*
             * 2,3,4,5,6,1
             * 3,4,5,6,1,2
             * 4,5,6,1,2,3
             */
            string result = "";

            int rotate = 0;
            if(count <= data.Length)
            {
                rotate = count;
            }
            else
            {
                rotate = count % data.Length;
            }

            int[] new_data = new int[data.Length];

            for(int i = 0; i < data.Length; i++)
            {
                /*
                 *index 0 = 3;
                 *index 1 = 4;
                 *index 2 = 5
                 * 
                 *index 3 = 6; -> 6 - 6 = 0
                 *index 4 = 7; -> 7 - 6 = 1
                 *index 5 = 8; -> 8 - 6 = 2
                 */

                if (i + rotate <= data.Length -1)
                {
                    new_data[i] = data[i + rotate];
                }
                else
                {
                    new_data[i] = data[i + rotate - data.Length];
                }
                
                
            }

            string res1 = "Data lama ";
            foreach(var item in data)
            {
                res1 += item + ",";
            }

            string res2 = " Hasilnya ";
            foreach(var item in new_data)
            {
                res2 += item + ",";
            }

            result = res1 + res2;

            return result;
        }

        public static string RightRotation(int count, int[] data)
        {
            string result = "";

            int rotate = count <= data.Length ? count : count % data.Length;

            int[] new_data = new int[data.Length];

            //1,2,3,4,5,6 , rotate = 2
            //5,6,1,2,3,4

            /*
             * length - rotate + i
             * index 0 = 6 - 2 + 0 -> 4 + 0 = 4
             * index 1 = 6 - 2 + 1 -> 4 + 1 = 5
             * index 2 = 6 - 2 + 2 -> 4 + 2 = 6 (0)
             * index 3 = 6 - 2 + 3 -> 4 + 3 = 7 (1)
             * index 4 = 6 - 2 + 4 -> 4 + 4 = 8 (2)
             * index 5 = 6 - 2 + 5 -> 4 + 5 = 9 (3)
             */

            for(int i = 0; i < data.Length; i++)
            {
                if(data.Length - rotate + i <= data.Length - 1)
                {
                    new_data[i] = data[data.Length - rotate + i];
                }
                else
                {
                    new_data[i] = data[(data.Length - rotate + i) - data.Length];
                }
            }

            string res1 = "Data lama ";
            foreach (var item in data)
            {
                res1 += item + ",";
            }

            string res2 = " Hasilnya ";
            foreach (var item in new_data)
            {
                res2 += item + ",";
            }

            result = res1 + res2;


            return result;
        }

    }
}
