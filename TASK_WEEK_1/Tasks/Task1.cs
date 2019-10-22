///<summary>
///Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа должна
///сосчитать количество введенных пользователем пробелов.
/// </summary>
using System;
using System.Collections.Generic;

namespace Tasks
{ 
    public static class Task1
    {
        public static void task1()
        {
            Console.WriteLine("\t\t*********************************************");
            Console.WriteLine("\t\t**************THIS IS TASK № 1!**************");
            Console.WriteLine("\t\t*********************************************");
            int count = 0;
            ConsoleKeyInfo Symbol;
            do
            {
                Console.WriteLine("Enter the symbol");
                Symbol = Console.ReadKey();
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("\t\t*********************************************");
                Console.WriteLine("\t\t**************THIS IS TASK № 1!**************");
                Console.WriteLine("\t\t*********************************************");
                if (Symbol.KeyChar == ' ')
                {
                    count++;
                }
                if (Symbol.KeyChar == '.')
                {
                    break;
                }
            } while (true);
            Console.WriteLine($"You're enter {count} spaces " );
            Console.WriteLine("\n\t\t*********************************************");
            Console.WriteLine("\t\t**************THE END TASK № 1!**************");
            Console.WriteLine("\t\t*********************************************\n\n\n");
        }        
    }
}