using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23_02
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<employee> employee_list = new List<employee>();
            List<int> sum_age = new List<int>();
            app main_app = new app();
            string user_input = Console.ReadLine();

            /*
            employee e1 = new employee("Hamon-Rá", "Taveira", 26, "Male");
            employee e2 = new employee("Matheus", "Test", 20, "Male");
            Console.WriteLine(e1.get_email());
            employee_list.Add(e1);
            employee_list.Add(e2);
            */

            while (main_app.get_state())
            {
                main_app.make_menu();
            }

            for (int i = 0; i < employee_list.Count; i++)
            {
                Console.WriteLine(employee_list[i].get_email());
                sum_age.Add(employee_list[i].get_age());
            }

            Console.WriteLine(sum_age.Sum()/sum_age.Count);
            
            Console.ReadKey();

        }
    }
}
