

using LibrarySystem.Abstraction;
using LibrarySystem.Entities;

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

        public string Logout(string name)
        {
            return $"{name}, you have successfully" +
                         $" logged out of your account.";
        }

        public bool Register(Person person)
        {
            var personsList = _storage.GetData<Person>();
            var samePerson = personsList.FirstOrDefault(u => u.Username == person.Username);
            if (samePerson == null)
            {
                if (person.Role == "1")
                {
                    (person as Member).RegisterDate = DateTime.Today;
                }
                else
                {
                    (person as Librarian).PersonalityCode = Guid.NewGuid();
                }

                personsList.Add(person);
                _storage.SetData<Person>(personsList);
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
