using LibrarySystem.Entities;

namespace LibrarySystem.Abstraction
{
    public interface IStorage
    {
        List<Book>? GetAvailableBooks();

        List<T> GetData<T>();

        void SetData<T>(List<T> entities);
    }
}
