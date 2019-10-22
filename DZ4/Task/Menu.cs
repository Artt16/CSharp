using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Menu
    {
        public int Choice;
        public int Choice_action;
        private bool flag = true;
        private bool flag_action = true;

        public void My_menu()
        {
            Console.WriteLine(@"Enter the Cash1 x,xx:");
            double money1, money2;
            int num;
            Double.TryParse(Console.ReadLine(), out money1);
           
            Money cash1 = new Money(money1);
            
            Money cash3;
            do
            {
                Console.Write(" \n***Choise a menu item:\n *1. To solve a task! \n *2. Exit out the program \n ");
                Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                    {
                        do
                        {
                            Console.Write(" \n***Choise a menu item:\n *1. Summation \n " +
                                "*2. Subtraction Amount \n *3. Multiplication by an integer \n " +
                                "*4. Integer division \n *5. Increment \n *6. Decriment. \n" +
                                " *7. Equality test. \n *8. Unequality test. \n" +
                                " *9. Come back. \n");
                            Choice_action = int.Parse(Console.ReadLine());
                            switch (Choice_action)
                            {
                                case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter the sum for sum x,xx:");
                                            Double.TryParse(Console.ReadLine(), out money2);
                                            Money cash2 = new Money(money2);
                                            cash3 = cash1 + cash2;
                                            Console.WriteLine("Cash1 + Cash2 = " + "{0:0.##}", cash3.Grivna);
                                            break;
                                        }
                                    case 2: 
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter the sum for diff x,xx:");
                                            Double.TryParse(Console.ReadLine(), out money2);
                                            Money cash2 = new Money(money2);
                                            cash3 = cash1 - cash2;
                                            if (cash3.Grivna > 0)
                                            {
                                                Console.WriteLine("Cash1 - Cash2 = " + "{0:0.##}", cash3.Grivna);
                                            }
                                            else { throw new Bankrupt(); }                                           
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter integer");
                                            int.TryParse(Console.ReadLine(), out num);
                                            cash3 = cash1 * num;
                                            Console.WriteLine($"Cash1 * {num} = {cash3.Grivna.ToString("F" + 2)}");
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter integer");
                                            int.TryParse(Console.ReadLine(), out num);
                                            cash3 = cash1 / num;
                                            if (cash3.Grivna > 0)
                                            { 
                                                Console.WriteLine($"Cash1 / {num} = {cash3.Grivna.ToString("F" + 2)}");
                                            }
                                            else { throw new Bankrupt(); }
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.Clear();
                                            cash3 = cash1++;
                                            Console.WriteLine($"Cash1++ = {cash3.Grivna}");
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.Clear();
                                            cash3 = cash1--;
                                            Console.WriteLine($"Cash1-- = {cash3.Grivna}");
                                            break;
                                        }
                                    case 7:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter the cash2 x,xx: ");
                                            Double.TryParse(Console.ReadLine(), out money2);
                                            Money cash2 = new Money(money2);
                                            Console.WriteLine($"Cash1 == Cash2 : {cash1 == cash2}");
                                            break;
                                        }
                                    case 8:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter the cash2 x,xx: ");
                                            Double.TryParse(Console.ReadLine(), out money2);
                                            Money cash2 = new Money(money2);
                                            Console.WriteLine($"Cash1 != Cash2 : {cash1 != cash2}");
                                            break;
                                        }
                                    case 9: flag_action = false; break;
                                default: Console.Clear(); Console.WriteLine(" no such menu point "); break;
                            }
                        }
                        while (flag_action == true);
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