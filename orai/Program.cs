﻿namespace orai
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Karakter> karakterek = [];

			Beolvasas("karakterek.txt", karakterek);

			foreach (var item in karakterek)
			{
				Console.WriteLine(item.ToString());
			}

			Console.WriteLine("legmagasabb: " + LegmagasabbEletero(karakterek));
			Console.WriteLine("atlagos: " + AtlagosSzint(karakterek));
		}
		static void Beolvasas(string filenev, List<Karakter> karakterek)
		{
			StreamReader sr = new(filenev);

			sr.ReadLine();

			while (!sr.EndOfStream)
			{
				string sor = sr.ReadLine();
				string[] szavak = sor.Split(';');

				Karakter karakter = new Karakter(szavak[0], Convert.ToInt16(szavak[1]), Convert.ToInt16(szavak[2]), Convert.ToInt16(szavak[3]));
				karakterek.Add(karakter);
			}
		}

		static Karakter LegmagasabbEletero(List<Karakter> karakterek)
		{
			Karakter legmagasabb = karakterek[0];
			foreach (var karakter in karakterek)
			{
				if (karakter.Eletero > legmagasabb.Eletero)
				{
					legmagasabb = karakter;
				}
			}
			return legmagasabb;
		}

		static int AtlagosSzint(List<Karakter> karakterek)
		{
			int ossz = 0;
			foreach (var karakter in karakterek)
			{
				ossz += karakter.Szint;
			}
			return ossz / karakterek.Count;
		}



	}
}
