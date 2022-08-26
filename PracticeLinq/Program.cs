using System.Linq;

List<string> videoGames = new List<string>() { "apex Legends", "COD", "Fifa", "PubG"};

videoGames.OrderBy(x => x.Length).ToList().ForEach(game => Console.WriteLine(game));
Console.WriteLine("------");

videoGames.Where(x => x.Length > 6).ToList().ForEach(game => Console.WriteLine(game));
Console.WriteLine("----");
videoGames.OrderBy(x => x.Length).ToList().ForEach(game => Console.WriteLine(game));
Console.WriteLine("------");
videoGames.OrderByDescending(x => x.Length).ToList().ForEach(game => Console.WriteLine(game));
Console.WriteLine("-------");
videoGames.Count(x => x.Length == 4).ToString().ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine("----");


