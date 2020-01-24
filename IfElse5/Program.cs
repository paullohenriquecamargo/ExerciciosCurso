using System;

namespace IfElse5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1  |  Cachorro Quente  |  R$ 4.00");
			Console.WriteLine("2  |  X-Salada         |  R$ 4.50");
			Console.WriteLine("3  |  X-Bacon          |  R$ 5.00");
			Console.WriteLine("4  |  Torrada simples  |  R$ 2.00");
			Console.WriteLine("5  |  Refrigerante     |  R$ 1.50");
			Console.Write("Digite o código do pedido: ");
			string codigo = Console.ReadLine();
			string pedido = "";
			double preco = 0.0;

			Console.Write("Digite a quantidade do produto");
			int quantidade = int.Parse(Console.ReadLine());

			Console.Clear();

			if (codigo == "1")
			{
				preco = 4.00;
				pedido = "Cachorro Quente";
			}

			else if (codigo == "2")
			{
				preco = 4.50;
				pedido = "X-Salada";
			}
			else if (codigo == "3")
			{
				preco = 5.00;
				pedido = "X-Bacon";
			}
			else if (codigo == "4")
			{
				preco = 2.00;
				pedido = "Torrada simples";
			}
			else if (codigo == "5")
			{
				preco = 1.50;
				pedido = "Refrigerante";
			}

			double precoFinal = quantidade * preco;

			Console.WriteLine($"Valor a pagar é {precoFinal} por {quantidade} {pedido}");
		}
	}
}
