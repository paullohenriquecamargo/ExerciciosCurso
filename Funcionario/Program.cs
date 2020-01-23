using System;
using System.Globalization;

namespace Funcionario
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Digite o seu número: ");
			int numeroFuncionario = int.Parse(Console.ReadLine());

			Console.Write("Digite quantidade de horas trabalhadas: ");
			int horas = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor que você recebe por hora: ");
			double valor = double.Parse(Console.ReadLine());

			double salario = horas * valor;

			Console.WriteLine($"Seu salário: {salario.ToString("F2", CultureInfo.InvariantCulture)}, Seu número: {numeroFuncionario}");
		}
	}
}
