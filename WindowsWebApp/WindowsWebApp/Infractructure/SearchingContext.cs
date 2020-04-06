using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WindowsWebApp.AggregatesModel.OrderAggregate;
using WindowsWebApp.AggregatesModel.ProjectionAggregate;
using WindowsWebApp.AggregatesModel.ViewerAggregate;
using WindowsWebApp.Infractructure.SeedWork;

namespace WindowsWebApp.Infractructure
{
    public class SearchingContext : DbContext, IUnitOfWork
    {

        public SearchingContext(DbContextOptions options) : base(options) { }
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CinemaSearchDB;Trusted_Connection=True;");
        }*/


    }
}
