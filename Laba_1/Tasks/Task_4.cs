/// <summary>
/// Подсчитать количество слов во введенном предложении. 
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tasks
{
    public static class Task_4
    {
        public static void task4()
        {
            Console.WriteLine("\t\t*********************************************");
            Console.WriteLine("\t\t**************THIS IS TASK № 4!**************");
            Console.WriteLine("\t\t*********************************************");
            Console.WriteLine("\n\n***Enter the string: ");
            string sentence = Console.ReadLine();
            string[] sen = sentence.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Number of the words in your sentence = " + sen.Length);
            Console.WriteLine("\n\t\t*********************************************");
            Console.WriteLine("\t\t**************THE END TASK № 4!**************");
            Console.WriteLine("\t\t*********************************************\n\n\n");
        }

    }
}
