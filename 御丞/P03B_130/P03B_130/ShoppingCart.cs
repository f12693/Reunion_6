using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03B_130
{
	public class ShoppingCart
	{
		public List<Product> Products { get; set; }
		private SaveOrReadFile _SaveOrReadFile = new SaveOrReadFile();
		public ShoppingCart()
		{
			Products = new List<Product>();
		}

		public void AddProduct(string name, decimal price)
		{
			Products.Add(new Product(name, price));
		}
		public void RemoveProduct(string name)
		{
			Products.RemoveAll(p => p.ProductName == name);
		}
		public decimal GetSumPrice()
		{
			return Products.Sum(p => p.Price);
		}
		public void SaveShoppingCart(string path)
		{
			_SaveOrReadFile.Save(path, Products);
		}
		public void ReadShoppingCart(string path)
		{
			Products = _SaveOrReadFile.Read(path);
		}
		public void ShowShoppingCartList()
		{
			foreach (var product in Products)
			{
				Console.WriteLine(product);
			}
		}
	}
}
