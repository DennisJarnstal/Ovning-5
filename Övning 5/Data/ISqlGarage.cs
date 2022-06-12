namespace Övning_5
{

    public interface IWriteGarage<in T>
    {
        void Add(T instance);
        void Remove(T instance);
        void Save();

    }
    public interface IReadGarage<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(string id);
    }
    public interface ISqlGarage<T> : IReadGarage<T>, IWriteGarage<T> where T : IEntity
    {
        //void Add(T instance);
        //void Remove(T instance);
        //void Save();
    }
}