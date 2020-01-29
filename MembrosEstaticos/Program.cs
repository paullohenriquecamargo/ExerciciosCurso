using System;

namespace MembrosEstaticos
{
	class Program
	{
		static void Main(string[] args)
		{
			ConversorDeMoeda conversor = new ConversorDeMoeda();
			Console.Write("Digite a cotagem do Dolar: ");
			conversor.Cotagem = double.Parse(Console.ReadLine());

			Console.WriteLine("Quantos dolares você vai comprar: ");
			conversor.Dolar = double.Parse(Console.ReadLine());

			conversor.Converter();

			Console.WriteLine($"Valor total em reais: {conversor.ValorReais().ToString("F2")}");
		}
	}
}
