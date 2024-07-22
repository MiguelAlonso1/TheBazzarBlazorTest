using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services;

public class GameService(DataContext context) : IGameService
{
    public async Task<Game> AddGame(Game game)
    {
        var statItem = new Game
        {
            Username = game?.Username ?? string.Empty,
            Email = "testEmail@gmail.com",
            CurrentLevel = 9,
            ExperiencePoints = 9,
            ExperiencePointsToNextLevel = 9,
            TotalGamesPlayed = 9,
            TotalWins = 9,
            TotalLosses = 9,
            FriendsCount = 9,
            MessagesSent = 9,
            MessagesReceived = 9
        };
        
        context.Games.Add(statItem);
        await context.SaveChangesAsync();

        return statItem;
    }

    public async Task<bool> DeleteGame(int id)
    {
        var dbGame = await context.Games.FindAsync(id);
        if(dbGame != null)
        {
            context.Remove(dbGame);
            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<Game> EditGame(int id, Game game)
    {
        var dbGame = await context.Games.FindAsync(id);
        if(dbGame != null)
        {
            dbGame.Username = game.Username;
            await context.SaveChangesAsync();
            return dbGame;
        }
        throw new Exception("Game not found.");
    }

    public async Task<List<Game>> GetAllGames()
    {
        await Task.Delay(1000);

        var games = await context.Games.ToListAsync();
        return games;
    }

    public async Task<Game> GetGameById(int id)
    {
        return await context.Games.FindAsync(id);
    }
}