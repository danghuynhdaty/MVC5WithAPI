using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;

namespace OnlineShop.Data.Repository
{
    public interface IOrderDetailRepository { }

    internal class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        protected OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}