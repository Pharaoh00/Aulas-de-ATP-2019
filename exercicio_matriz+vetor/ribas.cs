using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static public int[,] easyMatriz(int[,] matrix, string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Digite um valor intereiro (Linha {0} - Coluna {1}): ", i, j);
                    int number = int.Parse(Console.ReadLine());
                    matrix[i, j] = number;
                }
            }
            return matrix;
        }

        static public void showMatriz(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //Exercicio 1 lista 1
        public static void exercicioMatrizes1L1()
        {
            int[,] A = new int[2, 3];
            int[,] B = new int[2, 3];
            int[,] C = new int[2, 3];
            int[,] D = new int[2, 3];
            int[,] E = new int[2, 3];

            easyMatriz(A, "Preencha a matriz A");
            Console.WriteLine("Matrix A: ");
            showMatriz(A);
            Console.WriteLine();
            easyMatriz(B, "Preencha a matriz B");
            Console.WriteLine("Matrix B: ");
            showMatriz(B);
            Console.WriteLine();

            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            Console.WriteLine("Matrix C: ");
            showMatriz(C);
            Console.WriteLine();
            for (int i = 0; i < D.GetLength(0); i++)
            {
                for (int j = 0; j < D.GetLength(1); j++)
                {
                    D[i, j] = (C[i, j] * 2) - A[i, j];
                }
            }
            Console.WriteLine("Matrix D: ");
            showMatriz(D);
            Console.WriteLine();
            for (int i = 0; i < D.GetLength(0); i++)
            {
                for (int j = 0; j < D.GetLength(1); j++)
                {
                    E[i, j] = C[i, j] + D[i, j];
                }
            }
            Console.WriteLine("Matrix E: ");
            showMatriz(E);
            Console.WriteLine();
        }

        //Exercicio 1 Lista 2
        public static void exercicioMatrizes1L2()
        {
            int[,] A = new int[2, 3];
            int[,] B = new int[2, 3];
            int[,] C = new int[2, 3];
            int[,] D = new int[2, 3];
            int[,] E = new int[2, 3];

            easyMatriz(A, "Preencha a matriz A");
            Console.WriteLine("Matrix A: ");
            showMatriz(A);
            Console.WriteLine();
            easyMatriz(B, "Preencha a matriz B");
            Console.WriteLine("Matrix B: ");
            showMatriz(B);
            Console.WriteLine();

            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            Console.WriteLine("Matrix C: ");
            showMatriz(C);
            Console.WriteLine();
            for (int i = 0; i < D.GetLength(0); i++)
            {
                for (int j = 0; j < D.GetLength(1); j++)
                {
                    D[i, j] = (A[i,j] * 2) - B[i,j];
                }
            }
            Console.WriteLine("Matrix D: ");
            showMatriz(D);
            Console.WriteLine();
            for (int i = 0; i < D.GetLength(0); i++)
            {
                for (int j = 0; j < D.GetLength(1); j++)
                {
                    E[i, j] = (C[i,j] * 3) - D[i,j];
                }
            }
            Console.WriteLine("Matrix E: ");
            showMatriz(E);
            Console.WriteLine();
        }

        //Exercicio 2 Lista 1
        public static void exercicioMatrizes2L1()
        {
            int[,] matrix = new int[3, 3];
            int soma = 0;
            double media = 0;
            int min = 0;
            int minPosI = 0;
            int minPosJ = 0;
            int max = 0;
            int maxPosI = 0;
            int maxPosJ = 0;
            easyMatriz(matrix, "Preecha a matriz");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    soma += matrix[i, j];
                    if(i == 0 && j == 0)
                    {
                        min = matrix[i, j];
                        minPosI = i;
                        minPosJ = j;

                        max = matrix[i, j];
                        maxPosI = i;
                        maxPosJ = j;
                    }
                    if(matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minPosI = i;
                        minPosJ = j;
                    }
                    if(matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxPosI = i;
                        maxPosJ = j;
                    }
                }
            }

            Console.WriteLine("A matrix é: ");
            showMatriz(matrix);
            Console.WriteLine();
            Console.WriteLine("Diagonal principal da matrix");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("A soma de todos os elementos da matriz é: {0}.", soma);
            Console.WriteLine("O maior elemento da matriz é {0} na posição ({1},{2}).", max, maxPosI, maxPosJ);
            Console.WriteLine("O menor elemento da matriz é {0} na posição ({1},{2}).", min, minPosI, minPosJ);
            media = (double)soma / matrix.Length;
            Console.WriteLine("A media dos elementos da matriz é {0}.", media);

        }

        //Exercicio 2 Lista 2
        public static void exercicioMatrizes2L2()
        {
            int[,] G = new int[3, 3];
            int soma = 0;
            double media = 0;
            int min = 0;
            int minPosI = 0;
            int minPosJ = 0;
            int max = 0;
            int maxPosI = 0;
            int maxPosJ = 0;
            easyMatriz(G, "Preecha a matriz");
            for (int i = 0; i < G.GetLength(0); i++)
            {
                for (int j = 0; j < G.GetLength(1); j++)
                {
                    soma += G[i, j];
                    if (i == 0 && j == 0)
                    {
                        min = G[i, j];
                        minPosI = i;
                        minPosJ = j;

                        max = G[i, j];
                        maxPosI = i;
                        maxPosJ = j;
                    }
                    if (G[i, j] < min)
                    {
                        min = G[i, j];
                        minPosI = i;
                        minPosJ = j;
                    }
                    if (G[i, j] > max)
                    {
                        max = G[i, j];
                        maxPosI = i;
                        maxPosJ = j;
                    }
                }
            }

            Console.WriteLine("A matrix é: ");
            showMatriz(G);
            Console.WriteLine();
            Console.WriteLine("Diagonal principal da matrix");
            for (int i = 0; i < G.GetLength(0); i++)
            {
                for (int j = 0; j < G.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(G[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("A soma de todos os elementos da matriz é: {0}.", soma);
            Console.WriteLine("O maior elemento da matriz é {0} na posição ({1},{2}).", max, maxPosI, maxPosJ);
            Console.WriteLine("O menor elemento da matriz é {0} na posição ({1},{2}).", min, minPosI, minPosJ);
            media = (double)soma / G.Length;
            Console.WriteLine("A media dos elementos da matriz é {0}.", media);

        }

        static public double mediaMatriz(int[,] matrix)
        {
            double media = 0;
            int soma = 0;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    soma += matrix[i, j];
                }
            }
            media = (double)soma / matrix.Length;
            return media;
        }

        //Exercicio 3 lista 1
        static public void exercicioMatrizes3L1()
        {
            int[,] A = new int[4, 5];
            int[,] B = new int[4, 5];
            int[,] C = new int[4, 5];

            int maxA = 0;
            int maxAposI = 0;
            int maxAposJ = 0;

            int minB = 0;
            int minBposI = 0;
            int minBposJ = 0;

            for(int i = 0; i < A.GetLength(0); i++)
            {
                for(int j = 0; j < A.GetLength(1); j++)
                { 
                    A[i, j] = 2 * i + j;
                    B[i, j] = 3 * i + j;
                }
            }
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for(int j = 0; j < C.GetLength(1); j++)
                {
                    C[i, j] = (A[i, j] * 2) + (B[i, j] * 3);
                    if(i == 0 && j == 0)
                    {
                        maxA = C[i, j];
                        maxAposI = i;
                        maxAposJ = j;

                        minB = C[i, j];
                        minBposI = i;
                        minBposJ = j;
                    }
                    if(C[i,j] > maxA)
                    {
                        maxA = C[i, j];
                        maxAposI = i;
                        maxAposJ = j;
                    }
                    if(C[i,j] < minB)
                    {
                        minB = C[i, j];
                        minBposI = i;
                        minBposJ = j;
                    }
                }
            }
            Console.WriteLine("A matriz A: ");
            showMatriz(A);
            Console.WriteLine();
            Console.WriteLine("A matriz B: ");
            showMatriz(B);
            Console.WriteLine();
            Console.WriteLine("A matriz C: ");
            showMatriz(C);
            Console.WriteLine();
            Console.WriteLine("O maior elemento da matriz A é: {0} na posição ({1},{2})", maxA, maxAposI, maxAposJ);
            Console.WriteLine("O menor elemento da matriz B é: {0} na posição ({1},{2})", minB, minBposI, minBposJ);
            Console.WriteLine("A media dos elementos da matriz A é: {0}", mediaMatriz(A));
            Console.WriteLine("A media dos elementos da matriz B é: {0}", mediaMatriz(B));
            Console.WriteLine("A media dos elementos da matriz C é: {0}", mediaMatriz(C));
            Console.Write("Os elementos que estão a baixo da matriz A é: ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for(int j = 0; j < A.GetLength(1); j++)
                {
                    if(A[i,j] < mediaMatriz(A))
                    {
                        Console.Write(A[i, j] + " ");
                    }
                }
            }
        }

        //Exercicio 3 lista 2
        static public void exercicioMatrizes3L2()
        {
            int[,] A = new int[4, 5];
            int[,] B = new int[4, 5];
            int[,] C = new int[4, 5];

            int maxA = 0;
            int maxAposI = 0;
            int maxAposJ = 0;

            int minB = 0;
            int minBposI = 0;
            int minBposJ = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = 2 * i + j;
                    B[i, j] = 3 * i + j;
                }
            }
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];

                    if (i == 0 && j == 0)
                    {
                        maxA = C[i, j];
                        maxAposI = i;
                        maxAposJ = j;

                        minB = C[i, j];
                        minBposI = i;
                        minBposJ = j;
                    }
                    if (C[i, j] > maxA)
                    {
                        maxA = C[i, j];
                        maxAposI = i;
                        maxAposJ = j;
                    }
                    if (C[i, j] < minB)
                    {
                        minB = C[i, j];
                        minBposI = i;
                        minBposJ = j;
                    }
                }
            }
            Console.WriteLine("A matriz A: ");
            showMatriz(A);
            Console.WriteLine();
            Console.WriteLine("A matriz B: ");
            showMatriz(B);
            Console.WriteLine();
            Console.WriteLine("A matriz C: ");
            showMatriz(C);
            Console.WriteLine();
            Console.WriteLine("A diagonal da matriz C");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for(int j = 0; j < A.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        Console.Write(C[i, j] + "\t");
                    }
                    else {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("A media dos elementos da matriz A é: {0}", mediaMatriz(A));
            Console.WriteLine("A media dos elementos da matriz B é: {0}", mediaMatriz(B));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("EXERCÍCIOS – MATRIZES – LISTA 1");

            //Console.WriteLine("Exercicio 1 - Lista 1");
            //exercicioMatrizes1L1();
            //Console.WriteLine("Exercicio 2 - Lista 1");
            //exercicioMatrizes2L1();
            //Console.WriteLine("Exercicio 3 - Lista 1");
            //exercicioMatrizes3L1();
            //Console.WriteLine("Exercicio 3 - Lista 2");
            //exercicioMatrizes3L2();

            double paisA = 52000000;
            double paisB = 47000000;

            double paisA_porcentagem = 0;
            double paisB_porcentagem = 0;

            int anos = 0;

            for(int i = 0; i < 100; i++)
            {
                paisA_porcentagem = Math.Round((paisA * 1.3) / 100);
                paisB_porcentagem = Math.Round((paisB * 2.4) / 100);

                paisA = paisA + paisA_porcentagem;
                paisB = paisB + paisB_porcentagem;

                if(paisB >= paisA)
                {
                    anos = i;
                    break;
                }
            }

            //Console.WriteLine((paisA * 1.3) / 100);
            //Console.WriteLine((paisB * 2.4) / 100);
            Console.WriteLine("Irá demorar {0} anos para os paises se igualarem", anos);

            Console.ReadLine();
        }
    }
}
