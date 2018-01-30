using OnlineShop.Model.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OnlineShop.Data
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext() : base("OnlineShopConnection")
        {
            //ngăn chặn việc lazyloading
            this.Configuration.LazyLoadingEnabled = false;
        }

        #region DbSet

        public DbSet<Footer> Footers { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<MenuGroup> MenuGroups { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Page> Pages { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostCategory> PostCategories { get; set; }

        public DbSet<PostTag> PostTags { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductTag> ProductTag { get; set; }

        public DbSet<Slide> Slides { get; set; }

        public DbSet<SupportOnline> SupportOnlines { get; set; }

        public DbSet<SystemConfig> SystemConfigs { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<VisitorStatictic> VisitorStatictics { get; set; }

        public DbSet<Error> Errors { get; set; }

        #endregion DbSet

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Code First to ignore PluralizingTableName convention
            // If you keep this convention, the generated tables
            // will have pluralized names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}