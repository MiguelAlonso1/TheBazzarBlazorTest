using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCrudDotNet8.Shared.Entity;

public class Game
{
    public int Id { get; set; }

    // Basic Account Information
    public string Username { get; set; }
    public string Email { get; set; }

    // Player Stats
    public int CurrentLevel { get; set; }
    public int ExperiencePoints { get; set; }
    public int ExperiencePointsToNextLevel { get; set; } // XP needed for next level

    // Game Performance
    public int TotalGamesPlayed { get; set; }
    public int TotalWins { get; set; }
    public int TotalLosses { get; set; }
    
    // Community Interaction 
    public int FriendsCount { get; set; }
    public int MessagesSent { get; set; }
    public int MessagesReceived { get; set; }
    
    // Calculated properties (not mapped to database)
    [NotMapped] 
    public double WinLossRatio => TotalGamesPlayed > 0 ? (double)TotalWins / TotalGamesPlayed : 0;
}