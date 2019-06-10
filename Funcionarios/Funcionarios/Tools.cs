using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Tools
    {
        //My custom "regex"
        public static bool customRegex(string input, char[] limit)
        {
            /* 
             * A função requer como parametro uma string a ser comparada,
             * e um vetor de char para comparar.
             * Se TODOS os characteres estiverem no vetor "limit", a função volta verdadeira,
             * pois todos os characteres a ser comparado existem.
             * Se caso não houver, a função retorna falso, pois existe um character que não
             * esta no vetor "limit".
             */

            bool flag = true;

            int countI = 0;
            int countJ = 0;

            if (input != null) // Alguns problemas quando é passado uma string nula
            {
                //O primeiro while também aceita a flag como variavel pois,
                //se-somente-se existir um character que exista no vetor, continue.
                while (countI < input.Length && flag == true)
                {
                    while (countJ < limit.Length)
                    {
                        if (input[countI].Equals(limit[countJ]))
                        {
                            flag = true; // Caso ache, flag é verdade, e pare de procurar.
                            break;
                        }
                        else
                        {
                            flag = false; // Caso não, flag é falso.
                            countJ++; // Continue procurando.
                        }
                    }
                    countJ = 0; // Reseta o valor do segundo while, para a proxima interação.
                    countI++;
                }
            }
            else
            {
                flag = false; // Retorna falso porque null nunca irá existir. 
            }

            return flag;
        }

        public static bool CheckMatricula(string matricula, Funcionario[] func)
        {
            /*
             * A função requer uma string para comparar e um vetor de funcionarios para ser comparado.
             * Retorna verdadeira se a matricula ja exist no vetor.
             * Retorna falso se a matricula não existe no vetor.
             */

            bool flag = false;

            for(int i = 0; i < func.Length; i++)
            {
                if (matricula.Equals(func[i].Matricula))
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public static Funcionario Pesquisar(string matricula, Funcionario[] funcionarios)
        {
            /*
             * A função recebe como parametro uma string para pesquisar, e uma lista de funcionarios para ser pesquisado.
             * Geralmente a lista dos funcionarios a ser pesquisado é a lista que esta no banco de dados.
             * 
             * Se o funcionario existir o retorna.
             */

            Funcionario retorno = null;
            for (int i = 0; i < funcionarios.Length; i++)
            {
                if (matricula.Equals(funcionarios[i].Matricula))
                {
                    retorno = funcionarios[i];
                    break; // Caso haja, pare de procurar.
                }
            }
            return retorno;
        }

        public static void Listar(Funcionario[] funcionarios)
        {
            // Para facilitar, e "limpar" o main.
            for (int i = 0; i < funcionarios.Length; i++)
            {
                Console.WriteLine("Nome: {0} - Matricula: {1} - CPF: {2} - Salario: {3}",
                    funcionarios[i].Nome, funcionarios[i].Matricula, funcionarios[i].Cpf, funcionarios[i].Salario);
            }
        }

        public static void showOpcoes()
        {
            // Facilitar no main.
            Console.WriteLine("-- Opções --");
            Console.WriteLine("'inserir' - Para adicionar um funcionario ao banco de dados.");
            Console.WriteLine("'listar' - Para mostrar todos os funcioarios no banco de dados.");
            Console.WriteLine("'pesquisar' - Para pesquisar se um funcionario existe no banco de dados.");
        }
    }
}
