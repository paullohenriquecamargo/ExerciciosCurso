using System;
using System.Globalization;

namespace EntradaDados2
{
	class EntradaDados2
	{
		static void Main(string[] args)
		{
			// #Não funciona
			//int n1 = Console.ReadLine(); 
			//char ch = Console.RedLine();
			int n1 = int.Parse(Console.ReadLine());
			char ch = char.Parse(Console.ReadLine());
			double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			string[] vet = Console.ReadLine().Split(' ');
			string nome = vet[0];
			char sexo = char.Parse(vet[1]);
			int idade = int.Parse(vet[2]);
			double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

			Console.WriteLine($"Você digitou: {n1}");
			Console.WriteLine(nome);
			Console.WriteLine(sexo);
			Console.WriteLine(idade);
			Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}
