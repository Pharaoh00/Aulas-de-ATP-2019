using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static public void exercicio1()
        {
            int[] numeros = new int[6];
            double soma = 0;
            double media = 0;
            //int max = int.MinValue;
            int max = 0;
            int maxPos = 0;
            //int min = int.MaxValue;
            int min = 0;
            int minPos = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um valor inteiro: ");
                int numb = int.Parse(Console.ReadLine());
                numeros[i] = numb;
                soma += numeros[i];
                if(numeros[i] > max)
                {
                    max = numeros[i];
                    maxPos = i;
                }
                if(numeros[i] < min)
                {
                    min = numeros[i];
                    minPos = i;
                }
                if(i == 0)
                {
                    max = numeros[i];
                    min = numeros[i];
                }
            }
            Console.WriteLine("-- Respostas -- ");
            Console.WriteLine("a) O maior numero é: {0} na posição: {1}", max, maxPos);
            Console.WriteLine("b) O menor numero é: {0} na posição: {1}", min, minPos);

            media = soma / 6;
            Console.WriteLine("c) A media entre os numeros são: {0}", media);

            Console.Write("d) Os numeros a baixo da media são: ");
            for(int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] < media)
                {
                    Console.Write(numeros[i]+" ");
                }
            }
            Console.WriteLine();
            Console.Write("Todos os numeros são: ");
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i]+" ");
            }
            Console.WriteLine();
        }

        static public void exercicio2()
        {
            double[] calculo = new double[5];
            double mediaCalc = 0;
            double somaCalc = 0;
            //double maxCalc = double.MinValue;
            double maxCalc = 0;
            double[] algoritmo = new double[5];
            double mediaAlgo = 0;
            double SomaAlgo = 0;
            //double minAlgo = double.MaxValue;
            double minAlgo = 0;
            for(int i = 0; i < calculo.Length; i++)
            {
                double nota = 0;
                Console.Write("Informe a nota de Calculo 1: ");
                nota = double.Parse(Console.ReadLine());
                calculo[i] = nota;
                somaCalc += calculo[i];
                if(calculo[i] > maxCalc)
                {
                    maxCalc = calculo[i];
                }
                Console.Write("Informe a nota de Algoritmo 1: ");
                nota = double.Parse(Console.ReadLine());
                algoritmo[i] = nota;
                SomaAlgo += algoritmo[i];
                if(algoritmo[i] < minAlgo)
                {
                    minAlgo = algoritmo[i];
                }
                if (i == 0)
                {
                    maxCalc = calculo[i];
                    minAlgo = algoritmo[i];
                }
            }
            Console.WriteLine("-- Respostas -- ");
            mediaCalc = somaCalc / 5;
            mediaAlgo = SomaAlgo / 5;
            Console.WriteLine("a) A media de Calculo 1 é: {0}. A media do Algoritmo 1 é: {1}", mediaCalc, mediaAlgo);
            //Console.WriteLine("a) A media de Algoritmo 1 é: {0}", mediaAlgo);

            Console.WriteLine("b) A maior nota de Calculo 1 é: {0}", maxCalc);
            Console.WriteLine("c) A menor nota de Algoritmo 1 é: {0}", minAlgo);

            Console.Write("d) A nota dos alunos que ficaram a baixo da media é: ");
            for(int i = 0; i < calculo.Length; i++)
            {
                if(calculo[i] < mediaCalc)
                {
                    Console.Write(calculo[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("Avaliação - Vetores - 29/05/2019 - Prof. Carlos Ribas");
            while (running)
            {
                Console.Write("Digite a opção desejada (1 ou 2): ");
                string opcoes = Console.ReadLine();
                switch (opcoes)
                {
                    case "1":
                        exercicio1();
                        break;
                    case "2":
                        exercicio2();
                        break;
                    case "exit":
                        Console.WriteLine("Obrigado por usar.");
                        running = false;

                        break;
                    default:
                        Console.WriteLine("A opção {0} não é valida.", opcoes);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
