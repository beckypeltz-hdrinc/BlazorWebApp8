using BlazorWebApp8.Entity;

namespace BlazorWebApp8.Services
{
    public interface IGameService
    {
        public Task<List<Game>> GetAllGames();
        public Task<Game> AddGame(Game game);

    }
}
