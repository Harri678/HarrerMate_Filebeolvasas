namespace orai
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
			ErossegiSzintRendezes(karakterek);
			Console.WriteLine("meghaladja-e: " + MeghaladjaE(karakterek, 11, 1));
            Console.WriteLine("----------");
            KarakterStats(karakterek, 8);
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

		static void ErossegiSzintRendezes(List<Karakter> karakterek)
		{
			karakterek.Sort((x, y) => x.Ero.CompareTo(y.Ero));
			foreach (var item in karakterek)
			{
				Console.WriteLine(item.ToString());
			}
		}

		static bool MeghaladjaE(List<Karakter> karakterek, int szint, int id)
		{
			if (szint > karakterek[id].Szint)
			{
				return true;
			}
			else
			{ 
				return false; 
			}
		}

		static void KarakterStats(List<Karakter> karakterek, int szint)
		{
			foreach (var karakter in karakterek)
			{
				if (karakter.Szint > szint)
				{
					Console.WriteLine(karakter.ToString());
				}
			}
		}

	}
}
