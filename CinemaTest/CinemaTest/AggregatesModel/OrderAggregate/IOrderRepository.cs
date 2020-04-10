using CinemaTest.AggregatesModel.RoomAggregate;
using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.OrderAggregate
{
    public interface IOrderRepository: IRepository<Order>
    {
        Order AddOrder(Order order);
        Order UpdateOrder(Order order);
        Task<Order> FindOrderByIdAsync(int id);
        void RemoveOrder(Order order);

        Task<List<Order>> GetAllOrderByViewerIdAsync(int viewerId);      

        
    }
}
