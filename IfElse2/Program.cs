using System;

namespace IfElse2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Digite um número: ");
			int numero = int.Parse(Console.ReadLine());

			Console.Clear();

			if (numero % 2 == 0)
				Console.Write("O número que você digitou é par !");
			else
				Console.Write("O número que você digitou é impar !");
		}
	}
}
