using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03B_130
{
	public class SaveOrReadFile
	{
		public void Save(string path, List<Product> data)
		{
			using (StreamWriter sw = new StreamWriter(path))
			{
				foreach (var info in data)
				{
					sw.WriteLine(info);
				}
			}
		}
		public List<Product> Read(string path)
		{
			string line;
			List<Product> data = new List<Product>();
			using (StreamReader sr = new StreamReader(path))
			{
				while ((line = sr.ReadLine()) != null)
				{
					string[] parts = line.Split(',');
					string productName = parts[0];
					if (decimal.TryParse(parts[1], out decimal result))
					{
						decimal price = result;
						data.Add(new Product(productName, price));
					}
					else
					{
						data.Add(new Product(productName, 0));
					}
				}
			}
			return data;
		}
	}
}
