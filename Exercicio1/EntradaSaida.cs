using System;

namespace Exercicio1
{
	class EntradaSaida
	{
		static void Main(string[] args)
		{
			Console.Write("Digite um número: ");
			int numero1 = int.Parse(Console.ReadLine());

			Console.Write("Digite um número: ");
			int numero2 = int.Parse(Console.ReadLine());

			int resultado = numero1 + numero2;
			Console.WriteLine($"Soma: {resultado}");
		}
	}
}
