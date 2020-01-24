using System;

namespace IfElse4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Digite a hora inicial e final de um jogo: ");
			string[] vet = Console.ReadLine().Split(' ');

			int horaInicial = int.Parse(vet[0]);
			int horaFinal = int.Parse(vet[1]);

			int resultado = horaInicial + horaFinal;

			if(horaInicial < 12 && horaFinal)
		}
	}
}
