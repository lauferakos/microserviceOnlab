﻿using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.ProjectionAggregate
{
    public interface IProjectionRepository : IRepository<Projection>
    {
        Projection Add(Projection projection);
        Projection Update(Projection projection);
        Task<Projection> FindByIdAsync(int id);
        void Remove(Projection projection);
    }
}
