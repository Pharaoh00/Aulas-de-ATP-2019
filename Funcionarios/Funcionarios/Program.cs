using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Funcionarios
{
    class Program
    {
        const string PATH = "funcionarios.txt";
        static void Main(string[] args)
        {
            bool running = true;
            FileHandler fh = new FileHandler();
            Funcionario[] do_arquivo = fh.Ler(PATH);
            if (do_arquivo == null || do_arquivo.Length == 0)
            {
                do_arquivo = Funcionario.Preencher(do_arquivo, PATH, fh, true);
            }
            Console.WriteLine("Controle para Funcionários");
            Tools.showOpcoes();
            while (running)
            {
                Console.WriteLine("Digite help para ajuda.");
                Console.Write("Digite uma das opções: ");
                string opcoes = Console.ReadLine();
                switch (opcoes)
                {
                    case "inserir":
                        do_arquivo = Funcionario.Preencher(do_arquivo, PATH, fh);
                        break;
                    case "listar":
                        Tools.Listar(do_arquivo);
                        break;
                    case "pesquisar":
                        do_arquivo = fh.Ler(PATH);
                        Console.Write("Digite uma matricula para pesquisa: ");
                        string search = Console.ReadLine();
                        char[] numeros = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                        while (!Tools.customRegex(search, numeros))
                        {
                            Console.WriteLine("Opção '{0}' não é valida. Favor digitar novamente.", search);
                            Console.Write("Digite uma matricula para pesquisa: ");
                            search = Console.ReadLine();
                        }
                        Funcionario func = Tools.Pesquisar(search, do_arquivo);
                        if(func == null)
                        {
                            Console.WriteLine("Funcionario com a matricula {0} não encontrado.", search);
                        }
                        else
                        {
                            Console.Write("Funcionario com a matricula {0} - ", search);
                            Console.WriteLine("Nome: {0} - CPF: {2} - Salario: {3}",
                                              func.Nome, func.Matricula, func.Cpf, func.Salario);
                        }
                        break;
                    case "help":
                        Tools.showOpcoes();
                        break;
                    case "exit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opções '{0}' não é valida. Favor digitar novamente.", opcoes);
                        break;
                }
            }
        }
    }
}
