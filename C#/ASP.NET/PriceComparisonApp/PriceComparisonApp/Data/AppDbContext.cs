using Microsoft.EntityFrameworkCore;
using PriceComparisonApp.Models;

namespace PriceComparisonApp.Data
{
    public class AppDbContext : DbContext
    {

		// Declare variables w/ Getters and Setters.
		private DbSet<Vendor> vendors;
		public DbSet<Vendor> Vendors
		{
			get { return vendors; }
			set { vendors = value; }
		}

		private DbSet<Product> products;
		public DbSet<Product> Products
		{
			get { return products; }
			set { products = value; }
		}

		private DbSet<VendorProductPrice> vendorProductPrices;
		public  DbSet<VendorProductPrice> VendorProductPrices
		{
			get { return vendorProductPrices; }
			set { vendorProductPrices = value; }
		}

		// Constructor
		public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<VendorProductPrice>()
				.HasKey(vpp => new { vpp.VendorID, vpp.ProductID });
        }


    }
}
