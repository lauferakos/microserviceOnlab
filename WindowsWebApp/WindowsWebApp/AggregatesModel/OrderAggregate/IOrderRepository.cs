using System.Threading.Tasks;
using WindowsWebApp.Infractructure.SeedWork;

namespace WindowsWebApp.AggregatesModel.OrderAggregate
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order Add(Order order);
        Order Update(Order order);
        Task<Order> FindByIdAsync(int id);
        void Remove(Order order);

    }
}