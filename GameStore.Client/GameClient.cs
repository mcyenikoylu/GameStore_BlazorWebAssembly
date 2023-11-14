using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
{
    private static readonly List<Game> games = new() {
        new Game()
        {
        Id = 1,
        Name = "Gran Turismo 3",
        Genre = "Race Simulator",
        Price = 19.99m,
        ReleaseDate = new DateTime(1991,2,18)
        },
        new Models.Game()
        {
        Id = 2,
        Name = "Gran Turismo 4",
        Genre = "Race Simulator",
        Price = 12.72m,
        ReleaseDate = new DateTime(2002,7,12)
        },
        new Models.Game()
        {
        Id = 3,
        Name = "Street Fighter 2",
        Genre = "Fighting",
        Price = 34.69m,
        ReleaseDate = new DateTime(2009,11,21)
        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }
}