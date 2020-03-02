﻿using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes
{
	public class Pedido
	{
		public int Id { get; set; }
		public DateTime Moment { get; set; }
		public OrderStatus Status { get; set; }

		public override string ToString()
		{
			return Id
				+ ", "
				+ Moment
				+ ", "
				+ Status;
		}
	}
}
