using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
            => Console.WriteLine(Score(new int[] { 1, 1, 2, 4, 5 }));
        public static int Score(int[] dice)
        {
            int result = 0, num;

            try
            {
                num = dice.GroupBy(n => n).Where(n => n.Count() >= 3).Select(n => n.Key).First();
            }
            catch
            {
                num = 0;
            }
            if (num != 1)
                result = num * 100;
            if (num == 1)
                result += 1000;
            int temp = 0;
            if (num == 5 || num == 1)
                temp = Counter(dice, num);
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == 1 && temp > 3 && num == 1 || dice[i] == 1 && num != 1)
                {
                    result += 100;
                    temp--;
                }
                if ((dice[i] == 5 && temp > 3 && num == 5) || (dice[i] == 5 && num != 5))
                {
                    result += 50;
                    temp--;
                }
            }           
            return result;                     
        }
        public static int Counter(int [] arr, int num)
        {
            int count = 0;
            if(num == 5)
                foreach (int i in arr)
                    if (i == num)
                        count++;
            if (num == 1)
                foreach (int i in arr)
                    if (i == num)
                        count++;
            return count;
        }

    }
}
