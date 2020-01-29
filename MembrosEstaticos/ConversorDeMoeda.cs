namespace MembrosEstaticos
{
	class ConversorDeMoeda
	{
		public double Dolar { get; set; }
		public double Cotagem { get; set; }
		public double Iof { get; set; } = 1.06;
		public double Reais { get; set; }
		public double TotalEmReais { get; set; }
		public double DolarFinal { get; set; }

		

		public double Converter()
		{
			return DolarFinal = Dolar * Iof;
		}
				
		public double ValorReais()
		{
			return TotalEmReais = DolarFinal * Cotagem;
		}
	}
}
