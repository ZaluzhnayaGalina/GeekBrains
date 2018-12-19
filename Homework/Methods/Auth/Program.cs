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
            /*Залужная
                *4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
             * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
             * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
             * С помощью цикла do while ограничить ввод пароля тремя попытками.*/
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
