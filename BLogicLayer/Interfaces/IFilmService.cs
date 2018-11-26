using System.Collections.Generic;

using BLogicLayer.DTO;


namespace BLogicLayer.Interfaces
{
    public interface IFilmService
    {
        IEnumerable<FilmDTO> GetFilms();
    }
}
