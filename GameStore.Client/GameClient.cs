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
        ,
        new Models.Game()
        {
        Id = 4,
        Name = "Mervemin gozleri",
        Genre = "Fighting",
        Price = 34.69m,
        ReleaseDate = new DateTime(2009,11,21)
        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
    }

    public static Game GetGame(int id)
    {
        return games.Find(game => game.Id == id) ?? throw new Exception("Could not find game!");
    }

    public static void UpdateGame(Game updateGame)
    {
        Game existingGame = GetGame(updateGame.Id);
        existingGame.Name = updateGame.Name;
        existingGame.Genre = updateGame.Genre;
        existingGame.Price = updateGame.Price;
        existingGame.ReleaseDate = updateGame.ReleaseDate;
    }

    public static void DeleteGame(int Id)
    {
        Game game = GetGame(Id);
        games.Remove(game);
    }
}