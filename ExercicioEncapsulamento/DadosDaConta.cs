using System.Globalization;

namespace ExercicioEncapsulamento
{
	class DadosDaConta
	{
		public int NumeroConta { get; private set; }
		public string Titular { get; set; }
		public string SimOuNao { get; set; }
		public double DepositoInicial { get; set; }
		public double Saldo { get; protected set; }

		public DadosDaConta(int numeroConta, string titular)
		{
			NumeroConta = numeroConta;
			Titular = titular;
		}

		public DadosDaConta(int numero, string titular, double deposito) : this(numero, titular)
		{
			Deposito(deposito);
		}

		public void	Deposito(double quantidade)
		{
			Saldo += quantidade;
		}

		public void Saque(double quantidade)
		{
			Saldo -= quantidade;
			Saldo -= 5.0;
		}

		public DadosDaConta()
		{
		}

		public override string ToString()
		{
			return "Conta " 
				+ NumeroConta 
				+ ", Titular " 
				+ Titular 
				+ " Saldo R$" 
				+ Saldo.ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
