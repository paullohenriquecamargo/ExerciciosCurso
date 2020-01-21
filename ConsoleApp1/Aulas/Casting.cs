using System;
using System.Collections.Generic;
using System.Text;

namespace Aulas.Aulas
{
	class Casting
	{
		static void Main(string[] args)
		{
			float x = 4.5f;
			double y = x;

			Console.WriteLine(y);

			double a;
			float b;

			a = 5.1;
			//casting
			b = (float)a;

			Console.WriteLine(b);

			double d;
			int c;

			d = 5.1;
			c = (int)a;
						
		}
	}
}
