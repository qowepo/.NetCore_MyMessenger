using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ASPServer
{
    [Serializable]
    public class User
    {
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }

        public User(string UserLogin, string UserPassword)
        {
            this.UserLogin = UserLogin;
            this.UserPassword = UserPassword;
        }

        public User(string UserName, string UserSurname, string UserLogin, string UserPassword)
        {
            this.UserName = UserName;
            this.UserSurname = UserSurname;
            this.UserLogin = UserLogin;
            this.UserPassword = UserPassword;
        }

        public User()
        {
            this.UserLogin = "System";
            this.UserPassword = "Server is running...";

        }

        public override string ToString()
        {
            string output = String.Format("{0}:{1}", UserLogin, UserPassword);
            return output;
        }
    }
}
