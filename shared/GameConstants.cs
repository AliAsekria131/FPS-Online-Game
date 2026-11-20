// Project: FPS Online
// File: GameConstants.cs
// Version: 0.1.0
// Last Modified: 2026-11-20
// Changes: Initial creation.

namespace FPS.Shared;

public static class GameConstants
{
    public const int MaxPlayersPerTeam = 5;
    public const int MaxPlayersTotal = MaxPlayersPerTeam * 2;
    public const int DefaultPlayerHealth = 100;
    public const float DefaultMovementSpeed = 5.0f;
}