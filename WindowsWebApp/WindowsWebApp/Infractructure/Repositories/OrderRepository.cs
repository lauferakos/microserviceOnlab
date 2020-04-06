using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsWebApp.AggregatesModel.OrderAggregate;
using WindowsWebApp.Infractructure.SeedWork;

namespace WindowsWebApp.Infractructure.Repositories
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
        public Order Add(Order order)
        {
            return context.Orders.Add(order).Entity;
        }

        public async Task<Order> FindByIdAsync(int id)
        {
            var order = await context.Orders.Where(o => o.Id == id).SingleOrDefaultAsync();

            return order;
        }

        public void Remove(Order order)
        {
            context.Orders.Remove(order);
        }

        public Order Update(Order order)
        {
            return context.Orders.Update(order).Entity;
        }
    }

}
