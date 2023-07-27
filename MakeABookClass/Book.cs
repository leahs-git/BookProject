namespace MakeABookClass;

public record Book
{
    public required string BookTitle { get; set; }
    public required string AuthorName { get; set; }
    public required DateOnly ReleaseDate { get; set; }
}
