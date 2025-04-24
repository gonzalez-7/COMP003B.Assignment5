using COMP003B.Assignment5.Models;

namespace COMP003B.Assignment5.Data
{
	public static class GameStore
	{
		public static List<BoardGame> Games { get; } = new List<BoardGame>
		{
			new BoardGame { Id = 1, Title = "Catan", MinPlayers = 3, MaxPlayers = 4, Rating = 4.5M },
			new BoardGame { Id = 2, Title = "Carcassonne", MinPlayers = 2, MaxPlayers = 5, Rating = 4.2M },
			new BoardGame { Id = 3, Title = "Ticket to Ride", MinPlayers = 2, MaxPlayers = 5, Rating = 4.7M }
		};
	}
}
