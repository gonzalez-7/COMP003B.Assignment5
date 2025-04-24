namespace COMP003B.Assignment5.Models
{
	public class BoardGame
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public int MinPlayers { get; set; }
		public int MaxPlayers { get; set; }
		public decimal Rating { get; set; }
	}
}
