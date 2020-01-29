using System;
using System.Globalization;

namespace ExercicioClasses2
{
	class Program
	{
		static void Main(string[] args)
		{
			var funcionario1 = new Funcionario();
			var funcionario2 = new Funcionario();

			Console.Write($"Digite o Nome: ");
			funcionario1.Nome = Console.ReadLine();

			Console.Write($"Digite o nome: ");
			funcionario1.Salario = double.Parse(Console.ReadLine());

			Console.Clear();

			Console.Write($"Digite o Nome: ");
			funcionario2.Nome = Console.ReadLine();

			Console.Write($"Digite o nome: ");
			funcionario2.Salario = double.Parse(Console.ReadLine());

			double salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;

			Console.WriteLine($"Salario médio dos funionarios: {salarioMedio.ToString(CultureInfo.InvariantCulture)}");
		}
	}
}
