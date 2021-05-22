using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Labs.Lab04.E1.E2.E3.Metods
{
    class Utils
    {
        //
        // Return the greater of two integer values
        //

        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static bool TryFactorial(int n, out int answer)
        {
            int k; // Loop counter
            int f; // Working value
            bool ok = true; // True if okay, false if not

            if (n < 0)
                ok = false;
            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception e)
            {
                f = 0;
                ok = false;
            }    
            answer = f;    
            return ok;
        }
    }
}

