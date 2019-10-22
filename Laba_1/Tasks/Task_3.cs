/// <summary>
///Пользователь вводит строку.
///
///Проверить:
///является ли эта строка палиндромом.
/// 
///Палиндромом называется строка, которая одинаково читается слева направо и справа налево.
/// </summary>

using System;
using System.Linq;
namespace Tasks
{
    public static class Task_3
    {
        public static void task3()
        {
            Console.WriteLine("\t\t*********************************************");
            Console.WriteLine("\t\t**************THIS IS TASK № 3!**************");
            Console.WriteLine("\t\t*********************************************");
            Console.WriteLine("***Enter a string to check for polindrome: ");
            string str = Console.ReadLine();
            int count = 0;
            str.Reverse();
            char[] Arr_str = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                Arr_str[count] = str[i];
                count++;
            }
            string output = new string(Arr_str);
            Console.WriteLine(str);
            str = output;
            output = new string(output.ToCharArray().Reverse().ToArray());
            if (String.Compare(str, output, true) == 0)
            {
                Console.WriteLine("***String is a palindrome!");
            }
            else
            {
                Console.WriteLine("String isn't a palindrome!");
            }
            Console.WriteLine("\n\t\t*********************************************");
            Console.WriteLine("\t\t**************THE END TASK № 3!**************");
            Console.WriteLine("\t\t*********************************************\n\n\n");
        }
    }
}
