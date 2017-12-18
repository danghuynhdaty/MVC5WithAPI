using OnlineShop.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public interface IFooterRepository
    {

    }
    public class FooterRepository : RepositoryBase<FooterRepository>, IFooterRepository
    {
        protected FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
