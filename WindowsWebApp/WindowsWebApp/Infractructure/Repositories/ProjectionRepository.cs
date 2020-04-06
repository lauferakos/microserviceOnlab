using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsWebApp.AggregatesModel.ProjectionAggregate;
using WindowsWebApp.Infractructure.SeedWork;

namespace WindowsWebApp.Infractructure.Repositories
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

        public Projection Add(Projection projection)
        {
            return context.Projections.Add(projection).Entity;
        }

        public async Task<Projection> FindByIdAsync(int id)
        {
            var projection = await context.Projections.Where(p => p.Id == id).SingleOrDefaultAsync();
            return projection;
        }

        public void Remove(Projection projection)
        {
            context.Projections.Remove(projection);
        }

        public Projection Update(Projection projection)
        {
            return context.Projections.Update(projection).Entity;
        }
    }
}
