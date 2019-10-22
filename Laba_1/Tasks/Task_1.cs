///<summary>
///
/// Объявить:
/// одномерный(5 элементов)массив с именем A,
/// двумерный массив(3 строки, 4 столбца) дробных чисел с именем B.
///
/// Заполнить:
/// одномерный массив А числами, введенными с клавиатуры пользователем,
/// а двумерный массив В случайными числами с помощью циклов.
///
/// Вывести на экран значения массивов: 
/// массива А в одну строку,
/// массива В — в виде матрицы.
///
/// Найти в данных массивах:
/// общий максимальный элемент, 
/// минимальный элемент, 
/// общую сумму всех элементов, 
/// общее произведение всех элементов, 
/// сумму четных элементов массива А, 
/// сумму нечетных столбцов массива В.
///
///</summary>



using System;
using System.Linq;
using System.Text;

namespace Tasks
{
    public static class Task_1
    {
        public static void task1()
        {
            Console.WriteLine("\t\t*********************************************");
            Console.WriteLine("\t\t**************THIS IS TASK № 1!**************");
            Console.WriteLine("\t\t*********************************************");
            Random rnd = new Random();
            double[,] B = new double[3, 4];
            double[] A = new double[5];
            double sum_A = 0, sum_B = 0;
            double prod_of_vals = 1;
            double even_A = 0, uneven_B = 0; 
            double check, max_A = 0, max_B = 0, min_A = 10, min_B = 10;
            int length_B_row = B.GetLength(0);
            int length_B_col = B.GetLength(1);            
            Console.WriteLine("***Enter 5 nums for Array A:"); 
            for (var k = 0; k < A.Length; k++)
            {
                if(Double.TryParse(Console.ReadLine(),out check))
                {
                    A[k] = check;
                }

            }
            Console.WriteLine("***It's Array A: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i] + "\t");
                if (A[i] % 2 == 0)
                {
                    even_A += A[i];
                }
                if (A[i] != 0)
                {
                    prod_of_vals *= A[i];
                }
            }
            Console.WriteLine("\n\n"+"***It's Array B: ");     
            for (int i = 0; i < length_B_row; i++)
            {
                for (int j = 0; j < length_B_col; j++)
                {
                    B[i, j] = rnd.Next(0, 1001) / 100.0;
                    Console.Write(B[i, j]+ "\t");
                    if ((j+1) % 2 != 0)
                    {
                        uneven_B += B[i, j];
                    }
                    if (B[i, j] != 0)
                    {
                        prod_of_vals *= B[i, j];
                    }

                }
                Console.WriteLine("\n");
            }
            Console.Write("***Maximal value in Array A: ");
            for(int i =0; i<A.Length; i++)
            {
                if(max_A<A[i])
                {
                    max_A = A[i];
                }
            }
            Console.Write(max_A + "\n");
            Console.Write("***Minimal value in Array A: ");
            for (int i = 0; i < A.Length; i++)
            {
                if (min_A > A[i])
                {
                    min_A = A[i];
                }
            }
            Console.Write(min_A + "\n");
            Console.Write("***Maximal value in Array B: " );
            for(int i = 0; i< length_B_row; i++)
            {
                for(int j =0; j< length_B_col; j++)
                {
                    if(max_B < B[i,j])
                    {
                        max_B = B[i, j];
                    }
                }
            }
            Console.Write(max_B + "\n");
            Console.Write("***Minimal value in Array B: ");
            for (int i = 0; i < length_B_row; i++)
            {
                for (int j = 0; j < length_B_col; j++)
                {
                    if (min_B > B[i, j])
                    {
                        min_B = B[i, j];
                    }
                }
            }
            Console.Write(min_B + "\n");
            if (max_A>max_B)
            {
                Console.WriteLine("***Maximum element of A & B arrays: " + max_A);
            }
            else
            {
                Console.WriteLine("***Maximum element of A & B arrays: " + max_B);
            }
            if(min_A < min_B)
            {
                Console.WriteLine("***Same minimum element of A & B arrays: " + min_A);
            }
            else
            {
                Console.WriteLine("***Same minimum element of A & B arrays: " + min_B);
            }
            Console.Write("***The sum of all values in the Array A = ");
            for(int i = 0; i < A.Length;i++)
            {
                sum_A += A[i];
            }
            Console.Write(sum_A + "\n");
            Console.Write("***The sum of all values in the Array B = ");
            for (int i = 0; i < length_B_row; i++)
            {
                for (int j = 0; j < length_B_col; j++)
                {
                    sum_B += B[i, j];
                }
            }
            Console.Write(sum_B + "\n");
            Console.WriteLine("***The sum of all values in the Arrays A & B = " + (sum_A +sum_B));
            Console.WriteLine("***Composition of all values in the Arrays A & B = " + prod_of_vals);
            Console.WriteLine("***Sum of even values in the Array A = " + even_A);
            Console.WriteLine("***Sum of uneven values in the Array B = " + uneven_B);

            Console.WriteLine("\n\t\t*********************************************");
            Console.WriteLine("\t\t**************THE END TASK № 1!**************");
            Console.WriteLine("\t\t*********************************************\n\n\n");
            StringBuilder sb = new StringBuilder();
            sb.Append("Maximal elements" + (max_A));
        }
    }
}
