using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public interface IVisitorStaticticRepository { }
    public class VisitorStaticticRepository : RepositoryBase<VisitorStatictic>, IVisitorStaticticRepository
    {
        protected VisitorStaticticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
