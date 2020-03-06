using System;
using System.Globalization;

namespace Produto.Entities
{
	class UsedProduct : Product
	{
		public DateTime Manufacture { get; set; }

		public UsedProduct()
		{
		}

		public UsedProduct(string name, double price, DateTime manuFacture) : base(name, price)
		{
			Manufacture = manuFacture;
		}

		public override string PriceTag()
		{
			return Name
				+ " $ "
				+ Price.ToString("F2", CultureInfo.InvariantCulture)
				+ Manufacture.ToString("(DD/MM/yyyy");
		}
	}
}
