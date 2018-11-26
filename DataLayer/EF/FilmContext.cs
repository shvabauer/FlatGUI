using System.Data.Entity;

using DataLayer.Entities;


namespace DataLayer.EF
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        static FilmContext()
        {

        }
        
        public FilmContext(string connectionString) : base(connectionString)
        {

        }
    }
}
