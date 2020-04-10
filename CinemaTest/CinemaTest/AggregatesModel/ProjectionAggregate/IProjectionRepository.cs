using CinemaTest.AggregatesModel.RoomAggregate;
using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.ProjectionAggregate
{
    public interface IProjectionRepository : IRepository<Projection>
    {
        Projection AddProjection(Projection projection);
        Projection UpdateProjection(Projection projection);
        Task<Projection> FindProjectionByIdAsync(int id);
        void RemoveProjection(Projection projection);
        IEnumerable<Projection> FindAllProjection();
        Task<List<Projection>> GetAllProjectionByFilmIdAsync(int filmId);


        Film AddFilm(Film film);
        Film UpdateFilm(Film film);
        Task<Film> FindFilmByIdAsync(int id);
        void RemoveFilm(Film film);
        IEnumerable<Film> FindAllFilm();
        Task<Film> GetFilmByNameAsync(string name);





    }
}
