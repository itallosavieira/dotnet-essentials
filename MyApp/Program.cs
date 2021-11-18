using System;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var desk = new Product(1, "Desk", 950.50, EProductType.Product);
			var manutation = new Product(2, "Manutation", 100, EProductType.Service);
			Console.WriteLine(desk.Id);
			Console.WriteLine(desk.Name);
			Console.WriteLine(desk.Price);
			Console.WriteLine(desk.PriceInDolar(5));
			Console.WriteLine(manutation.Id);
			Console.WriteLine(manutation.Name);
			Console.WriteLine(manutation.Price);
			Console.WriteLine(manutation.PriceInDolar(5));
		}
	}
	enum EProductType
	{
		Product = 1,
		Service = 2
	}
	struct Product
	{
		public Product(int id, string name, double price, EProductType type)
		{
			Id = id;
			Name = name;
			Price = price;
			Type = type;
		}
		public int Id;
		public string Name;
		public double Price;
		public EProductType Type;
		public double PriceInDolar(double dolar)
		{
			return Price * dolar;
		}

	}
}
