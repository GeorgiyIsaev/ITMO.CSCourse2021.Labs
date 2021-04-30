using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 5. Создание и использование массивов*/
/*Упражнение 2. Перемножение матриц
 	Обеспечьте возможность считывания значений первой матрицы с консоли*/
namespace ITMO.CSCourse2021.Labs.Lab05.E2.MatrixMultiply.v2.ReadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int[,] a = new int[2, 2];
            MatrixMultiply.Input(a);        

            int[,] b = new int[2, 2];
            MatrixMultiply.Input(b);


            /*	Рассчитайте значения массива result, используя цикл for*/
            int[,] c = MatrixMultiply.Multiply(a, b);
            Console.WriteLine("\n Результат MultiplyFor(a,b)");
            MatrixMultiply.Output(c);
            Console.ReadKey();
        }
    }
}
