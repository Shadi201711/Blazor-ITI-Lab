namespace Day3.Services
{
    public interface IServices<T>
    {
       Task <List<T>> GetAll();
       Task<T>GetById(int id);
        Task Add (T item);
        Task Update(int id,T item);

        Task Delete(int id);
    }
}
