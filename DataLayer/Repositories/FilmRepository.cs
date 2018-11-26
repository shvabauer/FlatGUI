using System;
using System.Collections.Generic;

using DataLayer.Interfaces;
using DataLayer.Entities;
using DataLayer.EF;


namespace DataLayer.Repositories
{
    public class FilmRepository : IRepository<Film>
    {
        private FilmContext db;

        public FilmRepository(FilmContext context)
        {
            db = context;
        }

        public IEnumerable<Film> GetAll()
        {
            return db.Films;
        }


        //TODO: Дописать методы
        public void Create(Film item)
        {
            throw new NotImplementedException();
        }

        public void Update(Film item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Film Get(int id)
        {
            return db.Films.Find(id);
        }

        public IEnumerable<Film> Find(Func<Film, bool> predicate)
        {
            throw new NotImplementedException();
        }   
    }
}
