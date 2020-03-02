using ContratoSalario.Entities;
using ContratoSalario.Entities.Enums;
using System;

namespace ContratoSalario
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Entre com o nome do departamento: ");
			string deptName = Console.ReadLine();
			Console.WriteLine("Entre com os dados do trabalhador: ");
			Console.Write("Name: ");
			string nome = Console.ReadLine();
			Console.Write("Nivel (Junior/MidLevel/Senior)");
			WorkerLevel nivel = Enum.Parse<WorkerLevel>(Console.ReadLine());
			Console.Write("Salário base: ");
			double salarioBase = double.Parse(Console.ReadLine());

			Department dept = new Department(deptName);
			Worker worker = new Worker(nome, nivel, salarioBase, dept);

			Console.Write("Quantos contratos para esse trabalhador ?");
			int n = int.Parse(Console.ReadLine());

			for(int i = 1; i <= n; i++)
			{
				Console.WriteLine($"Entre com os dados do trabalhador #{i}: ");
				Console.Write("Data (DD/MM/YYYY): ");
				DateTime data = DateTime.Parse(Console.ReadLine());
				Console.Write("Valor por hora: ");
				double valorHora = double.Parse(Console.ReadLine());
				Console.WriteLine("Duration (hours): ");
				int hours = int.Parse(Console.ReadLine());
				HourContract contract = new HourContract(data, valorHora, hours);
				worker.AddContract(contract);
			}

			Console.WriteLine();
			Console.Write("Insira mês e ano para calcular a renda (MM/YYYY): ");
			string monthAndYear = Console.ReadLine();
			int month = int.Parse(monthAndYear.Substring(0, 2));
			int year = int.Parse(monthAndYear.Substring(3));
			Console.WriteLine("Departamento: " + worker.Name);
			Console.WriteLine("Departamento: " + worker.Department.Name);
			Console.WriteLine("Renda para: "+ monthAndYear + ": "+ worker.Income(year, month));
		}
	}
}
