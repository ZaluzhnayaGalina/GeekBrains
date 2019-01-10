using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth
{
    class AccountHelper
    {
        public static Account[] GetAccountsFromfile(string filepath)
        {

            string[] data = File.ReadAllLines(filepath);
            var accounts = new Account[data.Length/2];
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i] = new Account(data[2*i], data[2*i+1]);
            }
            return accounts;
        }

        public static bool Check(Account[] accounts, string login, string password)
        {
            foreach (var account in accounts)
            {
                if (account.Check(login, password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
