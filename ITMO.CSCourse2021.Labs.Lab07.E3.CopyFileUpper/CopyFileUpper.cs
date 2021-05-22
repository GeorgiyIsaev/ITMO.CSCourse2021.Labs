using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 7. Создание и использование ссылочных переменных*/
/*Упражнение 3. Создание прописной версии текста  файла*/

namespace ITMO.CSCourse2021.Labs.Lab07.E3.CopyFileUpper
{
    class CopyFileUpper
    {
        static void Main(string[] args)
        {
            string sFrom, sTo;
            StreamReader srFrom;
            StreamWriter swTo;

            // Prompt for input file name
            Console.Write("Copy from:");
            sFrom = Console.ReadLine();

            // Prompt for output file name
            Console.Write("Copy to:");
            sTo = Console.ReadLine();

            Console.WriteLine("Copy from {0} to {1}", sFrom, sTo);
            try
            {
                srFrom = new StreamReader(sFrom);
                swTo = new StreamWriter(sTo);
                try
                {   
                    while (srFrom.Peek() != -1)
                    {
                        string sBuffer = srFrom.ReadLine();
                        sBuffer = sBuffer.ToUpper();
                        swTo.WriteLine(sBuffer);
                    }
                }
                finally
                {
                    swTo.Close();
                    srFrom.Close();
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Input file not found");
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception");
                Console.WriteLine(e.ToString());
            }           
        }
    }
}

