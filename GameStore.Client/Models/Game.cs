namespace GameStore.Client.Models;

public class Game
{
    public int Id { get; set; }
    public required string Name { get; set; } = String.Empty;
    public required string Genre { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
}