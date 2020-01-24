using System;

namespace IfElse1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Digite um número: ");
			int numero = int.Parse(Console.ReadLine());

			Console.Clear();

			if(numero < 0 )
				Console.Write("O número que você digitou é negativo !");
			else
				Console.Write("O número que você digitou é positivo !");
		}
	}
}
