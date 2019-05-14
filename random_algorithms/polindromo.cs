using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Polindromo(string s)
        {
            bool test = true;
            int count = 0;
            while(test && count < s.Length)
            {
                if(s[count] == s[s.Length - count-1])
                {
                    test = true;
                    count++;
                }
                else
                {
                    test = false;
                    break;
                }
            }
            if (test)
            {
                Console.WriteLine("A palavra {0} é um polindromo", s);
            }
            else
            {
                Console.WriteLine("A palavra {0} não é um polindromo.", s);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra que deseja checar: ");
            string poli = Console.ReadLine();
            Polindromo(poli);
            Console.ReadLine();
        }
    }
}
