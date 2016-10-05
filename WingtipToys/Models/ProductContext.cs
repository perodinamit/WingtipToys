using System.Data.Entity;

/*
The ProductContext class represents Entity Framework product database context, which
handles fetching, storing, and updating Product class instances in the database. The
ProductContext class derives from the DbContext base class provided by Entity Framework.
*/
namespace WingtipToys.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WingtipToys")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}
