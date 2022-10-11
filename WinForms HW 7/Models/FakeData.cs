using System.Globalization;
using WinForms_HW_7.Enums;

namespace WinForms_HW_7.Models;

public static class FakeData
{
	public static Dictionary<string, List<Player>> FakePlayers = new Dictionary<string, List<Player>>();

	static FakeData()
	{
		List<byte> numbers = new List<byte>();

		while (numbers.Count < 17)
		{
			byte addedNumber = (byte)Random.Shared.Next(0, 20);

			if (!numbers.Contains(addedNumber))
				numbers.Add(addedNumber);
		}

		FakePlayers[Position.GK.ToString()] = new List<Player>();
		FakePlayers[Position.GK.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[0], Position.GK));
		FakePlayers[Position.GK.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[1], Position.GK));

		FakePlayers[Position.F.ToString()] = new List<Player>();
		FakePlayers[Position.F.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[2], Position.F));
		FakePlayers[Position.F.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[3], Position.F));
		FakePlayers[Position.F.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[4], Position.F));
		FakePlayers[Position.F.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[5], Position.F));
		FakePlayers[Position.F.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[6], Position.F));

		FakePlayers[Position.MD.ToString()] = new List<Player>();
		FakePlayers[Position.MD.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[7], Position.MD));
		FakePlayers[Position.MD.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[8], Position.MD));
		FakePlayers[Position.MD.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[9], Position.MD));
		FakePlayers[Position.MD.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[10], Position.MD));
		FakePlayers[Position.MD.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[11], Position.MD));

		FakePlayers[Position.DD.ToString()] = new List<Player>();
		FakePlayers[Position.DD.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[12], Position.DD));
		FakePlayers[Position.DD.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[13], Position.DD));
		FakePlayers[Position.DD.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[14], Position.DD));
		FakePlayers[Position.DD.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[15], Position.DD));
		FakePlayers[Position.DD.ToString()].Add(new Player(Faker.NameFaker.Name(), numbers[16], Position.DD));
	}

	public static List<string> GetCountryNames()
		=> CultureInfo
			.GetCultures(CultureTypes.SpecificCultures)
			.Select(c => new RegionInfo(c.Name).EnglishName)
			.Distinct()
			.OrderBy(name => name)
			.ToList();

	public static List<Player> GetPlayers()
	{
		return new List<Player> { };
	}

	public static List<string> GetTacticFormats()
	 => new List<string>
	 {
		"4-3-3",
		"4-4-2",
		"2-3-5",
		"3-5-2",
		"4-4-2"
	};
}