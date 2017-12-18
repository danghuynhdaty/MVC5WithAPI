using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public interface IPostRepository { }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        protected PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
