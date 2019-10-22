using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public static class Menu
    {
        public static void My_menu()
        {
            int choice;
            int choice_task;
            bool flag = true;
            bool flag_task = true;
            do
            {
                Console.Write(" \n***Choise a menu item:\n *1. To solve a task! \n *2. Exit out the program \n ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            do
                            {
                                Console.Write(" \n***Choise a menu item:\n *1. Task 1 \n *2. Task 2 \n *3. Task 3 \n *4. Task 4 \n" +
                                " *5. Task 5 \n *6. Task 6 \n *7. Exit to previous menu. \n");
                                choice_task = int.Parse(Console.ReadLine());
                                switch (choice_task)
                                {
                                    case 1:
                                        Console.Clear();
                                        Task1.task1();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Task2 t2 = new Task2();
                                        Console.WriteLine(t2);
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Task3.task3();
                                        Task3 t3 = new Task3();
                                        Console.WriteLine(t3);
                                        break;
                                    case 4:
                                        Console.Clear();
                                        Task4.task4();
                                        break;
                                    case 5:
                                        Console.Clear();
                                        Task5.task5();
                                        break;
                                    case 6:
                                        Task6_Iron iron1 = new Task6_Iron();
                                        Task6_Iron iron2 = new Task6_Iron("Braun");
                                        Task6_Iron[] irons = new Task6_Iron[5];
                                        for (int i = 0; i < irons.Length; i++)
                                        {
                                            irons[i] = new Task6_Iron("Vitec");
                                        }
                                        break;
                                    case 7: flag_task = false; break;
                                    default: Console.Clear(); Console.WriteLine(" no such menu point "); break;
                                }
                            }
                            while (flag_task == true);
                            break;
                        }
                    case 2: { flag = false; Console.Clear(); break; }
                    default: { Console.Clear(); Console.WriteLine(" no such menu point"); break; }
                }
            }
            while (flag == true);
        }
    }
}

