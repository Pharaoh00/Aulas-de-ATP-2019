using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercicios_vetor_matriz
{
    class Program
    {

        // -- Procedimentos & Funções

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

        static void exercicioBonus1(string[] times, int[,] matrix)
        {

        }

        // -- Fim - Metodos/Procedimentos & Funções
        static void Main(string[] args)
        {

            Console.WriteLine("Exercícios Avaliativos Vetores e Matriz");
            string[] menu = new string[11];
            for(int i = 0; i < menu.Length; i++)
            {
                menu[i] = String.Format("{0} - Para questão: {1}",i+1,i+1);
                if(i == 10)
                {
                    menu[i] = String.Format("{0} - Exercicio Bonus {1}: Time de Futebol", i + 1, i-9);
                }
            }
            
            bool running = true;

            while (running)
            {
                foreach(string opcao in menu)
                {
                    Console.WriteLine(opcao);
                }
                Console.Write("\nDigite a opção desejada: ");
                int opcoes = int.Parse(Console.ReadLine());
                switch (opcoes)
                {
                    case 0:
                        Console.WriteLine("Obrigado por usar o meu programa.");
                        running = false;
                        break;
                    case 1:
                        int count = 0;
                        char[] gabarito = { 'A', 'A', 'B', 'D', 'E', 'C', 'B', 'D', 'B', 'A' };
                        char[] respostas = new char[10];
                        Console.WriteLine("-- Digite o seu gabarito --");
                        
                        while (count < respostas.Length)
                        {
                            Console.Write("Digite sua resposta da questão {0}: ", count + 1);
                            string r = Console.ReadLine().ToUpper();
                            if (Regex.IsMatch(r, @"^[A-E]+$"))
                            {
                                respostas[count] = char.Parse(r);
                                Console.WriteLine("Nota {0} adicionada.", r);
                                count++;
                            }
                            else
                            {
                                Console.WriteLine("Opção {0} invalida. Digite novamente.", r);
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

                        for(int i = 0; i < respostas.Length; i++)
                        {
                            Console.Write("{0} ", respostas[i]);
                        }

                        exercicio1(gabarito, respostas);

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        string[] times = { "América", "Atlético", "Boa Esporte", "Caldense", "Cruzeiro", "Democrata"};
                        //int[,] gols_time = new int[times.Length, times.Length];
                        Random rnd = new Random();
                        string[,] gols_time = { {times[0],"1", "6" },
                                                {times[0],"2", "2" },
                                                {times[0],"3", "5" },
                                                {times[0],"4", "1" },
                                                {times[0],"5", "2" },
                                                {times[0],"6", "3" } };
                        Console.WriteLine("Time: {0} - Partida: {1} - Gols: {2}", gols_time[1, 0], gols_time[1, 1], gols_time[1, 2]);
                        for(int i = 0; i < gols_time.GetLength(0); i++)
                        {
                            for(int j = 0; j < gols_time.GetLength(1); j++)
                            {
                                Console.WriteLine("Time: {0} - Partida: {1} - Gols: {2}", gols_time[i,0], gols_time[i, 1], gols_time[i, 2]);
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.Write("Opção {0} não é valida.", opcoes);
                        break;
                }
            }
        
            Console.ReadKey();
        }
    }
}
