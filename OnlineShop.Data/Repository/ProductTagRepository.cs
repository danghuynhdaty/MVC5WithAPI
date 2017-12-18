using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public interface IProductTagRepository { }
    public class ProductTagRepository : RepositoryBase<ProductTag> , IProductTagRepository
    {
        protected ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
