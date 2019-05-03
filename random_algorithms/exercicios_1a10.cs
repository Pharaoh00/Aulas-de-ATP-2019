using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static int Opçao1()
        {
            /*Faça um programa contendo um procedimento que receba como
            parâmetro dois vetores de caracteres. O primeiro vetor representa o
            gabarito da prova e o segundo vetor contém as respostas de um
            determinado aluno. No método deve ser informado o número de acertos do
            aluno e o percentual de acertos.Cada vetor deverá conter 10 caracteres,
            variando de A a E.Caso o usuário digite o caracter minúsculo, o programa
            deve convertê-lo para maiúsculo.*/

            int acertos = 0;

            string[] gabarito = new string[10];

            gabarito[0] = "E";
            gabarito[1] = "A";
            gabarito[2] = "C";
            gabarito[3] = "C";
            gabarito[4] = "D";
            gabarito[5] = "E";
            gabarito[6] = "B";
            gabarito[7] = "B";
            gabarito[8] = "A";
            gabarito[9] = "C";


            string[] respostas = new string[10];

            for (int i = 0; i < 10; i++)
            {

                string aluno;
                Console.WriteLine("Digite as respostas do aluno:");
                aluno = Console.ReadLine().ToUpper();
                respostas[i] = aluno;
            }

            for (int i = 0; i < gabarito.Length; i++)
            {

                if (respostas[i] == gabarito[i])
                {
                    acertos++;
                }


            }
            return (acertos);

        }
        static int[] opcao2()
        {
            /*Faça uma função que recebe como parâmetro um vetor de inteiros e
            retorne esse vetor ordenado em ordem crescente.No método main,
            imprimir esse vetor, usando um procedimento chamado Imprime.*/


            Console.WriteLine("Digite a quantidades de valores que deseja inserir: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Informe os valores: ");
            int[] valores = new int[n];

            for (int i = 0; i < n; i++)
            {
                valores[i] = int.Parse(Console.ReadLine());

            }
            for (int j = 0; j < n; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    if (valores[i - 1] > valores[i])
                    {
                        int a = valores[i - 1];
                        int b = valores[i];
                        valores[i - 1] = b;
                        valores[i] = a;

                    }
                }
            }

            return valores;


        }
        static void opcao3()
        {
            /*
            Faça um programa contendo uma função booleana que recebe como
            parâmetro um vetor de palavras e retorne true caso as palavras estejam
            ordenadas em ordem crescente, ou false, caso contrário. O tamanho do
            vetor será informado pelo usuário. No método main exibir uma mensagem
            informando se o vetor está ou não em ordem crescente (não é para
            imprimir apenas true ou false).
            */

            Console.Write("Informe o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            string[] vetor = new string[n];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite as palavras que deseja ter no vetor: ");
                string nome = Console.ReadLine();
                vetor[i] = nome;
            }

            bool resposta = palavra(vetor);
            if (resposta == false)
            {
                Console.WriteLine("O vetor está ordenado.");
            }
            else
            {
                Console.WriteLine("O vetor não está em ordem.");
            }

        }


        static bool palavra(string[] vetor)
        {
            bool x = true;
            int cont = 1;
            int resultado = -1;

            for (; cont < vetor.Length; cont++)
            {
                resultado = vetor[cont - 1].CompareTo(vetor[cont]);
                if (resultado < 0)
                {
                    x = false;

                }
                else
                {
                    x = true;
                }
            }



            return x;
        }
        static void opcao4()
        {
            /*Faça um programa contendo uma função que recebe como parâmetro dois
            vetores ordenados, cada um com N valores inteiros, sendo N definido pelo
            usuário.A função deverá retornar um novo vetor, com 2xN elementos,
            intercalando os elementos dos dois vetrores lidos, mantendo esse terceiro
            vetor ordenado.
            Ex: vetor1:
            1 3 4 6 8

            vetor 2:
            2 4 5 7 9

            Retornará o vetor3:
            1 2 3 4 4 5 6 7 8 9*/
            Console.Write("Digite o tamanho dos 2 vetores: ");
            int tamanho = int.Parse(Console.ReadLine());
            int[] vetor1 = new int[tamanho];
            int[] vetor2 = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite o valor inteiro do primeiro vetor: ");
                int valor1 = int.Parse(Console.ReadLine());
                vetor1[i] = valor1;
                Console.Write("Digite o valor inteiro do segundo vetor: ");
                int valor2 = int.Parse(Console.ReadLine());
                vetor2[i] = valor2;

            }
            int[] vetor3 = new int[2 * tamanho];
            int k = 0;
            int k2 = 0;
            for (int i = 0; i < vetor3.Length; i++)
            {
                if (i % 2 == 0)
                {

                    vetor3[i] = vetor1[k];
                    k++;
                }
                else
                {

                    vetor3[i] = vetor2[k2];
                    k2++;

                }

            }

            Console.Write("O conjunto ordenado de forma seguencial do terceiro vetor é: \n");
            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.Write(vetor3[i] + "\t");
            }

        }

        static void opcao5()
        {
            /*Faça um procedimento que receba como parâmetro um vetor de inteiros e
           mostre na tela o maior valor, o menor valor e a média dos valores do vetor.
           O tamanho do vetor deve ser informado pelo usuário(maior ou igual a 2).
           Não é para atribuir valores inexistentes no vetor para o maior ou o menor.*/

            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());
            int[] vetor = new int[tamanho];
            int maior = int.MinValue;
            int menor = int.MaxValue;
            double soma = 0;
            double media;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite os valores inteiros para o vetor: ");
                int valores = int.Parse(Console.ReadLine());
                vetor[i] = valores;
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
                soma += vetor[i];
            }
            media = soma / vetor.Length;

            Console.WriteLine("O maior valor é: " + maior);
            Console.WriteLine("O menor valor é: " + menor);
            Console.WriteLine("A media dos valores é: " + media);

        }




        static void opcao6()
        {
            /*Faça um programa contendo uma função que receba como parâmetro as
            quantidades de linhas e de colunas de uma matriz, monte e retorne a
            matriz, conforme característica abaixo. A matriz retornada deve ser
            impressa no main, usando um procedimento Imprime.
            
            1   2         1   2   3          1   2   3   4
                    
            3   4         4   5   6          5   6   7   8
                                
                          7   8   9          9   10  11  12
                               
                                            13  14  15  16 */

            Console.WriteLine("Informe o tamanho de linhas e colunas da matriz: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[,] matriz2 = matriz(tamanho, tamanho);
            imprime(matriz2);



        }
        static void imprime(int[,] matriz)
        {

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        static int[,] matriz(int linhas, int colunas)
        {
            int valor = 1;
            int[,] matriz = new int[linhas, colunas];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = valor;
                    valor++;
                }
            }
            return matriz;
        }

        static void opcao7()
        {

            /*Faça um programa contendo uma função que recebe como parâmetro uma
            matriz de inteiros quadrada, cuja dimensão será informada pelo usuário e
            retorne a soma dos elementos que estão na diagonal principal da matriz.*/

            Console.WriteLine("Informe o tamanho da matriz: ");
            int tamanho = int.Parse(Console.ReadLine());


            int[,] matriz = new int[tamanho, tamanho];
            Console.WriteLine(Soma(matriz));
        }
        static int Soma(int[,] matriz)
        {
            int valor = 1;
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = valor;
                    valor++;
                    if (i == j)
                    {
                        soma += matriz[i, j];
                    }
                }
            }
            return soma;
        }

        static void opcao8()
        {
            /*Faça um programa contendo um procedimento que recebe como
            parâmetro uma matriz de inteiros quadrada, cuja dimensão será informada
            pelo usuário e mostre na tela apenas os elementos que estão na diagonal
            secundária da matriz.*/

            Console.WriteLine("Informe o tamanho da matriz: ");
            int tamanho = int.Parse(Console.ReadLine());
            int[,] m = matriz(tamanho, tamanho);
            diagonal2(m);

        }
        static void diagonal2(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i + j == matriz.GetLength(0)-1)
                    {
                        Console.Write(matriz[i, j] + "\t");   
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
        static void opcao9()
        {
            /*Faça um programa contendo um procedimento que represente com o
            símbolo ‘#’ a parte hachurada das matrizes abaixo e com espaço vazio as
            demais posições. Utilize uma matriz de char, quadrada, cuja dimensão será
            recebida como parâmetro.Mostre cada uma das matrizes na tela.*/

            Console.WriteLine("Digite o tamanho da matriz: ");
            int tamanho = int.Parse(Console.ReadLine());
            char[,] matriz = new char[tamanho, tamanho];
            MatrizDesenho1(matriz);
            Console.WriteLine();
            MatrizDesenho2(matriz);
            
        }
        static void MatrizDesenho1(char[,] matriz)
        {
            char n = '#';

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = i; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = n;   
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

        }


        static void MatrizDesenho2 (char[,] matriz)
        {
            char n = '#';
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    if (i == j)
                    {
                        matriz[i, j] = n;
                    }
                    else if (i + j == matriz.GetLength(0) - 1)
                    {
                        matriz[i, j] = n;
                    }
                    else
                    {
                        matriz[i,j] = ' ';
                    }

                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }


                    static void Main(string[] args)
        {
            int opçao;
            int resposta;
            double media;
            bool running = true;
            Console.WriteLine("Digite qual exercicio que deseja executar:\n1° Opção \n2° Opção \n3° Opção \n4° Opção \n5° Opção \n6° Opção \n7° Opção \n8° Opção \n9° Opção \n10° Opção \n0 Para sair.");
            opçao = int.Parse(Console.ReadLine());
            while (running)
            {
                switch (opçao)
                {
                    case 1:
                        resposta = Opçao1();
                        media = (double)resposta / 10;
                        Console.WriteLine("Os acertos foram: {0} A média é: {1}", resposta, media);
                        Console.WriteLine("Pressione qualquer tecla para voltar ou menu");
                        Console.ReadKey();

                        break;
                    case 2:
                        int[] vector = opcao2();
                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.WriteLine("Os valores em ordem crescente são:{0} ", vector[i]);
                        }
                        Console.WriteLine("Pressione qualquer tecla para voltar ou menu");
                        Console.ReadKey();

                        break;
                    case 3:
                        opcao3();
                        Console.WriteLine("Pressione qualquer tecla para voltar ou menu");
                        Console.ReadKey();

                        break;
                    case 4:
                        opcao4();
                        Console.WriteLine("Pressione qualquer tecla para voltar ou menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        opcao5();
                        Console.WriteLine("Pressione qualquer tecla para voltar ou menu");
                        Console.ReadKey();
                        break;
                    case 6:
                        opcao6();
                        Console.WriteLine("Pressione qualquer tecla para voltar ou menu");
                        Console.ReadKey();
                        break;
                    case 7:
                        opcao7();
                        Console.WriteLine("Pressione qualquer tecla para voltar ou menu");
                        Console.ReadKey();
                        break;
                    case 8:
                        opcao8();
                        Console.WriteLine("Pressione qualquer tecla para voltar ou menu");
                        Console.ReadKey();
                        break;
                    case 9:
                        opcao9();
                        Console.WriteLine("Pressione qualquer tecla para voltar ou menu");
                        Console.ReadKey();
                        break;
                    case 10:

                        break;
                    case 0:
                        Console.WriteLine("Obrigado!!");
                        running = false;
                        Console.WriteLine("Pressione qualquer tecla para fechar");
                        Console.ReadKey();
                        break;
                }


                Console.Clear();
                Console.WriteLine("Digite o numero do exercicio que deseja executar:\n1° Opção \n2° Opção \n3° Opção \n4° Opção \n5° Opção \n6° Opção \n7° Opção \n8° Opção \n9° Opção \n10° Opção ");
                opçao = int.Parse(Console.ReadLine());
            }


        }

    }
}



