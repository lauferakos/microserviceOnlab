using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.ViewerAggregate
{
    public interface IViewerRepository : IRepository<Viewer>
    {
        Viewer Add(Viewer viewer);
        Viewer Update(Viewer viewer);
        Task<Viewer> FindByIdAsync(int id);
        void Remove(Viewer viewer);
    }
}
