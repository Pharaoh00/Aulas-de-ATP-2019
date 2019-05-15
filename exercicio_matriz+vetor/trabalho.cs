using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:/Users/1206436/Desktop/test.txt");

            try
            {
                Console.Write("Digite a quantidade de participates: ");
                int participantes = int.Parse(Console.ReadLine());
                int inscricacao = 100001;
                for (int i = 0; i < participantes; i++)
                {
                    Console.Write("Digite o nome do candidato: ");
                    string candidato = Console.ReadLine();
                    Console.Write("Digite a Opção do Curso: ");
                    string curso = Console.ReadLine();
                    Console.Write("Digite a nota: ");
                    int nota = int.Parse(Console.ReadLine());
                    sw.WriteLine("{0}. Nome: {1} - Inscrição: {2} - Curso: {3} - Nota: {4}", i + 1, candidato, inscricacao, curso, nota);
                    inscricacao += 1;
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                sw.Close();
                Console.WriteLine("Executing finally block.");
            }
            try
            {
                StreamReader sr = new StreamReader("C:/Users/1206436/Desktop/test.txt");
                String line;
                line = sr.ReadLine();
                while(line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exeption: " + e.Message);
            }
            finally
            {
                
                Console.WriteLine("Executing finally block.");
            }
            Console.ReadLine();
        }
    }
}
