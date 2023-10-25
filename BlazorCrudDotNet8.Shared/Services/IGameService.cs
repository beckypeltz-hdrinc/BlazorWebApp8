using BlazorWebApp8.Shared.Entity;
namespace BlazorWebApp8.Shared.Services
{
    public interface IGameService
    {
        public Task<List<Game>> GetAllGames();
        Task<Game> GetGameById(int id);
        public Task<Game> AddGame(Game game);
        public Task<Game> EditGame(int id, Game game);
        public Task<bool> DeleteGame(int id);
    }
}
