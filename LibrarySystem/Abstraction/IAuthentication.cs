using LibrarySystem.Entities;

namespace LibrarySystem.Abstraction
{
    public interface IAuthentication
    {
        bool Register(Person person);
        Person Login(string username, string password);
    }
}
