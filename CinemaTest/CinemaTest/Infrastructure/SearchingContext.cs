using CinemaTest.AggregatesModel.OrderAggregate;
using CinemaTest.AggregatesModel.ProjectionAggregate;
using CinemaTest.AggregatesModel.ViewerAggregate;
using CinemaTest.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CinemaTest.Infrastructure
{
    public class SearchingContext : DbContext, IUnitOfWork
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Projection> Projections { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Viewer> Viewers { get; set; }
        public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
       
        public SearchingContext(DbContextOptions<SearchingContext> options) : base(options)
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
