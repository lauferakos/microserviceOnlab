using CinemaTest.AggregatesModel.OrderAggregate;
using CinemaTest.AggregatesModel.ProjectionAggregate;
using CinemaTest.AggregatesModel.RoomAggregate;
using CinemaTest.AggregatesModel.ViewerAggregate;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.Infrastructure
{
    public static class SeedData
    {
        public static void UpdateDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<SearchingContext>())
                {
                   context.Database.Migrate();
                    AddData(context);
                }
            }
           
        }
        
        public static void AddData(SearchingContext context)
        {
         
            Film f1 = new Film() { Title = "Harry Potter", Duration = 200, Director = "Chris Columbus", Description = "HP leírás" };
            Film f2 = new Film() { Title = "Narnia", Duration = 150, Director = "Andrew Adamson", Description = "Narnia leírás" };
            Film f3 = new Film() { Title = "Bosszúállók, végwtelen háború", Duration = 220, Director = "Joe Russo", Description = "Bosszuállók leírás" };
            Film f4 = new Film() { Title = "A nagy gatsby", Duration = 130, Director = "Baz Luhrmann", Description = "Gatsby leírás" };
            Film f5 = new Film() { Title = "Eredet", Duration = 210, Director = "Christopher Nolan", Description = "Eredet leírás" };

            context.Films.AddRange(f1, f2, f3, f4, f5);


            Room r1 = new Room() { RoomNumber = 1, NumOfSeats = 20 };
            Room r2 = new Room() { RoomNumber = 2, NumOfSeats = 20 };
            Room r3 = new Room() { RoomNumber = 3, NumOfSeats = 20 };

            context.Rooms.AddRange(r1,r2,r3);

            Seat s1 = new Seat() { Row = 1, Column = 1, Price = 1000, Room = r1 };
            Seat s2 = new Seat() { Row = 1, Column = 2, Price = 1000, Room = r2 };
            Seat s3 = new Seat() { Row = 1, Column = 3, Price = 1000, Room = r1 };
            Seat s4 = new Seat() { Row = 1, Column = 4, Price = 1000, Room = r2 };
            Seat s5 = new Seat() { Row = 1, Column = 5, Price = 1000, Room = r3 };

            context.Seats.AddRange(s1,s2,s3,s4,s5);

            Projection p1 = new Projection() { StartTime = new DateTime(2020, 03, 12), FreeSeats = 20, Room=r2, Film = f3 };
            Projection p2 = new Projection() { StartTime = new DateTime(2020, 03, 20), FreeSeats = 20, Room=r1, Film = f2 };

            context.Projections.AddRange(p1, p2);

            Order o1 = new Order() { FullPrice = 2000, Projection = p1 };
            Order o2 = new Order() { FullPrice = 3000, Projection = p2 };

            context.Orders.AddRange(o1,o2);

            Viewer v1 = new Viewer() { Order = o1 };
            Viewer v2 = new Viewer() { Order = o2 };

            context.Viewers.AddRange(v1,v2);
            context.SaveChanges();


        }

       
    }
}
