using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai
{
	internal class Karakter
	{
		private string name;
		private int szint;
		private int eletero;
		private int ero;

		public Karakter(string name, int szint, int eletero, int ero)
		{
			this.name = name;
			this.szint = szint;
			this.eletero = eletero;
			this.ero = ero;
		}

		public string Name { get => name; set => name = value; }
		public int Szint { get => szint; set => szint = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Ero { get => ero; set => ero = value; }

		public override string? ToString()
		{
			return $"{name} - {szint} / {eletero} / {ero}";

		}
	}
}
