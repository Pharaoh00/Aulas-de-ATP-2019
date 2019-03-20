using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double media = 0;
            double user_input = 0.0f;
            int homem = 0;
            int mulher = 0;
            bool running = true;
            string[] menu = new string[] { "1. Consumo de agua media",
                                           "2. Idade media v1",
                                           "3. Idade media v2" };
            while (running)
            {
                Console.WriteLine("-- Escolha as opções a baixo --");
                foreach(string options in menu)
                {
                    Console.WriteLine(options);
                }
                Console.Write("Opção: ");
                user_input = double.Parse(Console.ReadLine());
                switch (user_input)
                {
                    case 1:
                        for (int i = 1; i <= 8; i++)
                        {
                            Console.Write("Coloque o consumo de agua na sua residencia: ");
                            user_input = double.Parse(Console.ReadLine());
                            media += user_input;
                        }
                        Console.WriteLine("A media do consumo de aguá é: " + media / 8);
                        break;
                    case 2:
                        for (int i = 1; i <= 8; i++)
                        {
                            Console.WriteLine("Você é homem ou mulher?");
                            Console.WriteLine("1 para MULHER");
                            Console.WriteLine("2 para HOMEM");
                            user_input = double.Parse(Console.ReadLine());
                            if (user_input == 1)
                            {
                                mulher++;
                            }
                            else if (user_input == 2)
                            {
                                homem++;
                            }
                            Console.Write("Coloque sua idade: ");
                            user_input = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("A {0} homens e {1} mulheres", homem, mulher);
                        Console.WriteLine("A media de idade entre os homens é: {0} e a media entre as mulheres é {1}", homem / 8, mulher / 8);
                        break;
                    case 3:
                        break;

                    default:
                        Console.WriteLine("A opção '{0}' não é valida.", user_input);
                        break;






                }


                Console.ReadKey();
            }
        }
    }
}
