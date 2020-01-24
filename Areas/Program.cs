using System;
using System.Globalization;

namespace Areas
{
	class Program
	{
		static void Main(string[] args)
		{
			double A, B, C, triangulo, circulo, retangulo, quadrado, trapezio;

			Console.Write("Digite os valores de A, B e C: ");
			string[] vet = Console.ReadLine().Split(' ');
			A = double.Parse(vet[0]);
			B = double.Parse(vet[1]);
			C = double.Parse(vet[2]);

			triangulo = A * C / 2.0;
			circulo = 3.14159 * C * C;
			trapezio = (A + B) / 2.0 * C;
			quadrado = B * B;
			retangulo = A * B;

			Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
		}
	}
}
