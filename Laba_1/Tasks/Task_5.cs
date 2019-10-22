///<summary>
/// Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
///
/// Определить:
/// сумму элементов массива, расположенных между минимальным и максимальным элементами.
/// </summary>

using System;
using System.Linq;
namespace Tasks
{
    public static class Task_5
    {
        public static void task5()
        {
            Console.WriteLine("\t\t*********************************************");
            Console.WriteLine("\t\t**************THIS IS TASK № 5!**************");
            Console.WriteLine("\t\t*********************************************");          
            int[,] Arr = new int[5, 5];
            int sum = 0, max = Arr[0, 0], min = Arr[0, 0];
            int row_max = 0, col_max = 0, row_min = 0, col_min = 0;
            bool count = false;
            Random rand = new Random();
            Console.WriteLine("***Array B");
                for (int i = 0; i < Arr.GetLength(0); i++)
                {
                    for (int j = 0; j < Arr.GetLength(1); j++)
                    {
                    Arr[i, j] = rand.Next(-100, 100);
                        if (max < Arr[i, j])
                        {
                            max = Arr[i, j];
                            row_max = i;
                            col_max = j;
                        }
                        if (min > Arr[i, j])
                        {
                            min = Arr[i, j];
                            row_min = i;
                            col_min = j;
                        }
                      Console.Write(Arr[i, j]+"\t");
                    }
                Console.WriteLine();
                }          
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if ((i == row_max && j == col_max) || (i == row_min && j == col_min))
                    {
                        if (count)
                        {
                            count = false;
                            continue;
                        }
                        else
                        {
                            count = true;
                            continue;
                        }
                    }
                    if (count)
                    {
                        sum += Arr[i, j];
                    }
                }
            }
                Console.WriteLine();
                Console.WriteLine("Max element in Arr = " + max);
                Console.WriteLine("Min element in Arr = " +min);
                Console.WriteLine("Max element located " + Arr.Cast<int>().Max() + " in row "+ (row_max + 1)+ " col "+ (col_max + 1));
                Console.WriteLine("Мin element located " + Arr.Cast<int>().Min() + " in row "+ (row_min + 1)+ " col "+ (col_min + 1));
                Console.WriteLine("Sum of elements of array, between min & max = "+ sum);
                Console.WriteLine("\n\t\t*********************************************");
                Console.WriteLine("\t\t**************THE END TASK № 5!**************");
                Console.WriteLine("\t\t*********************************************\n\n\n");
        }
    } 
}
