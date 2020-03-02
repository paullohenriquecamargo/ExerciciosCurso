using System;
using System.Collections.Generic;

namespace ExercicioListas
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Quantos funcionários foram registrados: ");
			int n = int.Parse(Console.ReadLine());

			List<Funcionario> funcionarios = new List<Funcionario>();

			for(int i = 0; i <= n; i++)
			{
				Console.WriteLine($"Funcionario #{i}");
				Console.Write("Id: ");
				int id = int.Parse(Console.ReadLine());
				Console.Write("Nome: ");
				string nome = Console.ReadLine();
				Console.WriteLine("Salario: ");
				double salario = double.Parse(Console.ReadLine());
				funcionarios.Add(new Funcionario(id, nome, salario));
			}

			Console.WriteLine("Quantos funcionários foram registrados: ");

			if(funcionarios.)
		}
	}
}
