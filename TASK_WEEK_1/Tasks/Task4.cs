///<summary>
///Даны целые положительные числа A и B (A < B) 
///Вывести все целые числа от A до B включительно; каждое число
///должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его
///значению.Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
///3 3 3
///4 4 4 4
///5 5 5 5 5
///6 6 6 6 6 6
///7 7 7 7 7 7 7
/// </summary>
using System;
namespace Tasks
{
    public class Task4
    {
        public static int a = 0, b = 0,A,B;
        public static void task4()
        {            
            Console.WriteLine("Enter a & b");
            if (Int32.TryParse(Console.ReadLine(), out a))// { }
            if (Int32.TryParse(Console.ReadLine(), out b)) //{ }
            A = a;
            B = b;
            if(A<B)
            {
                while(A<=B)
                {
                    print();
                    A++;
                    a++;
                }
            }
            else
            {
                while (A >= B)
                {
                    print();
                    A--;
                    a--;
                }
            }
        }
        
        public static void print()
        {
            int count = 1;
            while (count<=A)
            {
                Console.Write(a + " ");
                count++;
            }
            Console.WriteLine();
        }
    }
}
