using System;

namespace OnlineShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        /// <summary>
        /// khởi tạo db context
        /// </summary>
        /// <returns></returns>
        OnlineShopDbContext Init();
    }
}