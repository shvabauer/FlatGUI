using DataLayer.Entities;


namespace DataLayer.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Film> Films { get; }
        void Save();
    }
}
