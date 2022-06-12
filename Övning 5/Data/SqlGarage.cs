using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Övning_5
{
    //public delegate void ItemAdded<T>(T item);
    public class SqlGarage<T> : ISqlGarage<T> where T : class, IEntity
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public interface IGarage<T> : ISqlGarage<T> where T : class, IEntity
        {
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        }

        public SqlGarage(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public event EventHandler<T>? ItemAdded;

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(string id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T instance)
        {
            try
            {
                _dbSet.Add(instance);
                ItemAdded?.Invoke(this, instance);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Remove(T instance)
        {
            _dbSet.Remove(instance);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
    //public class InstanceRemove<T, TId> : Garage<T, TId>
    //{

    //}
}
