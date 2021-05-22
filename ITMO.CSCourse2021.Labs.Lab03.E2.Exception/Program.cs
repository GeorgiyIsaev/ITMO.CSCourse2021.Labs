using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 3. Использование выражений и исключений*/
/*Упражнение 2. Проверка вводимого пользователем значения  дня года*/

namespace ITMO.CSCourse2021.Labs.Lab03.E2.exception
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class Program
    {
        static void Main()
        {
                    
            try
            {
                Console.Write("Please enter a day number between 1 and 365: ");
                string line = Console.ReadLine();
                int dayNum = int.Parse(line);

                const int maxDayYear = 365;
                const int minDayYear = 1;
                if (dayNum < minDayYear || dayNum > maxDayYear)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;


                var DaysInMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                foreach (int daysInMonth in DaysInMonths)
                {
                    if (dayNum <= daysInMonth)
                    {
                        break;
                    }
                    else
                    {
                        dayNum -= daysInMonth;
                        monthNum++;
                    }
                }
                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }
            Console.ReadKey();
        }

    }
}
