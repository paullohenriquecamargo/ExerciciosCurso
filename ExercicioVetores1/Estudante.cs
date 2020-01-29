using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVetores1
{
	class Estudante
	{
		public string Nome;
		public string Email;

		public Estudante(string nome, string email)
		{
			Nome = nome;
			Email = email;
		}

		public string PlaceHolder()
		{
			return Nome + " , " + Email;
		}
	}
}
