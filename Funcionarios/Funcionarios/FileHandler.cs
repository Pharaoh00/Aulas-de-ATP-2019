using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Funcionarios
{
    class FileHandler
    {
        private StreamWriter sw;
        private StreamReader sr;

        public FileHandler() { }

        // Caso for necessario gravar multiplos funcionarios
        public void Gravar(Funcionario[] funcionarios, string path, bool chain=true)
        {
            this.sw = new StreamWriter(path, chain);
            for(int i = 0; i < funcionarios.Length; i++)
            {
                this.sw.WriteLine("{0};{1};{2};{3}", 
                    funcionarios[i].Nome, funcionarios[i].Matricula, 
                    funcionarios[i].Cpf, funcionarios[i].Salario);
            }
            this.sw.Close();
        }

        // Caso for necessario gravar 1 unico funcionario
        public void Gravar(Funcionario funcionario, string path, bool chain=true)
        {
            this.sw = new StreamWriter(path, chain);
            this.sw.WriteLine("{0};{1};{2};{3}",
                              funcionario.Nome, funcionario.Matricula,
                              funcionario.Cpf, funcionario.Salario);
            this.sw.Close();
        }

        public Funcionario[] Ler(string path)
        {
            string line;
            Funcionario[] funcionarios = null;
            if (!File.Exists(path))
            {
                Console.WriteLine("Arquivo {0} não existe.", path);
            }
            else
            {
                this.sr = new StreamReader(path);
                funcionarios = new Funcionario[File.ReadAllLines(path).Length];
                for (int i = 0; i < File.ReadAllLines(path).Length; i++)
                {
                    line = sr.ReadLine();
                    string[] data = line.Split(';');
                    funcionarios[i] = new Funcionario(data[0], data[1], data[2], data[3]); // criando um novo funcionario
                }
                this.sr.Close();
            }
            
            return funcionarios;
        }
        // Motodo para a crianção do arquivo. 
        // Caso o arquivo não existe ainda, irá criar um arquivo vazio com o nome desejado.
        public void createFile(string path)
        {
            this.sw = new StreamWriter(path);
            sw.Close();
        }
    }
}
