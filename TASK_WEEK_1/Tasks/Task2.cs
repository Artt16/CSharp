///<summary>
///Ввести с клавиатуры номер трамвайного билета (6-значноечисло) и про-верить является ли данный билет счастливым
///(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот
///билет считается счастливым).
/// </summary>
using System;
using System.Text;
namespace Tasks
{
    public class Task2
    {
        int num, temp, sum1 = 0, sum2 = 0, count = 0, number;
        private bool IsHappyTicket { get; set; }
        private bool IsCorrect { get; set; }
        public void task2()
        {
            ToString();
        }        
        public void Check()
        {           
            if (Int32.TryParse(Console.ReadLine(), out num))
            {
                number = num;
                while (count < 3)
                {
                    temp = (num % 10);
                    sum1 += temp;
                    num = num / 10;
                    count++;
                }
                while (count < 6)
                {
                    temp = (num % 10);
                    sum2 += temp;
                    num = num / 10;
                    count++;
                }
                if (num % 10 > 0 ||number < 100000)
                {
                    IsCorrect = false;
                }
                else
                {
                    IsCorrect = true;
                    if (sum1 == sum2)
                    {
                        IsHappyTicket = true;
                    }
                    else
                    {
                        IsHappyTicket = false;
                    }
                }
            }
        }        
        public override string ToString()
        {            
            var sb = new StringBuilder();
            sb.Append(Task2_res.title +'\n');
            sb.Append(Task2_res.condition_2 + '\n');
            Check();
            sb.Append(IsCorrect ? Task2_res.entered + number + '\n' : Task2_res.entered + number + '\n' + Task2_res.wrong + '\n');
            if (IsCorrect)
            {
                sb.Append(IsHappyTicket ? Task2_res.happy + '\n' : Task2_res.not_happy + '\n');
            }
            sb.Append(Task2_res.end + '\n');
            return sb.ToString();
        }
    }
}