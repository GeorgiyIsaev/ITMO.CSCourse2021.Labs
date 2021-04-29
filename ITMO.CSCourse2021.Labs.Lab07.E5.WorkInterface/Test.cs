using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 7. Создание и использование ссылочных переменных*/
/*Упражнение 5. Работа с интерфейсами*/

namespace ITMO.CSCourse2021.Labs.Lab07.E5.WorkInterface
{
    class Test
    {
        public static void Main()
        {
            int num = 65;
            string msg = "A String";
            Coordinate c = new Coordinate(21.0, 68.0);

            Utils.Display(num);
            Utils.Display(msg);
            Utils.Display(c);
        }
    }
}
