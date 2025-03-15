using Microsoft.EntityFrameworkCore;
using eCommerceApi.Models;

namespace eCommerceApi.Data
{
    public class AppDbContext : DbContext
    {
        // public in the line below makes the constructor publically available and other parts of the application can access it.
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}

        // public in the below line is an Access Modifier. It means it's publicly available so other parts of the application can use/access it.
        // The difference between singluar and plural e.g. User and Users is that
        // we are defining a class that represents a single item - in the case of the singular,
        // and plural because it represents a table and the table contains many rows of data. 
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments {get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<Inventory> Inventorys { get; set; }

    }
}