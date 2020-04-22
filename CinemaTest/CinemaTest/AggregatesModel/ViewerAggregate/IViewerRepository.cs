using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.ViewerAggregate
{
    public interface IViewerRepository : IRepository<Viewer>
    {
        Viewer AddViewer(Viewer viewer);
        Viewer UpdateViewer(Viewer viewer);
        Task<Viewer> FindViewerByIdAsync(int id);
        void RemoveViewer(Viewer viewer);
    }
}
