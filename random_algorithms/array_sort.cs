using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //https://www.geeksforgeeks.org/different-ways-to-sort-an-array-in-descending-order-in-c-sharp/
            Random rnd = new Random();
            int[] test = new int[10];
            string[] test1 = { "Enzo", "Arthur", "João", "Pedro", "Gustavo", "Miguel", "Lucas" };

            for (int i = 0; i < test.Length; i++)
            {
                test[i] = rnd.Next(50);
            }
            Console.Write("Array sem sort: ");
            for(int i = 0; i < test.Length; i++)
            {
                //Console.Write(test[i] + " ");
                Console.Write("{0} ", test[i]);
            }
            Array.Sort(test);
            Console.WriteLine();
            Console.Write("Array com sort: ");
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Array string sem sort: ");
            for (int i = 0; i < test1.Length; i++)
            {
                Console.Write(test1[i] + " ");
            }
            Array.Sort(test1);

            Console.WriteLine();
            Console.Write("Aaray string com sort: ");
            for (int i = 0; i < test1.Length; i++)
            {
                Console.Write(test1[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
