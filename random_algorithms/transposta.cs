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

            int[,] matrixA = new int[2, 3];
            int[,] matrixB = new int[2, 3];
            int[,] matrixC = new int[2, 3];
            int[,] matrixCt = new int[3, 2]; // Lembrando, a traposta tem a quantidade inversa do tamanho da matriz.

            int maxA = 0;
            int aPosI = 0;
            int aPosJ = 0;
            int minB = 0;
            int bPosI = 0;
            int bPosJ = 0;

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
                    if(i == 0 && j == 0)
                    {
                        maxA = matrixA[i, j];
                        aPosI = i;
                        aPosJ = j;

                        minB = matrixB[i, j];
                        bPosI = i;
                        bPosJ = j;
                    }
                    if(matrixA[i,j] > maxA)
                    {
                        maxA = matrixA[i, j];
                        aPosI = i;
                        aPosJ = j;
                    }
                    if(matrixB[i,j] < minB)
                    {
                        minB = matrixB[i, j];
                        bPosI = i;
                        bPosJ = j;
                    }

                    matrixC[i, j] = (matrixA[i, j] * 3) - (matrixB[i, j] * 2);
                }
            }

            Console.WriteLine("Matriz A");
            for(int i = 0; i < matrixA.GetLength(0); i++)
            {
                for(int j = 0; j < matrixA.GetLength(1); j++)
                {
                    Console.Write(matrixA[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Matriz B");
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    Console.Write(matrixB[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("O maior valor da matriz A foi: {0} na posição ({1}, {2}).", maxA, aPosI, aPosJ);
            Console.WriteLine("O menor valor da matriz B foi: {0} na posição ({1}, {2}).", minB, bPosI, bPosJ);

            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for(int j = 0; j < matrixC.GetLength(1); j++)
                {
                    matrixCt[j, i] = matrixC[i, j];
                }
            }

            Console.WriteLine("Matriz C");
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    Console.Write(matrixC[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Matriz C transposta");
            for (int i = 0; i < matrixCt.GetLength(0); i++)
            {
                for (int j = 0; j < matrixCt.GetLength(1); j++)
                {
                    Console.Write(matrixCt[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
