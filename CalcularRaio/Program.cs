using System;
using System.Globalization;

namespace CalcularRaio
{
	class Program
	{
		static void Main(string[] args)
		{
			double area;
			double pi = 3.14159;

			Console.Write($"Digite o raio: ");
			double raio = double.Parse(Console.ReadLine());

			area = pi * (raio * raio);
			Console.Write($"Valor da área: {area.ToString("F4" ,CultureInfo.InvariantCulture)}");
		}
	}
}
