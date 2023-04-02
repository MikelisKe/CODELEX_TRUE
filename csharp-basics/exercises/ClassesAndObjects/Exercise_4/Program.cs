// See https://aka.ms/new-console-template for more information

using Exercise_4;

Movie bondMovie = new Movie("Casino Royale", "“Eon Productions”", "PG-13");
Movie glass = new Movie("Glass", "Buena Vista Internationa", "PG-13");
Movie spider = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

Movie[] allMovies = new Movie[] { bondMovie, glass, spider };

Console.WriteLine(spider);
Movie[] pgMovies = Movie.GetPG(allMovies);
Console.ReadKey();




