using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; // Import para regex.

// Daniel Santos França & Hamon-Rá Taveira Guimarães  

// Procedimentos & Funções
/*
 * Exercicios 1  -  Linha = 38
 * Exercicios 2  -  Linha = 59
 * Exercicios 3  -  Linha = 92
 * Exercicios 4  -  Linha = 121
 * Exercicios 5  -  Linha = 174
 * Exercicios 6  -  Linha = 209
 * Exercicios 7  -  Linha = 231
 * Exercicios 8  -  Linha = 260
 * Exercicios 9  -  Linha = 286
 * Exercicios 10 -  Linha = 
 */

// Main (MENU)
/*
 * Exercicios 1  -  Linha = 449
 * Exercicios 2  -  Linha = 509
 * Exercicios 3  -  Linha = 525
 * Exercicios 4  -  Linha = 551
 * Exercicios 5  -  Linha = 573
 * Exercicios 6  -  Linha = 590
 * Exercicios 7  -  Linha = 598
 * Exercicios 8  -  Linha = 616
 * Exercicios 9  -  Linha = 633
 * Exercicios 10 -  Linha = 
 */

namespace Exercicios_vetor_matriz
{
    class Program
    {

        //Para orlando:
        //Deixei alguns cometanrios para você.
        //Algumas coisas não são exatamente como a questão pedia,
        //mas fui tentando organizar como eu pude.
        //
        //Deixei os meus "testes" anteriores como, linha de pensamento.
        //Muita coisa eu tentei passar para o mais simples, por exemplo,
        //Regex, eu fiz algo proximo do que eu acho que possa ser, pelo
        //menos funciona.
        //
        //Devem ter muitos erros bobos, muita coisa acontecendo ao mesmo
        //tempo, principalmente em relação a faculdade.
        //Mas tentei fazer o meu melhor.
        //Obrigado.

        // -- Procedimentos & Funções

        //Exercicios 1
        static void exercicio1(char[] gabarito, char[] aluno)
        {
            double acertos = 0;
            double resposta = 0.0f;
            for (int i = 0; i < gabarito.Length; i++)
            {
                if (aluno[i] == gabarito[i])
                {
                    acertos++;
                }
            }
            resposta = (acertos / gabarito.Length) * 100;
            Console.WriteLine("\nVocê acertou: {0}, e sua porcentagem foi: {1}%\n", acertos, resposta);
        }

        //Exercicios 2
        static int[] exercicio2(int[] matrix)
        {
            //Para orlando:
            //Não sei se ta certo, mas funciona.
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix.Length; j++)
                {
                    if (matrix[j - 1] > matrix[i])
                    {
                        //int temp1 = matrix[j - 1];
                        //int temp2 = matrix[i];
                        //matrix[j - 1] = temp2;
                        //matrix[i] = temp1;
                        int temp = matrix[j - 1];
                        matrix[j - 1] = matrix[i];
                        matrix[i] = temp;
                    }
                }
            }
            //Array.Sort(matrix); //Não usar Sort().
            return matrix;
        }

        //Exercicios 3
        static bool exercicio3(string[] matrix)
        {
            bool retorno = true;
            int count = 1;
            while (retorno && count < matrix.Length)
            {
                //Console.WriteLine(matrix[count]);
                if (matrix[count - 1].CompareTo(matrix[count]) > 0)
                {
                    retorno = false;
                }
                else if (matrix[count - 1].CompareTo(matrix[count]) <= 0)
                {
                    retorno = true;
                    count++;
                }
            }
            return retorno;
        }

        //Exercicios 4
        static int[] exercicio4(int[] matrix1, int[] matrix2)
        {
            int[] retorno = new int[matrix1.Length * 2];
            for (int i = 0; i < retorno.Length; i++)
            {
                if (i % 2 == 0)
                {

                    //if (i < matrix1.Length)
                    //{
                    //    retorno[i] = matrix1[i / 2];
                    //}
                    //else
                    //{
                    //    retorno[i] = matrix1[i/2];
                    //}
                    retorno[i] = matrix1[i / 2]; // Dividido por 2 pq são dois vetores
                }
                else
                {
                    //if (i < matrix2.Length)
                    //{
                    //    retorno[i] = matrix2[i / 2];
                    //}
                    //else
                    //{
                    //    retorno[i] = matrix2[i/2];
                    //}
                    retorno[i] = matrix2[i / 2];
                }
                //if(i < matrix2.Length)
                //{
                //    Console.WriteLine(i);
                //}
                //Console.WriteLine((i - matrix2.Length));
            }

            /*
             * BUG:
             * Os dois vetores como parametro devem ser do mesmo tamanho.
             * Se forem de tamanhos diferentes i/2 acessa um valor diferente.
             */

            return retorno;
        }

        //Exercicios 5
        static double[] exercicio5(int[] matrix)
        {
            //int maior = int.MinValue; //"hack"
            //int menor = int.MaxValue;
            int maior = 0;
            int menor = 0;
            double media = 0.0f;
            double soma = 0.0f;
            double[] retorno = new double[3];
            for (int i = 0; i < matrix.Length; i++)
            {
                if(i == 0)
                {
                    maior = matrix[i];
                    menor = matrix[i];
                }
                if (matrix[i] > maior)
                {
                    maior = matrix[i];
                }
                if (matrix[i] < menor)
                {
                    menor = matrix[i];
                }
                soma += matrix[i];
            }
            media = soma / matrix.Length;

            //"Hack" para retornar mais de um valor.
            retorno[0] = maior;
            retorno[1] = menor;
            retorno[2] = media;

            return retorno;
        }

        //Exercicios 6
        static int[,] exercicio6(int linhas, int colunas)
        {
            int[,] retorno = new int[linhas, colunas];
            int count = 1;
            for (int i = 0; i < retorno.GetLength(0); i++)
            {
                for (int j = 0; j < retorno.GetLength(1); j++)
                {
                    retorno[i, j] = count;
                    count++;
                }
            }

            return retorno;
        }

        //Exercicios 7
        static void exercicio7(int[,] matrix)
        {
            int soma = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + "\t");
                        soma += matrix[i, j];
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("A soma da diagonal da matriz é : {0}", soma);
        }

        //Exercicios 8
        static void exercicio8(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + j == matrix.GetLength(0) - 1)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }

        //Exercicios 9
        static void exercicio9(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    else if (i + j == matrix.GetLength(0) - 1)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }

        //Exercicios 10
        static void exercicio10(int[,] matrix)
        {
            int maiorX = 0;
            int menorX = 0;
            int menorY = 0;
            int maior = 0;
            int menor = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 && j == 0 || maior < matrix[i, j])
                    {
                        maior = matrix[i, j];
                        maiorX = i;
                    }
                }
            }
            for (int i = 0; i < matrix.GetLongLength(0); i++)
            {
                if (i == 0 || menor > matrix[maiorX, i])
                {
                    menor = matrix[maiorX, i];
                    menorX = maiorX;
                    menorY = i;
                }
            }
            Console.WriteLine("O maior valor de X é: {0}, e o menor de Y: {1}", maior, menor);

        }

        //Para orlando:
        //Sei que é "levemente" avançado, mas queria uma função generica.
        //So para funcionar com qualquer tipo. Para nao ter duas funções que fazem a mesma coisa.
        //Por example:
        //imprimeString() e imprimeInt().
        static void imprime<T>(T[] matrix)
        {
            string retorno = null;
            for (int i = 0; i < matrix.Length; i++)
            {
                //if (i == 0)
                //{
                //    //Console.Write("{0}, ", matrix[i]);
                //}
                if (i == matrix.Length - 1)
                {
                    retorno += String.Format("{0}. ", matrix[i]);
                }
                else
                {
                    retorno += String.Format("{0}, ", matrix[i]);
                }
            }
            Console.WriteLine(retorno);
        }

        static void imprimeMatriz<T>(T[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                    //if(j == 0)
                    //{
                    //    Console.Write("Linha: {0} - ({1}\t", i, matriz[i, j]);
                    //}
                    //else
                    //{
                    //    Console.Write("{0}", matriz[i, j]);
                    //}

                }
                Console.WriteLine();
            }
        }

        //My custom "regex"
        static bool customRegex(string input, string[] array_limit)
        {
            bool retorno = true;
            int count = 0;
            //if (array_limit.Contains(input))
            //{
            //    retorno = true;
            //}
            //else
            //{
            //    retorno = false;
            //}

            //Sem "Contains"
            while (count < array_limit.Length)
            {
                if (input.Equals(array_limit[count]))
                {
                    // Se alguma das letas for igual a qualquer letra na lista informada
                    // pare e retorne true.
                    retorno = true;
                    break;
                }
                else
                {
                    // Se não continue procurando.
                    retorno = false;
                    count++;
                }
            }
            return retorno;
        }

        // -- Fim - Metodos/Procedimentos & Funções

        static void Main(string[] args)
        {

            Random rnd = new Random();
            int tamanho;
            Console.WriteLine("Exercícios Avaliativos Vetores e Matriz");

            //Criando e preenchendo o menu automaticamente.
            string[] menu = new string[10]; //NÃO ESQUECER - SE FOR ADD MAIS OPÇÕES AUMENTAR O TAMANHO.
            for (int i = 0; i < menu.Length; i++)
            {
                menu[i] = String.Format("{0} - Para questão: {1}", i + 1, i + 1);
                if (i == menu.Length - 1)
                {
                    Console.WriteLine("Para sair {0}.", "exit");
                }

            }

            bool running = true;

            while (running)
            {
                foreach (string opcao in menu)
                {
                    Console.WriteLine(opcao);
                }
                Console.Write("\nDigite a opção desejada: ");
                //"Hack" para o programa nao sair, se caso o usuario passar uma string.
                //Exemplo:
                //int opcoes = int.Parse(Console.ReadLine())
                //se for uma letra, o programa crash.
                string opcoes = Console.ReadLine();
                switch (opcoes)
                {
                    case "exit":
                        Console.WriteLine("Obrigado por usar o meu programa.");
                        running = false;
                        break;

                    //EXERCICIO 1
                    case "1":
                        int count = 0;
                        char[] gabarito = { 'A', 'A', 'B', 'D', 'E', 'C', 'B', 'D', 'B', 'A' };
                        char[] respostas = new char[10];
                        string[] range = { "A", "B", "C", "D", "E" };
                        Console.WriteLine("-- Digite o seu gabarito --");

                        while (count < respostas.Length)
                        {
                            Console.Write("Digite sua resposta da questão {0}: ", count + 1);
                            string r1 = Console.ReadLine().ToUpper();
                            //Para orlando:
                            //Eu sei que é mais avançado.
                            //Mas so para simplificar a minha vida.

                            /*
                             * TO DO:
                             * Fazer um "custom regex".
                             */
                            //if (Regex.IsMatch(r1, @"^[A-E]+$"))
                            //{
                            //    respostas[count] = char.Parse(r1);
                            //    Console.WriteLine("Nota {0} adicionada.", r1);
                            //    count++;
                            //}

                            if (customRegex(r1, range)) //Custom "regex"
                            {
                                respostas[count] = char.Parse(r1); //"hack" para adicionar no vetor char.
                                Console.WriteLine("Nota {0} adicionada.", r1);
                                count++;
                            }
                            else
                            {
                                Console.WriteLine("Opção {0} invalida. Digite novamente.", r1);
                            }

                        }
                        //for(int i = 0; i < respostas.Length; i++)
                        //{
                        //    Console.Write("Questão {0}, sua resposta foi?: {1}");
                        //    string r = Console.ReadLine().ToLower();
                        //    if (Regex.IsMatch(r, @"^[a-e]+$")) {
                        //        respostas[i] = char.Parse(r);
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Opção {0} invalida. Digite novamente.", r);
                        //    }
                        //}

                        for (int i = 0; i < respostas.Length; i++)
                        {
                            Console.Write("{0} ", respostas[i]);
                        }

                        exercicio1(gabarito, respostas);
                        break;

                    //EXERCICIO 2
                    case "2":
                        int[] matriz2 = new int[10];
                        for (int i = 0; i < matriz2.Length; i++)
                        {
                            matriz2[i] = rnd.Next(50);
                        }
                        Console.Write("Lista fora de ordem: ");
                        imprime(matriz2);
                        Console.WriteLine();
                        exercicio2(matriz2); //function call
                        Console.Write("Lista em ordem: ");
                        imprime(matriz2);
                        Console.WriteLine();
                        break;

                    //EXERCICIO 3
                    case "3":
                        //string[] nomes = { "Arthur", "Barbara", "Leonardo", "Hamon" };
                        tamanho = int.Parse(Console.ReadLine());
                        string[] palavras = new string[tamanho];
                        for (int i = 0; i < palavras.Length; i++)
                        {
                            Console.Write("Digite uma palavra: ");
                            string palavra = Console.ReadLine();
                            palavras[i] = palavra;
                        }
                        bool r3 = exercicio3(palavras);
                        //Console.WriteLine(exercicio3(palavras));
                        if (r3 == true)
                        {
                            imprime(palavras);
                            Console.Write("A lista está ordenada.");
                        }
                        else if (r3 == false)
                        {
                            imprime(palavras);
                            Console.Write("A lista não está ordenada.");
                        }
                        Console.WriteLine();
                        break;

                    //EXERCICIO 4
                    case "4":
                        //int[] vetor1 = { 1, 3, 4, 6, 8, 10, 12 };
                        //int[] vetor2 = { 2, 4, 5, 7, 9, 11, 13 };
                        int r4 = 0;
                        Console.Write("Digite um valor para os vetores: ");
                        tamanho = int.Parse(Console.ReadLine());
                        int[] vetor1 = new int[tamanho];
                        int[] vetor2 = new int[tamanho];
                        for (int i = 0; i < vetor1.Length; i++)
                        {
                            Console.Write("Digite um valor para o vetor 1: ");
                            r4 = int.Parse(Console.ReadLine());
                            vetor1[i] = r4;
                            Console.Write("Digite um valor para o vetor 2: ");
                            r4 = int.Parse(Console.ReadLine());
                            vetor2[i] = r4;
                        }
                        imprime(exercicio4(vetor1, vetor2));
                        Console.WriteLine();
                        break;

                    //EXERCICIO 5
                    case "5":
                        Console.Write("Digite o Tamanho do vetor: ");
                        tamanho = int.Parse(Console.ReadLine());
                        int[] matriz5 = new int[tamanho];
                        for (int i = 0; i < matriz5.Length; i++)
                        {
                            matriz5[i] = rnd.Next(100);
                        }
                        double[] r5 = exercicio5(matriz5);
                        imprime(matriz5);
                        Console.WriteLine("O maior valor: {0}", r5[0]);
                        Console.WriteLine("O menor valor: {0}", r5[1]);
                        Console.WriteLine("A media foi: {0}", r5[2]);
                        Console.WriteLine();
                        break;

                    //EXERCICIO 6
                    case "6":
                        Console.Write("Digite o Tamanho da matriz: ");
                        tamanho = int.Parse(Console.ReadLine());
                        imprimeMatriz(exercicio6(4, 4));
                        Console.WriteLine();
                        break;

                    //EXERCICIO 7
                    case "7":
                        Console.Write("Digite o tamanho da matriz: ");
                        tamanho = int.Parse(Console.ReadLine());
                        int[,] matriz7 = new int[tamanho, tamanho];
                        for (int i = 0; i < matriz7.GetLength(0); i++)
                        {
                            for (int j = 0; j < matriz7.GetLength(1); j++)
                            {
                                matriz7[i, j] = rnd.Next(9);
                            }
                        }
                        imprimeMatriz(matriz7);
                        Console.WriteLine();
                        exercicio7(matriz7);
                        Console.WriteLine();
                        break;

                    //EXERCICIO 8
                    case "8":
                        Console.Write("Digite o tamanho da matriz: ");
                        tamanho = int.Parse(Console.ReadLine());
                        int[,] matriz8 = new int[tamanho, tamanho];
                        for (int i = 0; i < matriz8.GetLength(0); i++)
                        {
                            for (int j = 0; j < matriz8.GetLength(1); j++)
                            {
                                matriz8[i, j] = rnd.Next(9);
                            }
                        }
                        imprimeMatriz(matriz8);
                        Console.WriteLine();
                        exercicio8(matriz8);
                        Console.WriteLine();
                        break;

                    //EXERCICIO 9
                    case "9":
                        Console.Write("Digite o tamanho da matriz: ");
                        tamanho = int.Parse(Console.ReadLine());
                        char[,] matriz9 = new char[tamanho, tamanho];
                        for (int i = 0; i < matriz9.GetLength(0); i++)
                        {
                            for (int j = 0; j < matriz9.GetLength(1); j++)
                            {
                                matriz9[i, j] = '#';
                            }
                        }
                        exercicio9(matriz9);
                        Console.WriteLine();
                        break;

                    //EXERCICIO 10
                    case "10":
                        Console.Write("Digite o tamanho da matriz: ");
                        tamanho = int.Parse(Console.ReadLine());
                        int[,] matriz10 = new int[tamanho, tamanho];
                        for (int i = 0; i < matriz10.GetLongLength(0); i++)
                        {
                            for (int j = 0; j < matriz10.GetLongLength(1); j++)
                            {
                                matriz10[i, j] = rnd.Next(99);
                            }
                        }
                        
                        imprimeMatriz(matriz10);
                        exercicio10(matriz10);
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Opção {0} não é valida.", opcoes);
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
