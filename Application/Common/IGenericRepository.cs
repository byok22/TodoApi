namespace TodoApi
{
     public interface IGenericRepository<T> where T : class
     {
         Task<IEnumerable<T>>  GetAll();
         Task<T> GetById(int id);        
         Task<T> Add(T entity);
         Task Update(T entity);
         Task Delete(T entity);
         Task Save();
     }
   
}