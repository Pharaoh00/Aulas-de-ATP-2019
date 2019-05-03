using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        

        static int SomaNumero(int a, int b) // Função
        {
            return a + b; // Função deve retornar algo. No caso a soma.
        }

        static void SomaOutroNumero(int a, int b) //Metodo não retorna nada.
        {
            int soma;
            soma = a + b;

            Console.WriteLine("A soma dos numer {0} e {1} é igual à: {2}", a, b, soma);
            //Automaticamente print na tela o resultado.
        }
        static void Main(string[] args)
        {
            
            Console.Write("Insira o Primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o Segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("-- Função --");
            Console.WriteLine("A soma dos numer {0} e {1} é igual à: {2}",n1, n2, SomaNumero(n1, n2));

            Console.WriteLine("-- Metodo --");
            SomaOutroNumero(n1, n2);

            Console.ReadLine();
        }
        
    }
}
