namespace Exercise_4;

public class Movie
{
    private string _title;
    private string _studio;
    private string _rating;
    public override string ToString()
    {
        return $"{_title}, {_studio}, {_rating}";
    }

    public Movie(string title, string studio, string rating)
    {
        _title = title;
        _studio = studio;
        _rating = rating;
    }

    public Movie(string _title, string _studio) : this(_title,_studio, "PG")
    {
        
    }

    public string Rating
    {
        get => _rating;
        set
        {
            if (value == "PG" || value == "PG-13")
            {
                _rating = value;
            }
            else
            {
                _rating = "NR";
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
