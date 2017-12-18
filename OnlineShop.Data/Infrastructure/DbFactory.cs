using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Infrastructure
{
    class DbFactory : Disposable, IDbFactory
    {
        private OnlineShopDbContext dbContext;
        public OnlineShopDbContext Init()
        {
            return dbContext ?? (dbContext = new OnlineShopDbContext());


        }

        /// <summary>
        /// kiểm tra xem nếu tồn tại thì dispose
        /// </summary>
        protected override void DisposeCore()
        {
            if (dbContext!=null)
            {
                dbContext.Dispose();
            }
        }
    }
}
