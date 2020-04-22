using CinemaTest.AggregatesModel.OrderAggregate;
using CinemaTest.AggregatesModel.RoomAggregate;
using CinemaTest.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SearchingContext context;
       public IUnitOfWork UnitOfWork
        {
            get { return context; }
        }

        public OrderRepository(SearchingContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Order AddOrder(Order order)
        {
            return context.Orders.Add(order).Entity;
        }

        public async Task<Order> FindOrderByIdAsync(int id)
        {
            var order = await context.Orders.Where( o => o.Id == id).SingleOrDefaultAsync();

            return order;
        }

        public void RemoveOrder(Order order)
        {
            context.Orders.Remove(order);
        }

        public Order UpdateOrder(Order order)
        {
            return context.Orders.Update(order).Entity;
        }

        public async Task<List<Order>> GetAllOrderByViewerIdAsync(int viewerId)
        {
            List<Order> orders = await context.Viewers.Select(v => v.Order).Where(v => v.Id == viewerId).ToListAsync();

            return orders;

        }
    }
}
