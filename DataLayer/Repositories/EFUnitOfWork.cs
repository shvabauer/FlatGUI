using DataLayer.EF;
using DataLayer.Entities;
using DataLayer.Interfaces;


namespace DataLayer.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private FilmContext db;
        private FilmRepository filmRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new FilmContext(connectionString);
        }

        public IRepository<Film> Films
        {
            get
            {
                if (filmRepository == null)
                {
                    filmRepository = new FilmRepository(db);
                }

                return filmRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
