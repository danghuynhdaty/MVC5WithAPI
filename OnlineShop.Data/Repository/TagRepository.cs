using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public interface ITagRepository { }
    public class TagRepository : RepositoryBase<Tag> , ITagRepository
    {
        protected TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
