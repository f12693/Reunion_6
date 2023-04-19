using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P03B_130
{
	internal class Program
	{
		static void Main(string[] args)
		{
            /// 130 設計一個類別來表示一個購物車，擁有添加商品、移除商品、計算總金額等方法，並且支援儲存到檔案和從檔案讀取的方法。
            ///
			var shoppingCart = new ShoppingCart();
			shoppingCart.ReadShoppingCart("G:\\C#\\C#_Class\\HW_Exercise\\GPT題目_練習\\P03B_130\\P03B_130\\test.txt");
			//shoppingCart.AddProduct("apple", 125);
			//shoppingCart.AddProduct("egg", 200);
			//shoppingCart.AddProduct("book", 560);
			//shoppingCart.AddProduct("paper", 50);
			//shoppingCart.AddProduct("computer", 45000);
			shoppingCart.ShowShoppingCartList();
			shoppingCart.SaveShoppingCart("G:\\C#\\C#_Class\\HW_Exercise\\GPT題目_練習\\P03B_130\\P03B_130\\test1.txt");
			Console.WriteLine(shoppingCart.GetSumPrice());
			Console.ReadKey();
        }
	}
}
