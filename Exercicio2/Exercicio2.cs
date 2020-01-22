using System;

namespace Exercicio2
{
	class Exercicio2
	{
		static void Main(string[] args)
		{
			string nome = Console.ReadLine();
			Console.WriteLine($"Digite seu nome completo: {nome}");

			int numeroQuartos = int.Parse(Console.ReadLine());
			Console.WriteLine($"Quantos quartos tem na sua casa ?: {numeroQuartos}");

			double preco = double.Parse(Console.ReadLine());
			Console.WriteLine($"Entre com o preço de um produto: {preco}");

			string[] vet = Console.ReadLine().Split(' ');
			string ultimoNome = vet[0];
			int idade = int.Parse(vet[0]);
			double altura = double.Parse(vet[1]);
		}
	}
}
