using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public interface ISlideRepository { }
    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        protected SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
