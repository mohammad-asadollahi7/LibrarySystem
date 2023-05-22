using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Abstraction
{
    public interface IAuthentication
    {
        bool Register(Person person);
        Person Login(string username, string password);
        string Logout(string name);

    }
}
