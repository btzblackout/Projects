using System.ComponentModel.DataAnnotations;

namespace PriceComparisonApp.Models
{
    public class Product
    {
		
		// Declare variables w/ Getters and Setters
		private int Id;
		[Required]
		public int ID
		{
			get { return Id; }
			set { Id = value; }
		}

		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string description;
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		private List<VendorProductPrice> vendorProductPrices;
		public List<VendorProductPrice> VendorProductPrices
		{
			get { return vendorProductPrices; }
			set { vendorProductPrices = value; }
		}


	}
}
