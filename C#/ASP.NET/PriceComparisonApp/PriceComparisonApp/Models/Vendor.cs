using System.ComponentModel.DataAnnotations;

namespace PriceComparisonApp.Models
{
    public class Vendor
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

		private string contact;
		public string Contact
		{
			get { return contact; }
			set { contact = value; }
		}

		private List<VendorProductPrice> vendorProductPrices;
		public List<VendorProductPrice> VendorProductPrices
		{
			get { return vendorProductPrices; }
			set { vendorProductPrices = value; }
		}


	}
}
