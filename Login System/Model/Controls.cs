using Login_System.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_System.Model
{
    public class Controls
    {
        public bool have;
        public string message = "";

        public bool access(string login, string password)
        {
            LoginDalCommand logindal = new LoginDalCommand();
            have = logindal.veriLogin(login, password);
            if (!logindal.message.Equals(""))
            {
                this.message = logindal.message;
            }
            return have;
        }

        public string register(string name, string email,string login, string password, string confPassword)
        {
            LoginDalCommand logindal = new LoginDalCommand();
            this.message = logindal.register(name, email, login, password, confPassword);
            if(logindal.have)
            {
                this.have = true;
            }
            return message;
        }
    }
}
