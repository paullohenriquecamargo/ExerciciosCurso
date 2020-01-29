using System;

namespace ExercicioClasses1
{
	class Program
	{
		static void Main(string[] args)
		{
			var dados1 = new Pessoas();
			var dados2 = new Pessoas();

			Console.Write($"Digite a idade: ");
			dados1.Idade = int.Parse(Console.ReadLine());

			Console.Write($"Digite o nome: ");
			dados1.Nome = Console.ReadLine();

			Console.Clear();

			Console.Write($"Digite a idade: ");
			dados2.Idade = int.Parse(Console.ReadLine());

			Console.Write($"Digite o nome: ");
			dados2.Nome = Console.ReadLine();

			if(dados1.Idade > dados2.Idade)
				Console.WriteLine($"Pessoa mais velha: {dados1.Nome}");
			else
				Console.WriteLine($"Pessoa mais velha: {dados2.Nome}");
		}
	}
}
