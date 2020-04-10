using CinemaTest.AggregatesModel.RoomAggregate;
using CinemaTest.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.Infrastructure.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly SearchingContext context;
        public IUnitOfWork UnitOfWork
        {
            get { return context; }
        }

        public RoomRepository(SearchingContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Seat AddSeat(Seat seat)
        {
            return context.Seats.Add(seat).Entity;
        }

        public async Task<Seat> FindSeatByIdAsync(int id)
        {
            var seat = await context.Seats.Where(o => o.Id == id).SingleOrDefaultAsync();

            return seat;
        }
        public void RemoveSeat(Seat seat)
        {
            context.Seats.Remove(seat);
        }

        public Seat UpdateSeat(Seat seat)
        {
            return context.Seats.Update(seat).Entity;
        }

        public Room AddRoom(Room room)
        {
            return context.Rooms.Add(room).Entity;
        }

        public async Task<Room> FindRoomByIdAsync(int id)
        {
            var room = await context.Rooms.Where(p => p.Id == id).SingleOrDefaultAsync();
            return room;
        }

        public void RemoveRoom(Room room)
        {
            context.Rooms.Remove(room);
        }
        public Room UpdateRoom(Room room)
        {
            return context.Rooms.Update(room).Entity;
        }

        public IEnumerable<Room> FindAllRoom()
        {
            return context.Rooms;
        }

        public async Task<List<Seat>> GetAllSeatByRoomIdAsync(int roomId)
        {
            List<Seat> seats = await context.Seats.Where(s => s.RoomFK == roomId).ToListAsync();
            return seats;

        }
    }
}
