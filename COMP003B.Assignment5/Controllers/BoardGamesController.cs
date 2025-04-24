using COMP003B.Assignment5.Models;
using COMP003B.Assignment5.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment5.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BoardGamesController : ControllerBase
	{
		[HttpGet]
		public ActionResult<List<BoardGame>> Get() => GameStore.Games;

		[HttpGet("{id}")]
		public ActionResult<BoardGame> Get(int id)
		{
			var game = GameStore.Games.FirstOrDefault(g => g.Id == id);
			return game == null ? NotFound() : Ok(game);
		}

		[HttpPost]
		public ActionResult<BoardGame> Post(BoardGame newGame)
		{
			newGame.Id = GameStore.Games.Max(g => g.Id) + 1;
			GameStore.Games.Add(newGame);
			return CreatedAtAction(nameof(Get), new { id = newGame.Id }, newGame);
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, BoardGame updatedGame)
		{
			var game = GameStore.Games.FirstOrDefault(g => g.Id == id);
			if (game == null) return NotFound();
			if (id != updatedGame.Id) return BadRequest();

			game.Title = updatedGame.Title;
			game.MinPlayers = updatedGame.MinPlayers;
			game.MaxPlayers = updatedGame.MaxPlayers;
			game.Rating = updatedGame.Rating;

			return NoContent();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var game = GameStore.Games.FirstOrDefault(g => g.Id == id);
			if (game == null) return NotFound();
			GameStore.Games.Remove(game);
			return NoContent();
		}
	}
}
