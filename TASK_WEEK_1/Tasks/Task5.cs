///<summary>
///Дано целое число N (> 0), найти число, полученное при
///прочтении числа N справа налево.Например, если было
///введено число 345, то программа должна вывести число 543.
/// </summary>
using System;
using System.Text;

namespace Tasks
{
    public class Task5
    {
        public static void task5()
        {
            int num, result = 0;
            string str;
            str = Console.ReadLine();
            if(Int32.TryParse(str, out num))
            {
                str = "";
                while(num!=0)
                {
                    str += num % 10;
                    num = num / 10;
                }
                Console.WriteLine();
                if (Int32.TryParse(str, out result))
                {
                    Console.WriteLine(result + " Type: " + result.GetType());
                }
            }
        }
    }
}
