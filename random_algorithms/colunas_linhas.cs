using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_prova_11_06_2019
{
    class Program
    {
        public static int[,] easyFill(int[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //Console.Write("Digite um valor interio para preencher a posição ({0},{1}): ", i, j);
                    //matrix[i, j] = int.Parse(Console.ReadLine());
                    matrix[i, j] = rnd.Next(1,55);
                }
            }

            return matrix;
        }

        public static void easyPrint(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] A = new int[3, 4];

            int maxLinha = 0;
            int linhaPosJ = 0;

            int minColuna = 0;
            int ColunaPosI = 0;

            Console.WriteLine("Digite os valores para a matriz A");
            easyFill(A);

            easyPrint(A);

            Console.WriteLine("Test");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for(int j = 0; j < A.GetLength(1); j++)
                { 
                    if(i == 0 && j == 0)
                    {
                        maxLinha = A[2,j];
                        linhaPosJ = j;

                        minColuna = A[i, 0];
                        ColunaPosI = i;
                    }

                    if (i == 2)
                    {
                        /*
                         * Pega a ultima coluna
                         */
                        //Console.WriteLine(A[2, j]); // Ultima linha
                        if (A[i, j] > maxLinha)
                        {
                            maxLinha = A[2, j];
                            linhaPosJ = j;
                        }
                    }
                    if (j == 0)
                    {
                        /*
                         * Pega a primeira linha
                         */
                        Console.WriteLine(A[i, 0]); // Primeira Coluna
                        if (A[i, j] < minColuna)
                        {
                            minColuna = A[i, 0];
                            ColunaPosI = i;
                        }
                    }
                }
            }

            Console.WriteLine("O maior elemento da ultima linha é: {0} na posição(2, {1})", maxLinha, linhaPosJ);
            Console.WriteLine("O menor elemento da primeira coluna é: {0} na posição(2, {1})", minColuna, ColunaPosI);

            Console.ReadKey();
        }
    }
}
