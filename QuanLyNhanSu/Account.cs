using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    internal class Account
    {
        private string user;
        private string password;
        private bool accountType;

        public Account(string user, string password, bool accountType)
        {
            this.user = user;
            this.password = password;
            this.accountType = accountType;
        }

        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public bool AccountType { get => accountType; set => accountType = value; }
    }
}
