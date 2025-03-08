using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class prime
    {
        public static bool checkPrime(int num)
        {
            if (num == 2)
                return true;
            for (int i = 2; i < num; i++)
            {
                if (num <= 1 || num % i == 0)
                    return false;
            }
            return true;
        }
        

    }
}
