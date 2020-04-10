using CinemaTest.AggregatesModel.ProjectionAggregate;
using CinemaTest.AggregatesModel.RoomAggregate;
using CinemaTest.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.Infrastructure.Repositories
{
    public class ProjectionRepository : IProjectionRepository
    {
        private readonly SearchingContext context;
       public IUnitOfWork UnitOfWork
        {
            get { return context; }
        }
        public ProjectionRepository(SearchingContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Projection AddProjection(Projection projection)
        {
            return context.Projections.Add(projection).Entity;
        }

        public async Task<Projection> FindProjectionByIdAsync(int id)
        {
            var projection = await context.Projections.Where(p => p.Id == id).SingleOrDefaultAsync();
            return projection;
        }

        public void RemoveProjection(Projection projection)
        {
            context.Projections.Remove(projection);
        }

        public Projection UpdateProjection(Projection projection)
        {
            return context.Projections.Update(projection).Entity;
        }

        public Film AddFilm(Film film)
        {
            return context.Films.Add(film).Entity;
        }

        public async Task<Film> FindFilmByIdAsync(int id)
        {
            var film = await context.Films.Where(p => p.Id == id).SingleOrDefaultAsync();
            return film;
        }

        public void RemoveFilm(Film film)
        {
            context.Films.Remove(film);
        }

        public Film UpdateFilm(Film film)
        {
            return context.Films.Update(film).Entity;
        }
     

        public IEnumerable<Projection> FindAllProjection()
        {
            return context.Projections;
        }

        public IEnumerable<Film> FindAllFilm()
        {
            return context.Films;
        }

        public async Task<List<Projection>> GetAllProjectionByFilmIdAsync(int filmId)
        {
           List<Projection> projections = await context.Projections.Where(p => p.FilmFK == filmId).ToListAsync();
            return projections;
        }

        public async Task<Film> GetFilmByNameAsync(string name)
        {
            return await context.Films.Where(f => f.Title == name).FirstOrDefaultAsync();
        }
    }
}
