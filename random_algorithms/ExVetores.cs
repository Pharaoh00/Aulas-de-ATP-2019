using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExVetores
{
    class Program
    {
        static public void exercicio1()
        {
            int[] valores = new int[10];
            double media = 0;
            double soma = 0;
            for(int i = 0; i < valores.Length; i++)
            {
                Console.Write("Digite um valor inteiro: ");
                int numb = int.Parse(Console.ReadLine());
                valores[i] = numb;
                soma += valores[i];
            }
            media = soma / 10;
            Console.WriteLine("A media entre os numeros escolhidos são: {0}.", media);
            Console.Write("Os valores menores que a media são: ");
            for(int i = 0; i < valores.Length; i++)
            {
                if(valores[i] < media)
                {
                    Console.Write(" "+valores[i]);
                }
            }
            Console.Write("\nOs valores maiores que a media são: ");
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] > media)
                {
                    Console.Write(" " + valores[i]);
                }
            }
        }

        static public void exercicio2()
        {
            int[] joao = new int[8];
            int[] maria = new int[8];
            int[] branco = new int[8];
            int[] nulo = new int[8];

            int voto_masc_joao = 0;
            int voto_fem_joao = 0;

            int voto_masc_maria = 0;
            int voto_fem_maria = 0;

            int voto_masc_branco = 0;
            int voto_fem_branco = 0;

            int voto_masc_nulo = 0;
            int voto_fem_nulo = 0;

            Console.WriteLine("Digite os valores para votar");
            for(int i = 0; i < joao.Length; i++)
            {
                Console.WriteLine("Digite o nome do canditado.\n1 - para Masculino.\n2 - Para Feminino.");
                Console.Write("Digite a opção para o candidato: ");
                string candidato = Console.ReadLine();
                Console.Write("Digite o genero: ");
                int genero = int.Parse(Console.ReadLine());
                switch (candidato)
                {
                    case "joao":
                        joao[i] = genero;
                        break;
                    case "maria":
                        maria[i] = genero;
                        break;
                    case "branco":
                        branco[i] = genero;
                        break;
                    case "nulo":
                        joao[i] = genero;
                        break;
                }
            }
            for(int i = 0; i < joao.Length; i++)
            {
                if(joao[i] == 1)
                {
                    voto_masc_joao++;
                }
                else if(joao[i] == 2)
                {
                    voto_fem_joao++;
                }

                if (maria[i] == 1)
                {
                    voto_masc_maria++;
                }
                else if (joao[i] == 2)
                {
                    voto_fem_maria++;
                }

                if (branco[i] == 1)
                {
                    voto_masc_branco++;
                }
                else if (joao[i] == 2)
                {
                    voto_fem_branco++;
                }

                if (joao[i] == 1)
                {
                    voto_masc_nulo++;
                }
                else if (joao[i] == 2)
                {
                    voto_fem_nulo++;
                }
            }
            Console.WriteLine("O candidato João recebeu: {0} votos. Com {1} votos masculonos e {2} votos femininos.",
                             (voto_masc_joao + voto_fem_joao), voto_masc_joao, voto_fem_joao);
            Console.WriteLine("O candidato Maria recebeu: {0} votos. Com {1} votos masculonos e {2} votos femininos.",
                             (voto_masc_maria + voto_fem_maria), voto_masc_maria, voto_fem_maria);

            Console.WriteLine("Branco recebeu: {0} votos. Com {1} votos masculonos e {2} votos femininos.",
                             (voto_masc_branco + voto_fem_branco), voto_masc_branco, voto_fem_branco);
            Console.WriteLine("Nulo recebeu: {0} votos. Com {1} votos masculonos e {2} votos femininos.",
                             (voto_masc_nulo + voto_fem_nulo), voto_masc_nulo, voto_fem_nulo);
        }


        static public void easyLoop<T>(T[] vector, string msg1, string msg2, int cnt)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write("{0} da pessoa {1}: ", msg1, cnt);
                    var peso = (T) Convert.ChangeType(Console.ReadLine(),typeof(T));
                    vector[i] = peso;
                }
                else
                {
                    Console.Write("{0} da pessoa {1}", msg2, cnt);
                    var idade = (T) Convert.ChangeType(Console.ReadLine(), typeof(T));
                    vector[i] = idade;
                    cnt++;
                }
            }
        }
        static public void exercicio3()
        {
            double[] masc = new double[6*2];
            double[] fem = new double[6*2];
            int count = 1;
            double media = 0;

            Console.WriteLine("Preecha os valores do peso e idade dos generos masculinos: ");
            easyLoop(masc, "Peso", "Idade", count);
            //for (int i = 0; i < masc.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write("Peso da pessoa {0}: ", count);
            //        double peso = double.Parse(Console.ReadLine());
            //        masc[i] = peso;
            //    }
            //    else
            //    {
            //        Console.Write("Idade da pessoa {0}: ", count);
            //        double idade = double.Parse(Console.ReadLine());
            //        masc[i] = idade;
            //        count++;
            //    }
            //}

            count = 0; // resetando count para 0 para o vetor feminino
            Console.WriteLine("Preecha os valores do peso e idade dos generos feminino: ");
            easyLoop(fem, "Peso", "Idade", count);
            //for (int i = 0; i < masc.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write("Peso da pessoa {0}: ", count);
            //        double peso = double.Parse(Console.ReadLine());
            //        fem[i] = peso;

            //    }
            //    else
            //    {
            //        Console.Write("Idade da pessoa {0}: ", count);
            //        double idade = double.Parse(Console.ReadLine());
            //        fem[i] = idade;
            //        count++;
            //    }
            //}

            Console.Write("O peso das mulheres foi: ");
            for(int i = 0; i < fem.Length; i++)
            {
                if (i % 2 == 0)
                {
                    media += masc[i];
                    if (i == 0)
                    {
                        Console.Write("{0}, ", fem[i]);
                    }
                    else if (i == fem.Length - 1)
                    {
                        Console.Write(" {0}.", fem[i]);
                    }
                    else
                    {
                        Console.Write("{0}, ", fem[i]);
                    }
                }
            }
            media = media / 6;
            Console.WriteLine("\nA media do pesos dos homens é: {0}", media);

            Console.Write("A idade dos homens: ");
            for (int i = 0; i < masc.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (i == 0)
                    {
                        Console.Write("{0}, ", masc[i]);
                    }
                    else if (i == fem.Length - 1)
                    {
                        Console.Write(" {0}.", masc[i]);
                    }
                    else
                    {
                        Console.Write("{0}, ", masc[i]);
                    }
                }
            }
            media = 0.0f;
            for (int i = 0; i < fem.Length; i++)
            {
                if (i % 2 != 0)
                {
                    media += fem[i];
                }
            }
            media = media / 6;
            Console.WriteLine("\nA media da idade das mulheres é: {0}", media);
        }

        static void Main(string[] args)
        {
            Console.Write("Selecione opções de 1 a 5: ");
            string opcoes = Console.ReadLine();
            switch (opcoes)
            {
                case "1":
                    exercicio1();
                    break;
                case "2":
                    exercicio2();
                    break;
                case "3":
                    exercicio3();
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("A opção: {0} não é valida.", opcoes);
                    break;
            }
            Console.ReadKey();
        }
    }
}
