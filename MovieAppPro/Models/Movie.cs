using SQLite;

namespace MovieAppPro.Models;

public class Movie
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Rating { get; set; }
}