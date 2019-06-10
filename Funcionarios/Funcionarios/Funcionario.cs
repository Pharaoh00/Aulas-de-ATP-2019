using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Funcionario
    {
        private string nome;
        private string matricula;
        private string cpf;
        private string salario;

        // Caso precisar de "null"
        public Funcionario()
        {
            this.nome = "indefinido";
            this.matricula = "indefinido";
            this.cpf = "indefinido";
            this.salario = "indefinido";
        }

        public Funcionario(string nome, string matricula, string salario)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.salario = "998"; //Salario minimo em 2019
        }

        public Funcionario(string nome, string matricula, string cpf, string salario)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.cpf = cpf;
            this.salario = salario;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Salario { get => salario; set => salario = value; }

        public static Funcionario[] Preencher(Funcionario[] funcionario, string path, FileHandler fh, bool flag = false)
        {
            /*
             * A função requer um vetor de funcionarios, um caminho para o arquivo e uma classe para gravar e ler o arquivo.
             * flag serve para mudar o modo:
             * Se for verdadeira, o vetor de funcionarios passado é nulo ou quantidade de linhas zero.
             * Nesse modo o arquivo é criado, e não é checado se a matricula já existe.
             * Se for falso, o vetor passado há funcionarios e assim a matricula é checada.
             * 
             * Retorna um vetor de Funcionario, para continuar recursivamente o processo.
             */

            Funcionario[] retorno = funcionario;
            char[] letras = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'w', 'z' };
            char[] letras_space = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'w', 'z', ' ' };
            char[] numeros = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] numeros_salario = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ','};
            bool insert_mode = true; // Para continuar dentro da opção "inserir" no main, caso a matricula já exista, pergunte novamente.
            string matricula = null;
            string nome = null;
            string cpf = null;
            string salario = null;
            Funcionario func = null;

            if (flag)
            {
                /*
                 * Para caso não exista o banco de dados,
                 * inserir pelo menos um funcionario para criar o arquivo.
                 */

                fh.createFile(path);
                Console.WriteLine("Arquivo não há nenhum funcionários. Favor adicionar pelo menos um.");
                Console.Write("Insira a Matricula do funcionario: ");
                matricula = Console.ReadLine();
                while(!Tools.customRegex(matricula, numeros))
                {
                    Console.WriteLine("Opção '{0}' não é valida. Favor digitar novamente.", matricula);
                    Console.Write("Insira a Matricula do funcionario: ");
                    matricula = Console.ReadLine();
                }
                Console.Write("Insira o Nome do funcionario: ");
                nome = Console.ReadLine().ToLower();
                while (!Tools.customRegex(nome, letras_space))
                {
                    Console.WriteLine("Opção '{0}' não é valida. Favor digitar novamente.", nome);
                    Console.Write("Insira o Nome do funcionario: ");
                    nome = Console.ReadLine().ToLower();
                }
                Console.Write("Insira o CPF do funcionario: ");
                cpf = Console.ReadLine();
                while (!Tools.customRegex(cpf, numeros))
                {
                    Console.WriteLine("Opção '{0}' não é valida. Favor digitar novamente.", cpf);
                    Console.Write("Insira o CPF do funcionario: ");
                    cpf = Console.ReadLine();
                }
                Console.Write("Insira o Salario do funcionario: ");
                salario = Console.ReadLine();
                while (!Tools.customRegex(salario, numeros_salario))
                {
                    Console.WriteLine("Opção '{0}' não é valida. Favor digitar novamente.", salario);
                    Console.Write("Insira o Salario do funcionario: ");
                    salario = Console.ReadLine();
                }
                if (salario == "" || salario == null)
                {
                    // Caso não seja passado o salario, irá ser o padrão da classe.
                    func = new Funcionario(nome, matricula, cpf);
                }
                else
                {
                    func = new Funcionario(nome, matricula, cpf, salario);
                }
                fh.Gravar(func, path);
                Console.WriteLine("Funcionario {0} gravado com sucesso.", nome);
                retorno = fh.Ler(path); // Para atualizar o arquivo
            }
            else if (!flag)
            {
                insert_mode = true;
                while (insert_mode)
                {
                    Console.Write("Insira a Matricula do funcionario: ");
                    matricula = Console.ReadLine();
                    while (!Tools.customRegex(matricula, numeros))
                    {
                        Console.WriteLine("Opção '{0}' não é valida. Favor digitar novamente.", matricula);
                        Console.Write("Insira a Matricula do funcionario: ");
                        matricula = Console.ReadLine();
                    }
                    if (!Tools.CheckMatricula(matricula, funcionario))
                    {
                        // Inserindo o nome
                        Console.Write("Insira o Nome do funcionario: ");
                        nome = Console.ReadLine().ToLower();
                        // Validando se há somente letras no nome passado
                        while (!Tools.customRegex(nome, letras_space))
                        {
                            Console.WriteLine("Opção '{0}' não é valida. Favor digitar novamente.", nome);
                            Console.Write("Insira o Nome do funcionario: ");
                            nome = Console.ReadLine().ToLower();
                        }
                        //Inserindo o CPF
                        Console.Write("Insira o CPF do funcionario: ");
                        cpf = Console.ReadLine().ToLower();
                        //Validando se há somente numeros no CPF
                        while (!Tools.customRegex(cpf, numeros))
                        {
                            Console.WriteLine("Opção '{0}' não é valida. Favor digitar novamente.", cpf);
                            Console.Write("Insira o CPF do funcionario: ");
                            cpf = Console.ReadLine().ToLower();
                        }
                        //Inserindo o salario
                        Console.Write("Insira o Salario do funcionario: ");
                        salario = Console.ReadLine().ToLower();
                        //Validando se há somente numeros no salario
                        while (!Tools.customRegex(salario, numeros_salario))
                        {
                            Console.WriteLine("Opção '{0}' não é valida. Favor digitar novamente.", salario);
                            Console.Write("Insira o Salario do funcionario: ");
                            salario = Console.ReadLine().ToLower();
                        }
                        if (salario == "" || salario == null)
                        {
                            // Caso não seja passado o salario, irá ser o padrão da classe.
                            func = new Funcionario(nome, matricula, cpf);
                        }
                        else
                        {
                            func = new Funcionario(nome, matricula, cpf, salario);
                        }
                        fh.Gravar(func, path);
                        Console.WriteLine("Funcionario {0} gravado com sucesso.", nome);
                        retorno = fh.Ler(path); // Para atualizar o arquivo
                        insert_mode = false;
                    }
                    else
                    {
                        Console.WriteLine("Já existe um funcionario com a matricula {0}. Digite novamente.", matricula);
                    }
                }
            }
            return retorno;
        }
    }
}
