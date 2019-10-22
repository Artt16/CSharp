/// <summary>
/// ЭТО КЛАСС, КОТОРЫЙ  ПЕЧАТАЕТ одномерные int МАССИВЫ
/// </summary>
using System;
using System.Text;
namespace Tasks
{
    public static class Write

    { 
        public static void WriteArray(string text, int[] arr)
        {
            Console.WriteLine(text + ": ");
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();       
        }
        public static void Write_Arr(int num, char sym )
        {
            Console.Write(num + sym);
        }
        public static void WriteLine()
        {
            Console.WriteLine();
        }
        
    }
}
