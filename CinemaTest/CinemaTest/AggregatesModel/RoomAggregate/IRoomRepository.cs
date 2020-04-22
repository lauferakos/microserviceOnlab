using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.RoomAggregate
{
    public interface IRoomRepository : IRepository<Room>
    {

        Room AddRoom(Room room);
        Room UpdateRoom(Room room);
        Task<Room> FindRoomByIdAsync(int id);
        void RemoveRoom(Room room);
        IEnumerable<Room> FindAllRoom();


        Seat AddSeat(Seat seat);
        Seat UpdateSeat(Seat seat);
        Task<Seat> FindSeatByIdAsync(int id);
        void RemoveSeat(Seat seat);

        Task<List<Seat>> GetAllSeatByRoomIdAsync(int roomId);
    }
}
