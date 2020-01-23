using System;
using System.Globalization;

namespace Peca
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Código da peça 1: ");
			string codigo1 = Console.ReadLine();

			Console.Write("Número de peças 1: ");
			int quantidade1 = int.Parse(Console.ReadLine());

			Console.Write("Valor da peça 1: ");
			double valor1 = double.Parse(Console.ReadLine());

			Console.Write("Código da peça 2: ");
			string codigo2 = Console.ReadLine();

			Console.Write("Número de peças 2: ");
			int quantidade2 = int.Parse(Console.ReadLine());

			Console.Write("Valor da peça 2: ");
			double valor2 = double.Parse(Console.ReadLine());

			double valorTotal = valor1 * quantidade1 + valor2 * quantidade2;

			Console.Clear();

			Console.Write($"Valor a pagar: {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
			
		}
	}
}
