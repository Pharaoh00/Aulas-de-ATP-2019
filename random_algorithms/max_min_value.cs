using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace "SEU NAMESPACE - O MESMO NOME DA SUA PASTA"
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            int max = 0;
            int min = 0;
            Console.Write("Os numeros da lista são: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(99); // Adicionar qualquer valor de 0 a 99 a lista numbers.
                if (i == 0) 
                {
                    max = numbers[i]; // Se o i for igual a zero, o primeiro valor, maximo é o primeiro valor.
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    // Se o index atual da lista numbers for maior que o max (maior numero?)
                    // O maior numero agora é o index atual.
                    max = numbers[i]; 
                }
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("O maior valor da lista é: {0}", max);
            Console.WriteLine("O menor valor da lista é: {0}", min);
            Console.ReadKey();
        }
    }
}
