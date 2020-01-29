using System;

namespace Retangulo
{
	class Program
	{
		static void Main(string[] args)
		{
			var retangulo = new Retangulo();

			Console.Write("Digite a largura do retangulo: ");
			retangulo.Largura = double.Parse(Console.ReadLine());

			Console.Write("Digite a altura do retangulo: ");
			retangulo.Altura = double.Parse(Console.ReadLine());

			Console.WriteLine($"Area: {retangulo.Area()}");
			Console.WriteLine($"Perimetro: {retangulo.Perimetro()}");
			Console.WriteLine($"Diagonal: {retangulo.Diagonal()}");
		}
	}
}
