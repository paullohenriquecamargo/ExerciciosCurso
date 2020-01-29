using System;

namespace ExercicioVetores1
{
	class Program
	{
		static void Main(string[] args)
		{
			Estudante[] estudantes = new Estudante[10];

			Console.WriteLine("Informe o número de quartos: ");
			int numeroQuartos = int.Parse(Console.ReadLine());

			for(int i = 0; i < numeroQuartos; i++)
			{
				Console.Write("Digite o nome do estudante: ");
				string nome = Console.ReadLine();

				Console.Write("Digite o email do estudante: ");
				string email = Console.ReadLine();

				Console.Write("Digite qual quarto voce vai querer ocupar: ");
				int quarto = int.Parse(Console.ReadLine());

				Console.Clear();
				estudantes[quarto] = new Estudante(nome, email);
			}

			for(int i = 0; i < 10; i++)
			{
				var quartosDisponiveis = "";
				if (estudantes[i] != null)
					quartosDisponiveis = "Reservado";
				else
					quartosDisponiveis = "Disponível";

				Console.WriteLine($"Quartos disponiveis: {quartosDisponiveis}");
			}
		}
	}
}
