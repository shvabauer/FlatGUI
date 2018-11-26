using System.Collections.Generic;

using AutoMapper;

using BLogicLayer.DTO;
using BLogicLayer.Interfaces;

using DataLayer.Interfaces;
using DataLayer.Entities;


namespace BLogicLayer.Services
{
    public class FilmService : IFilmService
    {
        IUnitOfWork Database { get; set; }

        public FilmService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<FilmDTO> GetFilms()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Film, FilmDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Film>, List<FilmDTO>>(Database.Films.GetAll());
        }
    }
}
