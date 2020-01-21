﻿using System;
using System.Globalization;

namespace Primeiro
{
	class Exercicio1
	{
		static void Main(string[] args)
		{
			string produto1 = "Computador";
			string produto2 = "Mesa de escritório";

			byte idade = 30;
			int codigo = 5290;
			char genero = 'M';

			double preco1 = 2100.0;
			double preco2 = 650.50;
			double medida = 53.234567;

			Console.WriteLine($"Produtos: {produto1}, {produto2}");
			Console.WriteLine($"{produto1}, cujo preço é $ {preco1} " +
							  $"{produto2}, cujo preço é $ {preco2}");

			Console.WriteLine("Registro: "+ idade + " código é " + codigo + " e gênero: " + genero);
			Console.WriteLine($"Medida com oito casas decimais :{medida}00");
			Console.WriteLine($"Arredondado: {medida.ToString("F3")}");
			Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
		}
	}
}
