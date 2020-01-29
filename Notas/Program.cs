using System;

namespace Notas
{
	class Program
	{
		static void Main(string[] args)
		{
			var aluno = new Aluno();

			double nota1 = aluno.Nota;
			double nota2 = aluno.Nota;
			double nota3 = aluno.Nota;

			Console.Write("Digite o nome: ");
			aluno.Nome = Console.ReadLine();

			Console.Write("Digite a nota1: ");
			nota1 = double.Parse(Console.ReadLine());

			Console.Write("Digite a nota2: ");
			nota2 = double.Parse(Console.ReadLine());

			Console.Write("Digite a nota3: ");
			nota3 = double.Parse(Console.ReadLine());

			double notaFinal = (nota1 + nota2 + nota3) / 3.0;

			if (aluno.Aprovado == true)
				aluno.NotaRestante = 0.0;
			else
				aluno.NotaRestante = 60 - notaFinal;

			Console.WriteLine($"Nota final do aluno: {notaFinal}");
			Console.WriteLine($"");

			if(notaFinal >= 60.00)
			{
				 aluno.Aprovado = true;
				Console.WriteLine("APROVADO !");
			}
			else
			{
				aluno.Aprovado = false;
				Console.WriteLine("REPROVADO !");
				Console.WriteLine($"Faltaram {aluno.NotaRestante} pontos para o aluno passar.");
			}
		}
	}
}
