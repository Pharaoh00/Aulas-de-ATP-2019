using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_da_sala_times_e_gols
{
    class Program
    {
        static void Media_gols(string[] times, int[,] partidas, string time)
        {
            int linha_time = 0, partida = 0, soma = 0;
            double media = 0;

            for (int linha = 0; linha < times.Length; linha++)
            {
                if (time.Equals(times[linha]))
                {
                    linha_time = linha;
                }
            }

            Console.Write("( {0} ) :", times[linha_time]);
            for (int coluna = 0; coluna < partidas.GetLength(1); coluna++)
            {
                Console.Write(" [ {0} ] ", partidas[linha_time, coluna]);
                partida = coluna;
                soma += partidas[linha_time, coluna];
            }
            media = (double)(soma / times.Length);
            Console.WriteLine("\nA media de gols por partida do time {0} por {2} partida(s) é : {1} ", times[linha_time], media, partida + 1);
        }

        static void Main(string[] args)
        {
            int quantidade_times = 0, quantidade_partidas = 0;
            string time;
            Console.Write("Digite a quantidade de times: ");
            quantidade_times = int.Parse(Console.ReadLine());
            while (quantidade_times < 1)
            {
                Console.Write("Deve informar ao menos 1 time\n");
                Console.Write("Digite a quantidade de times: ");
                quantidade_times = int.Parse(Console.ReadLine());
            }

            string[] times = new string[quantidade_times];

            for (int c = 0; c < times.Length; c++)
            {
                Console.Write("Informe um Time ");
                times[c] = Console.ReadLine();
            }

            Console.Write("\nDigite a quantidade de partidas: ");
            quantidade_partidas = int.Parse(Console.ReadLine());
            while (quantidade_partidas < 1)
            {
                Console.Write("Deve informar ao menos 1 partida\n");
                Console.Write("Digite a quantidade de partidas: ");
                quantidade_partidas = int.Parse(Console.ReadLine());
            }

            int[,] partidas = new int[quantidade_times, quantidade_partidas];

            for (int linha = 0; linha < partidas.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < partidas.GetLength(1); coluna++)
                {
                    Console.Write("Digite a quantidade de gols na partida {0} do time {1} : ", coluna + 1, times[linha]);
                    partidas[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            for (int linha = 0; linha < partidas.GetLength(0); linha++)
            {
                Console.Write("( {0} ) gols: ", times[linha]);
                for (int coluna = 0; coluna < partidas.GetLength(1); coluna++)
                {
                    Console.Write(" [ {0} ] ", partidas[linha, coluna]);
                }
                Console.WriteLine();
            }

            Console.Write("\nDigite o nome de um time para verificar a media de gols: ");
            time = Console.ReadLine();

            Media_gols(times, partidas, time);

            Console.ReadKey();
        }

    }
}
