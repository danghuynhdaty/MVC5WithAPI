using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public interface ISupportOnlineRepository { }
    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        protected SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
