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
            int j = 5;
            int[] ar = { 3 };
            int k = Int32.MaxValue;
            try
            {
                if (5 == j)
                    throw new Exception("no 5");
                int i = ar[2]; 
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }

    }
}
