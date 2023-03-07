namespace Exercise_4;

public class Movie
{
    private string title;
    private string studio;
    private string rating;
    public override string ToString()
    {
        return $"{title}, {studio}, {rating}";
    }

    public Movie(string _title, string _studio, string _rating)
    {
        title = _title;
        studio = _studio;
        Rating = _rating;
    }

    public Movie(string _title, string _studio) : this(_title,_studio, "PG")
    {
        
    }
    public string Rating
    {
        get => rating;
        set
        {
            if (value == "PG" || value == "PG-13")
            {
                rating = value;
            }
            else
            {
                rating = "NR";
            }
        }
    }

    public static Movie[] GetPG(Movie[] movies)
    {
        List<Movie> pgMovies = new List<Movie>();
        foreach (Movie movie in movies)
        {
            if (movie.Rating == "PG")
            {
                pgMovies.Add(movie);
            }
        }
        return pgMovies.ToArray();
    }
}
