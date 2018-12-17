using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth
{
    class Program
    {
        static void Main(string[] args)
        {
            int attemts = 0;
            bool check = false;
            do
            {
                var login = Console.ReadLine();
                var password = Console.ReadLine();
                check = Check(login, password);
                attemts++;
            } while (attemts<3 && !check);
            if (check)
                Console.WriteLine("Авторизация пройдена успешно");
            else
                Console.WriteLine("Авторизация не пройдена");
            Console.ReadLine();
        }

        static bool Check(string login, string pasword)
        {
            return login == "root" && pasword == "GeekBrains";
        }
    }
}
