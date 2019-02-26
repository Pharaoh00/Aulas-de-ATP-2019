using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23_02
{
    class employee
    {

        private string name = null;
        private string last = null;
        private int age = 0;
        private string genre = null;
        private string email = null;

        //Constructor requer: Nome, Sobrenome, Idade e Genero
        public employee(string name, string last, int age, string genre)
        {
            this.name = name;
            this.last = last;
            this.age = age;
            this.genre = genre;
            this.email = String.Format("{0}_{1}.contato@empresa.br", this.name, this.last);
        }

        //Methods
        public string get_name()
        {
            return this.name;
        }
        public string get_last()
        {
            return this.last;
        }
        public int get_age()
        {
            return this.age;
        }
        public string get_genre()
        {
            return this.genre;
        }
        public string get_email()
        {
            return this.email;
        }
    }
}
