using System;

namespace Diferenca
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] vet = Console.ReadLine().Split(' ');
			int a = int.Parse(vet[0]);
			int b = int.Parse(vet[1]);
			int c = int.Parse(vet[2]);
			int d = int.Parse(vet[3]);

			int diferenca = (a * b - c * d);
			Console.WriteLine($"Diferença: {diferenca}");
			//Console.WriteLine($"{a} {b} {c} {d}");
		}
	}
}
