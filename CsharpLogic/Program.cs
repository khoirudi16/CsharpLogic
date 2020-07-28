using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Code By : Muhammad Khoirudin
             * Profesi : .Net Developer
             */
            #region 5. Armstrong Number
            //int number = 153;
            //bool is_armsrong = Armstrong.IsArmstrongWithoutString(number);
            //if (is_armsrong)
            //    Console.WriteLine(number + " : Yes");
            //else
            //    Console.WriteLine(number + " : No");
            #endregion

            #region 6. Factorial
            //int get_factorial = Factorial.GetFactorialByRecursive(5);
            //Console.WriteLine(get_factorial);
            #endregion

            #region 7. SumOfDigits
            //int digit = 1234;
            //Console.WriteLine(SumOfDigit.GetSumOfDigitByLinq(digit));
            #endregion

            #region 8. Decimal To Binary
            //string result = DecimalToBinary.ConvertDecimalToBinary(4);
            //Console.WriteLine(result);
            #endregion

            #region 9. Binnary To Decimal
            //int result_decimal = BinaryToDecimal.ConvertBinaryToDecimal(100);
            //Console.WriteLine(result_decimal);
            #endregion

            #region 10. Reverse String
            //string result_reverse = ReverseString.ReverseStringMethod("khoir");
            //Console.WriteLine(result_reverse);
            #endregion

            #region 11. Reverse Word
            //string result_word = ReverseWord.ReverseWordByLinq("Welcome To Dotnet Tutorials");
            //Console.WriteLine(result_word);
            #endregion

            #region 12. Remove Duplicate Char
            //Console.WriteLine(DuplicateCharacters.RemoveCharacterByLinq("Google"));
            #endregion

            #region 13. Possibility String Combination
            //foreach(var item in PossibleSubstring.PossibleStringNormal("ABC"))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 14. Array Rotation
            //int[] data = new int[6] { 1, 2, 3, 4, 5, 6 };
            //string left_rotate = Arrays.RightRotation(1, data);
            //Console.WriteLine(left_rotate);
            #endregion

            #region 15. Angle O'clock
            //double degree = AngleClock.FindAngleClockByMinutesHour(30, 9);
            //Console.WriteLine(degree);
            #endregion

            #region 16. Bubble Sort
            int[] data = new int[3] {3, 2, 1};
            string sort = BubbleSort.SortingByBubbleSort(data);
            Console.WriteLine(sort);
            #endregion

            Console.ReadKey();
        }
    }
}
