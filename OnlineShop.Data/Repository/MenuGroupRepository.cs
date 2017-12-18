using OnlineShop.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public interface IMenuGroupRepository { }
    public class MenuGroupRepository : RepositoryBase<MenuGroupRepository>
    {
        protected MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
