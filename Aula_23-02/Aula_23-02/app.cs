using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23_02
{
    class app
    {

        private bool running = true;
        /*
        private string[] menu = {"   ____                         _           _       _",
                                   "|  _ \                       (_)         | |     | |",
                                   "| |_) | ___ _ __ ___   __   ___ _ __   __| | ___ | |",
                                   "|  _ < / _ \ '_ ` _ \  \ \ / / | '_ \ / _` |/ _ \| |",
                                   "| |_) |  __/ | | | | |  \ V /| | | | | (_| | (_) |_|",
                                   "|____/ \___|_| |_| |_|   \_/ |_|_| |_|\__,_|\___/(_) "};
                                   */

        public bool get_state()
        {
            return this.running;
        }
        public void make_menu()
        {
            /*
            for(int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(i);
            }
            */
            Console.WriteLine("__ Bem Vindo __");
            Console.WriteLine("-- Menu --");
            Console.WriteLine("1. Adicionar Nome");
            Console.WriteLine("2. Adicionar Sobrenome");
            Console.WriteLine("3. Adicionar idade");
            Console.WriteLine("4. Adicionar genero");
        }

    }
}
