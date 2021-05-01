using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 13. Создание и использование атрибутов*/
/*Упражнение 2. Создание и использование пользовательского атрибута*/

namespace ITMO.CSCourse2021.Labs.Lab13.E2.DeveloperInfoAttribute
{
    class TestRational
    {
        static void Main(string[] args)
        {
       
            System.Reflection.MemberInfo attrInfo;
            attrInfo = typeof(Rational);
            object[] attrs = attrInfo.GetCustomAttributes(false);

            foreach (CustomAttribute.DeveloperInfoAttribute devAttr in attrs)
            {
                Console.WriteLine("Developer: {0}\tDate: {1}", devAttr.Developer, devAttr.Date);
            }           

        }
    }
}
