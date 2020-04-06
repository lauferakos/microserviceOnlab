using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsWebApp.Infractructure.SeedWork;

namespace WindowsWebApp.AggregatesModel.ViewerAggregate
{
    public interface IViewerRepository : IRepository<Viewer>
    {
        Viewer Add(Viewer viewer);
        Viewer Update(Viewer viewer);
        Task<Viewer> FindByIdAsync(int id);
        void Remove(Viewer viewer);
    }
}
