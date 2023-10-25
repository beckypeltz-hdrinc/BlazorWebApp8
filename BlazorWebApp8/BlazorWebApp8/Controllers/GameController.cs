using BlazorWebApp8.Shared.Entity;
using BlazorWebApp8.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebApp8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        public async Task<ActionResult<Game>> AddGames(Game game)
        {
            var addedGame = await _gameService.AddGame(game);
            return Ok(addedGame);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<Game>> GetGameById(int id)
        {
            var game = await _gameService.GetGameById(id);
            return Ok(game);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Game>> DeleteGame(int id)
        {
            var result = await _gameService.DeleteGame(id);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Game>> EditGame(int id, Game game)
        {
            var updatedGame = await _gameService.EditGame(id, game);
            return Ok(updatedGame);
        }
    }
}
