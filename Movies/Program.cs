using System;

namespace Movies
{
	class Program
	{
		static void Main(string[] args)
		{
			var starwars = 
				new Movie("Star Wars", "Fantasy", "G", 1977, 121, "Lucas");
			var lordoftheringss =
				new Movie("Lord of the Rings", "Fantasy", "G", 2001, Movie.CalcRuntimeInMinutes(11, 22), "Jackson");
			var caddyshack =
				new Movie("Caddy Shack", "Comedy", "R", 1980, 98, "Ramis");
			var animalhouse =
				new Movie("Animal House", "Comedy", "R", 1978, 109, "Landis");
			var airplane =
				new Movie("Airplane", "Comedy", "PG", 1980, 87, "Abrhams, Zucker, Zucker");

			Console.WriteLine(starwars.Print());
			Console.WriteLine(lordoftheringss.Print());
			Console.WriteLine(caddyshack.Print());
			Console.WriteLine(animalhouse.Print());
			Console.WriteLine(airplane.Print());

		}

	}
}
