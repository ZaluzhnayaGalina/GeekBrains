using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth
{
    class Program
    {
        /*Залужная
        *3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
         * Создайте структуру Account, содержащую Login и Password.*/
        static void Main(string[] args)
        {
            var accounts = AccountHelper.GetAccountsFromfile("accounts.txt");

            bool check = false;
            for (int i = 1; i <= 3 && !check; i++)
            {
                Console.WriteLine("Login:");
                string login = Console.ReadLine();
                Console.WriteLine("Password:");
                string password = Console.ReadLine();
                check = AccountHelper.Check(accounts, login, password);
            }
            if (check)
                Console.WriteLine("Вход успешно выполнен");
            else
            {
                Console.WriteLine("Авторизация не пройдена!");
            }
            Console.ReadLine();

        }
    }

    public struct Account
    {
        public string Login;
        private string _password;

        public Account(string login, string password)
        {
            Login = login;
            _password = password;
        }

        public bool Check(string login, string password)
        {
            return Login == login && _password == password;
        }
    }
}
