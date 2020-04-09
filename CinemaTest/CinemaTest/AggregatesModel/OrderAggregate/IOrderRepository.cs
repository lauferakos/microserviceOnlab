using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.OrderAggregate
{
    public interface IOrderRepository: IRepository<Order>
    {
        Order Add(Order order);
        Order Update(Order order);
        Task<Order> FindByIdAsync(int id);
        void Remove(Order order);

        
    }
}
