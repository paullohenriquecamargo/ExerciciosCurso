﻿using System;
using System.Globalization;

namespace ExercicioEncapsulamento
{
	class Program
	{
		static void Main(string[] args)
		{
			DadosDaConta dados = new DadosDaConta();

			Console.Write("Entre com o número da conta: ");
			int numero = int.Parse(Console.ReadLine());

			Console.Write("Entre com o nome do titular da conta: ");
			string titular = Console.ReadLine();

			Console.Write("Deseja fazer um depósito incial ?");
			char resp = char.Parse(Console.ReadLine().ToLower());
			if(resp == 's' || resp == 'S')
			{
				Console.WriteLine("Entre o valor de depósito inicial: ");
				double depositoInicial = double.Parse(Console.ReadLine());
				dados = new DadosDaConta(numero, titular, depositoInicial);
			}
			else
			{
				dados = new DadosDaConta(numero, titular);
			}

			Console.WriteLine("Dados da conta: ");
			Console.WriteLine(dados);

			Console.Write("Entre com o valor de depósito: ");
			double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			dados.Deposito(quantidade);

			Console.Write("Dados da conta atualizados: ");

			Console.Write("Entre com o valor do saque: ");
			quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			dados.Saque(quantidade);
		}
	}
}
