using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace SelectionStatments
{
    public static class Statements
    {
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine($"Number {first} is the largest");
                }
                else
                {
                    Console.WriteLine($"Number {third} is the largest");
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine($"Number {second} is the largest");
                }
                else
                {
                    Console.WriteLine($"Number {third} is the largest");
                }
            }
        }

        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            if (first > second)
            {
                Console.WriteLine($"Number {(first > third ? first : third)} is the largest");
            }
            else
            {
                Console.WriteLine($"Number {(second > third ? second : third)} is the largest");
            }
        }

        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            if (first > second && first > third)
            {
                Console.WriteLine($"Number {first} is the largest");
            }
            else if (second > first && second > third)
            {
                Console.WriteLine($"Number {second} is the largest");
            }
            else
            {
                Console.WriteLine($"Number {third} is the largest");
            }
        }

        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            if (userAge < 21)
            {
                if (userAge >= 18)
                {
                    Console.WriteLine("You're old enough to drive.");
                }
                else
                {
                    Console.WriteLine("You are too young to drive, drink, or retire.");
                }
            }
            else
            {
                if (userAge < 65)
                {
                    if (userAge >= 21)
                    {
                        Console.WriteLine("Fancy an alcoholic beverage?");
                    }
                }
                else
                {
                    if (userAge >= 65)
                    {
                        Console.WriteLine("Enjoy your retirement!");
                    }
                }
            }
        }

        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            if (countOfDailyDownloads <= 0)
            {
                Console.WriteLine("No downloads.");
            }
            else if (countOfDailyDownloads < 100)
            {
                if (countOfDailyDownloads > 0)
                {
                    Console.WriteLine("Daily downloads: 1-100.");
                }
            }
            else if (countOfDailyDownloads < 1000)
            {
                if (countOfDailyDownloads >= 100)
                {
                    Console.WriteLine("Daily downloads: 100-1,000.");
                }
            }
            else if (countOfDailyDownloads < 10000)
            {
                if (countOfDailyDownloads >= 1000)
                {
                    Console.WriteLine("Daily downloads: 1,000-10,000.");
                }
            }
            else if (countOfDailyDownloads < 100000)
            {
                if (countOfDailyDownloads >= 10000)
                {
                    Console.WriteLine("Daily downloads: 10,000-100,000.");
                }
            }
            else
            {
                Console.WriteLine("Daily downloads: 100,000+.");
            }
        }    
                
        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            if (dayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("The first day of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("The middle of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("The middle of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine("The middle of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("The last day of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("The weekend.");
            }
            else if (dayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("The weekend.");
            }
        }

        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("The first day of the work week."); break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("The middle of the work week."); break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("The middle of the work week."); break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("The middle of the work week."); break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week."); break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("The weekend."); break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("The weekend."); break;
                default: break;
            }                
        }

        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            if (arg is int)
            {
                return $"{arg} is int.";
            }
            
            if (arg is uint)
            {
                return $"{arg} is uint.";
            }
            
            if (arg is byte)
            {
                return $"{arg} is byte.";
            }
            
            if (arg is sbyte)
            {
                return $"{arg} is sbyte.";
            }
            
            if (arg is short)
            {
                return $"{arg} is short.";
            }
            
            if (arg is long)
            {
                return $"{arg} is long.";
            }
            
            if (arg is ushort)
            {
                return $"{arg} is ushort.";
            }

            if (arg is ulong)
            {
                return $"{arg} is ulong.";
            }
            else
            {
                return $"{arg} is not integer.";
            }
        }

        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            switch (arg)
            {
                case sbyte obj:
                    return $"{obj} is sbyte.";
                case byte obj:
                    return $"{obj} is byte.";
                case short obj:
                    return $"{obj} is short.";
                case int obj:
                    return $"{obj} is int.";
                case long obj:
                    return $"{obj} is long.";
                case ushort obj:
                    return $"{obj} is ushort.";
                case uint obj:
                    return $"{obj} is uint.";
                case ulong obj:
                    return $"{obj} is ulong.";
                default:
                    return $"{arg} is not integer.";
            }
        }

        public static string GetTypeOfIntegerWithSwitchExpression(object arg)
        {
            string result = arg switch
            {
                sbyte obj => $"{obj} is sbyte.",
                byte obj => $"{obj} is byte.",
                short obj => $"{obj} is short.",
                int obj => $"{obj} is int.",
                long obj => $"{obj} is long.",
                ushort obj => $"{obj} is ushort.",
                uint obj => $"{obj} is uint.",
                ulong obj => $"{obj} is ulong.",
                _ => $"{arg} is not integer.",
            };

            return result;
        }

        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            switch (month)
            {
                case Month.December:
                case Month.January:
                case Month.February:
                    Console.WriteLine("It's winter now."); break;

                case Month.March:
                case Month.April:
                case Month.May:
                    Console.WriteLine("It's spring now."); break;

                case Month.June:
                case Month.July:
                case Month.August:
                    Console.WriteLine("It's summer now."); break;

                case Month.September:
                case Month.October:
                case Month.November:
                    Console.WriteLine("It's autumn now."); break;

                default:
                    Console.WriteLine("Sorry, the month was entered incorrectly."); break;
            }
        }

        public static byte GetLengthWithCascadedIfElse(int number)
        {
            if (number < 0)
            {
                number *= -1;
            }

            if (number % 10 < 10)
            {
                return 1;
            }
            else if (number % 100 < 10)
            {
                return 2;
            }
            else if (number % 1000 < 10)
            {
                return 3;
            }
            else if (number % 10000 < 10)
            {
                return 4;
            }
            else if (number >= 10000 && number < 100000)
            {
                return 5;
            }
            else if (number >= 100000 && number < 1000000)
            {
                return 6;
            }
            else if (number >= 1000000 && number < 10000000)
            {
                return 7;
            }
            else if (number >= 10000000 && number < 100000000)
            {
                return 8;
            }
            else if (number >= 100000000 && number < 1000000000)
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }                                    
                                
        public static byte GetLengthWithSwitchExpression(int number)
        {
            if (number < 0)
            {
                number *= -1;
            }

            byte result = number switch
            {
                int x when x >= 0 && x < 10 => 1,
                int x when x >= 10 && x < 100 => 2,
                int x when x >= 100 && x < 1000 => 3,
                int x when x >= 1000 && x < 10000 => 4,
                int x when x >= 10000 && x < 100000 => 5,
                int x when x >= 100000 && x < 1000000 => 6,
                int x when x >= 1000000 && x < 10000000 => 7,
                int x when x >= 10000000 && x < 100000000 => 8,
                int x when x >= 100000000 && x < 1000000000 => 9,
                _ => 10,
            };

            return result;
        }

        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            if (month == 1)
            {
                return Month.January;
            }

            if (month == 2)
            {
                return Month.February;
            }

            if (month == 3)
            {
                return Month.March;
            }

            if (month == 4)
            {
                return Month.April;
            }

            if (month == 5)
            {
                return Month.May;
            }

            if (month == 6)
            {
                return Month.June;
            }

            if (month == 7)
            {
                return Month.July;
            }

            if (month == 8)
            {
                return Month.August;
            }

            if (month == 9)
            {
                return Month.September;
            }

            if (month == 10)
            {
                return Month.October;
            }

            if (month == 11)
            {
                return Month.November;
            }

            if (month == 12)
            {
                return Month.December;
            }
            else
            {
                return null;
            }
        }
                                                
        public static Month? GetMonthWithSwitchStatement(int month)
        {
            switch (month)
            {
                case 1: return Month.January;
                case 2: return Month.February;
                case 3: return Month.March;
                case 4: return Month.April;
                case 5: return Month.May;
                case 6: return Month.June;
                case 7: return Month.July;
                case 8: return Month.August;
                case 9: return Month.September;
                case 10: return Month.October;
                case 11: return Month.November;
                case 12: return Month.December;
                default: return null;
            }
        }

        public static Month? GetMonthWithSwitchExpression(int month)
        {
            Month? result = month switch
            {
                int x when x == 1 => Month.January,
                int x when x == 2 => Month.February,
                int x when x == 3 => Month.March,
                int x when x == 4 => Month.April,
                int x when x == 5 => Month.May,
                int x when x == 6 => Month.June,
                int x when x == 7 => Month.July,
                int x when x == 8 => Month.August,
                int x when x == 9 => Month.September,
                int x when x == 10 => Month.October,
                int x when x == 11 => Month.November,
                int x when x == 12 => Month.December,
                _ => null,
            };

            return result;
        }
    }
}
