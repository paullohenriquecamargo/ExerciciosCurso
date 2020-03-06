using System;

namespace ExercicioProposto.Entities
{
	public class Client
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime BirthDate { get; set; }

		public Client()
		{
		}

		public Client(string name, string email, DateTime birhDate)
		{
			Name = name;
			Email = email;
			BirthDate = birhDate;
		}

		public override string ToString()
		{
			return Name
				+ ", ("
				+ BirthDate.ToString("dd/MM/yyyy")
				+ ") - "
				+ Email;
		}
	}
}