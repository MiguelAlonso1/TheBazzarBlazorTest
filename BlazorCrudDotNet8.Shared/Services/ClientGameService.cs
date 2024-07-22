using BlazorCrudDotNet8.Shared.Entity;
using System.Net.Http.Json;

namespace BlazorCrudDotNet8.Shared.Services;

public class ClientGameService(HttpClient httpClient) : IGameService
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
        
        var result = await httpClient
            .PostAsJsonAsync("/api/game", statItem);
        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public async Task<bool> DeleteGame(int id)
    {
        var result = await httpClient.DeleteAsync($"/api/game/{id}");
        return await result.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<Game> EditGame(int id, Game game)
    {
        var result = await httpClient.PutAsJsonAsync($"/api/game/{id}", game);
        return await result.Content.ReadFromJsonAsync<Game>();
    }

    public async Task<List<Game>> GetAllGames()
    {
        var result = await httpClient
            .GetFromJsonAsync<List<Game>>($"/api/game");
        return result;
    }

    public async Task<Game> GetGameById(int id)
    {
        var result = await httpClient
            .GetFromJsonAsync<Game>($"/api/game/{id}");
        return result;
    }
}