

using LibrarySystem.Abstraction;

namespace LibrarySystem.Services
{
    public class Authentication : IAuthentication
    {
        IStorage _storage;

        public Authentication(IStorage storage)
        {
            _storage = storage;
        }
        public bool Login(string username, string password)
        {
            var personsList = _storage.GetData<Person>();
            var person = personsList.FirstOrDefault(u => u.Username == username 
                                                    && u.Password == password);
            if (person != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Logout()
        {

            throw new NotImplementedException();
        }

        public bool Register(Person person)
        {

            throw new NotImplementedException();
        }
    }
}
