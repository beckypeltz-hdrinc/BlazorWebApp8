using BlazorWebApp8.Data;
using BlazorWebApp8.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebApp8.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;
        public GameService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Game>> GetAllGames()
        {
            await Task.Delay(1000);
            List<Game> games = await _context.Games.ToListAsync();
            return games;
        }
        public async Task<Game> AddGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
            return game;
        }
    }
}
