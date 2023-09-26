using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    internal class ListAccount
    {
        private static ListAccount instance;

        internal static ListAccount Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListAccount();
                }
                return instance; 
            }
            set => instance = value; 
        }

        List<Account> listAccounts;
        internal List<Account> ListAccounts { get => listAccounts; set => listAccounts = value; }
        ListAccount()
        {
            ListAccounts = new List<Account>();
            listAccounts.Add(new Account("huyhoang", "123456", true));
            listAccounts.Add(new Account("hubert", "123456", false));
        }
    }
}
