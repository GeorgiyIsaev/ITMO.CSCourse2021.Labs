using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Labs.Lab01
{
    class Greeter
    {
        static void Main(string[] args)
        {              
            string address = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory();
            Console.WriteLine("address: {0}", address);
            Console.WriteLine("Please enter your name");
            string myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);
            
            try
            {
                Console.WriteLine("Please enter the first integer");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine("Please enter the second integer");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);

                int k = i / j;
                Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
            Console.Read();

        }

    }
}
