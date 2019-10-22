///<summary>
///Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на
///величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует 
///все символы нижнего регистра в символы верхнего регистра и наоборот.
/// </summary>
using System;
using System.Text;

namespace Tasks
{
    public class Task3
    {
        
        public static void task3()
        {
            ConsoleKeyInfo symbol;
            
           
            do
            {
                symbol = Console.ReadKey();
                Console.WriteLine("\n" + Task3_res.entered + symbol.KeyChar);
                
                if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
                {
                    
                    if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
                    {
                       
                        Console.WriteLine(Task3_res.result + char.ToLower(Convert.ToChar(symbol.KeyChar)));
                    }
                    else
                    {                       
                        Console.WriteLine(Task3_res.result + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
                    }
                }
                else
                {
                    Console.WriteLine(Task3_res.wrong);
                }
                if (Convert.ToInt32(symbol.KeyChar) == 27)
                {
                    break;
                }
            }
            while (true);
        }
    }
                
}


