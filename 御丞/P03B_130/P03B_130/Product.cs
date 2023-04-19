using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03B_130
{
	public class Product
	{
		public string ProductName { get; set; }
		public decimal Price { get; set; }
		public Product(string name, decimal price)
		{
			ProductName = name;
			Price = price;
		}
		public override string ToString()
		{
			// return $"{ProductName},{Price}";
			return $"商品名稱: {ProductName}, 價格: {Price}";
		}
	}
}
