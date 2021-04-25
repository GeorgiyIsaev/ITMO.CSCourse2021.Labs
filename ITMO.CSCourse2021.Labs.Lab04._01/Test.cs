using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 4. Создание и использование методов*/
namespace ITMO.CSCourse2021.Labs.Lab04._01
{
    /// <summary>
    /// This the test harness
    /// </summary> 
    public class Test
    {
        public static void Main()
        {
            /*Упражнение 1. Использование параметров в методах, возвращающих значения*/
            int x; // Input value 1
            int y; // Input value 2
            int greater; // Result from Greater()

            // Get input numbers
            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());

            // Test the Greater( ) method
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);
            Console.ReadKey();

            /*Упражнение 2. Использование в методах параметров, передаваемых по ссылке*/
            // Test the Swap method
            Console.WriteLine("Before swap: " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);
            Console.ReadKey();

            /*Упражнение 3. Использование возвращаемых параметров в методах*/
            int f; // Factorial result
            bool ok; // Factorial success or failure

            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());

            // Test the factorial function
            ok = Utils.Factorial(x, out f);
            // Output factorial results
            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");
            Console.ReadKey();
        }
    }
}
