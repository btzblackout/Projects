
namespace PriceComparisonApp.Models
{
    public class VendorProductPrice
    {
		// Declare variables w/ Getters and Setters.
		private int vendorId;
		public int VendorID
		{
			get { return vendorId; }
			set { vendorId = value; }
		}

		private Vendor vendor;
		public Vendor Vendor
		{
			get { return vendor; }
			set { vendor = value; }
		}

		private int productId;
		public int ProductID
		{
			get { return productId; }
			set { productId = value; }
		}

		private Product product;
		public Product Product
		{
			get { return product; }
			set { product = value; }
		}


		private decimal price;
		public decimal Price
		{
			get { return price; }
			set { price = value; }
		}

	}
}
