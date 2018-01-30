using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;

namespace OnlineShop.Data.Repository
{
    public interface IPageRepository : IRepository<Page>
    { }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        protected PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}