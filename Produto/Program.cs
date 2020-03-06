using Produto.Entities;
using System;
using System.Collections.Generic;

namespace Produto
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Product> products = new List<Product>();

			Console.Write("Enter the numer of products: ");
			int n = int.Parse(Console.ReadLine());

			for(int i = 1; i <= n; i++)
			{
				Console.WriteLine($"Product #{i}:");
				Console.Write("Common, used or imported ? (c/u/i)");
				char ch = char.Parse(Console.ReadLine());
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Price: ");
				double price = double.Parse(Console.ReadLine());
				if(ch == 'i')
				{
					Console.Write("Customs fee: ");
					double customsFee = double.Parse(Console.ReadLine());
					products.Add(new ImportedProduct(price, name, customsFee));
				}
				if(ch == 'u')
				{
					Console.Write("Manufacture data (DD/MM/yyyy): ");
					DateTime manufacture = DateTime.Parse(Console.ReadLine().ToString());
					products.Add(new UsedProduct(name, price, manufacture));
				}
				else
				{
					products.Add(new Product(name, price));
				}
			}

			Console.WriteLine();
			Console.WriteLine("PRICE TAGS");
			foreach(Product product in products)
			{
				Console.WriteLine(product.PriceTag());
			}
		}
	}
}
