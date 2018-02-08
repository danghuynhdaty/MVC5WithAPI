namespace OnlineShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
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
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}