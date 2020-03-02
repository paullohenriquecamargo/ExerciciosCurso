using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes
{
	class Program
	{
		static void Main(string[] args)
		{
			Pedido pedido = new Pedido
			{
				Id = 1080,
				Moment = DateTime.Now,
				Status = OrderStatus.PendingPayment
			};

			Console.WriteLine(pedido);

			string txt = OrderStatus.PendingPayment.ToString();

			OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

			Console.WriteLine(os);
			Console.WriteLine(txt);
		}
	}
}
