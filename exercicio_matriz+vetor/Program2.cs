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

        static void Main(string[] args)
        {


            string[] times = { "América", "Atlético", "Boa Esporte", "Caldense", "Cruzeiro", "Democrata" };
            Random rnd = new Random();
            string[,] gols_time = { {times[0],"1", "6" },
                                                {times[0],"2", "2" },
                                                {times[0],"3", "5" },
                                                {times[0],"4", "1" },
                                                {times[0],"5", "2" },
                                                {times[0],"6", "3" } };

            Console.WriteLine("Time: {0} - Partida: {1} - Gols: {2}", gols_time[1, 0], gols_time[1, 1], gols_time[1, 2]);
            for (int i = 0; i < gols_time.GetLength(0); i++)
            {
                for (int j = 0; j < gols_time.GetLength(1); j++)
                {
                    Console.WriteLine("Time: {0} - Partida: {1} - Gols: {2}", gols_time[i, 0], gols_time[i, 1], gols_time[i, 2]);
                    //Console.Write(gols_time[i, j] + "\t");
                }
                Console.WriteLine();
            }

    Console.ReadKey();
        }
    }
}
