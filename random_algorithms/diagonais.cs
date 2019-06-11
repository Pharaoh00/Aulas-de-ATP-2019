using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_prova_11_06_2019
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int[,] matrixA = new int[3, 3];
            int[,] matrixB = new int[3, 3];
            int[,] matrixC = new int[3, 3];

            //Console.WriteLine("Insira os valores para a matriz A");
            //for(int i = 0; i < matrixA.GetLength(0); i++)
            //{
            //    for(int j = 0; j < matrixA.GetLength(1); j++)
            //    {
            //        Console.Write("Valor para a linha {0}, coluna {1}: ", i, j);
            //        matrixA[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Insira os valores para a matriz B");
            //for (int i = 0; i < matrixA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrixA.GetLength(1); j++)
            //    {
            //        Console.Write("Valor para a linha {0}, coluna {1}: ", i, j);
            //        matrixB[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            // So para nao precisar de ficar preenchendo automaticamente as matrizes
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = rnd.Next(1, 39);
                    matrixB[i, j] = rnd.Next(1, 39);
                }
            }

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for(int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixC[i, j] = (matrixA[i, j] * 3) - (matrixB[i, j] * 2);
                }
            }

            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    Console.Write(matrixC[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Diagonal Secundaria");
            // Diagonal Secundaria
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for(int j = 0; j < matrixC.GetLength(1); j++)
                {
                    if(i + j == matrixC.GetLength(0) - 1)
                    {
                        Console.Write(matrixC[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("\t"); // Somente para não ficar uma em cima da outra.
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Diagonal Principal");
            // Diagonal Principal
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrixC[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("\t"); // Somente para não ficar uma em cima da outra.
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
