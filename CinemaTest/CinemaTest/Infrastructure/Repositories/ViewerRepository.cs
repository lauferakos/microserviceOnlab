using CinemaTest.AggregatesModel.ViewerAggregate;
using CinemaTest.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.Infrastructure.Repositories
{
    public class ViewerRepository : IViewerRepository
    {
        private readonly SearchingContext context;
       public IUnitOfWork UnitOfWork
        {
            get { return context; }
        }

        public ViewerRepository(SearchingContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Viewer Add(Viewer viewer)
        {
            return context.Viewers.Add(viewer).Entity;
        }

        public async Task<Viewer> FindByIdAsync(int id)
        {
            var viewer = await context.Viewers.Where(v => v.Id == id).SingleOrDefaultAsync();
            return viewer;
        }

        public void Remove(Viewer viewer)
        {
            context.Viewers.Remove(viewer);
        }

        public Viewer Update(Viewer viewer)
        {
           return context.Viewers.Update(viewer).Entity;
        }
    }
}
