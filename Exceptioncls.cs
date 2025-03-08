using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Exceptioncls
    {
        public static void exceptiontrial()
        {
            int[] ar = { 3 };
            int k = Int32.MaxValue;
            try
            { int i = ar[2]; 
              checked
                {
                    k = k + 12;
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                //throw new IndexOutOfRangeException("cannot add t");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                //throw new ArgumentOutOfRangeException("not int");
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }

    }
}
