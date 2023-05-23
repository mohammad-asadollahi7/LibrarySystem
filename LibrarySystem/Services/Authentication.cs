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
        public Person Login(string username, string password)
        {
            var personsList = _storage.GetData<Person>();
            var person = personsList.FirstOrDefault(u => u.Username == username
                                                    && u.Password == password);
            return person;
        }


        public bool Register(Person person)
        {
            var personsList = _storage.GetData<Person>();
            var samePerson = personsList.FirstOrDefault(u => u.Username == person.Username);
            if (samePerson == null)
            {
                if (person is Member)
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
