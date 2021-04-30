using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 5. Создание и использование массивов*/
/*Упражнение 2. Перемножение матриц
 	Перемножьте две матрицы*/
namespace ITMO.CSCourse2021.Labs.Lab05.E2.MatrixMultiply.v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            a[0, 0] = 1; a[0, 1] = 2;
            a[1, 0] = 3; a[1, 1] = 4;

            int[,] b = new int[2, 2];
            b[0, 0] = 5; b[0, 1] = 6;
            b[1, 0] = 7; b[1, 1] = 8;

            int[,] result = new int[2, 2];
            result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];

            Console.WriteLine(result[0, 0]);
            Console.WriteLine(result[0, 1]);
            Console.WriteLine(result[1, 0]);
            Console.WriteLine(result[1, 1]);

            /*	Выведите значения массива result, используя метод  с параметром-массивом*/
            Console.WriteLine("\n Вывод через методы класса MatrixMultiply");

            MatrixMultiply.Output1(result);
            MatrixMultiply.Output2(result);      
            //Console.ReadKey();

            /*	Создайте метод, рассчитывающий и возвращающий значения массива result*/
            int[,] c = MatrixMultiply.Multiply(a,b);
            Console.WriteLine("\n Результат Multiply(a,b)");
            MatrixMultiply.Output2(c);
            //Console.ReadKey();

            /*	Рассчитайте значения массива result, используя цикл for*/
            MatrixMultiply.MultiplyFor(a, b);
            Console.WriteLine("\n Результат MultiplyFor(a,b)");
            MatrixMultiply.Output2(c);
            Console.ReadKey();
        }
    }
}
