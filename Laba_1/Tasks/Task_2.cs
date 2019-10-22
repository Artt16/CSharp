/// <summary>
/// Даны 2 массива размерности M и N соответственно.
///
///Необходимо:
///переписать в третий массив общие элементы первых двух массивов без повторений.
/// </summary>

using System;
using System.Linq;
namespace Tasks
{
    public static class Task_2
    {
        public static void task2()
        {
            Console.WriteLine("\t\t*********************************************");
            Console.WriteLine("\t\t**************THIS IS TASK № 2!**************");
            Console.WriteLine("\t\t*********************************************");
            Console.WriteLine("***Enter the sizes of arrays: ");
            Console.WriteLine("***Enter the size of array М: ");
            int check = 0;
            int sizeN = 0;
            int sizeM = 0;
            if (Int32.TryParse(Console.ReadLine(), out check))
            {
                sizeM = check;
            }
            Console.WriteLine("***Enter the size of array N: ");
            if (Int32.TryParse(Console.ReadLine(), out check))
            {
                sizeN = check;
            }
            Random rnd = new Random();
            int count = 0;
            int size_MN = 0;
            int[] M = new int[sizeM];
            int[] N = new int[sizeN];
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = rnd.Next(15);
            }
            for (int i = 0; i < N.Length; i++)
            {
                N[i] = rnd.Next(15);
                for (int j = 0; j < M.Length; j++)
                {
                    if (N[i] == M[j])
                    {
                        count++;
                    }
                }
            }
            Write.WriteArray("***Array M: ", M);
            Write.WriteArray("***Array N: ", N);
            if (count != 0)
            {
                int[] MN = new int[count];                
                for (int i = 0; i < N.Length; i++)
                {
                    for (int j = 0; j < M.Length; j++)
                    {
                        if ((N[i] == M[j]) && (!MN.Contains(N[i])))
                        {
                            MN[size_MN] = N[i];
                            size_MN++;
                        }
                    }
                }               
                Array.Resize(ref MN, size_MN);
                Write.WriteArray("***Array MN: ", MN);
            }
            else
            {
                Console.WriteLine("***No same elements!***");
            }
            Console.WriteLine("\n\t\t*********************************************");
            Console.WriteLine("\t\t**************THE END TASK № 2!**************");
            Console.WriteLine("\t\t*********************************************\n\n\n");
        }      
    }
}