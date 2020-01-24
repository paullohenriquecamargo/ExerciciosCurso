using System;

namespace IfElse3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Digite dois valores: ");
			string[] vet = Console.ReadLine().Split(' ');

			int A = int.Parse(vet[0]);
			int B = int.Parse(vet[1]);

			if(A % 2 == 0 && B % 2 == 0)
				Console.WriteLine("São multiplos !");
			else
				Console.WriteLine("Não sao multiplos");
		}
	}
}
