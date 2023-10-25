using BlazorWebApp8.Shared.Entity;
using BlazorWebApp8.Shared.Services;
using System.Net.Http.Json;

namespace BlazorCrudDotNet8.Shared.Services
{
    public class ClientGameService : IGameService
    {
        private readonly HttpClient _httpClient;
        public ClientGameService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Game> AddGame(Game game)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/game", game);
            return await result.Content.ReadFromJsonAsync<Game>();
        }

        public async Task<bool> DeleteGame(int id)
        {
            var result = await _httpClient.DeleteAsync($"/api/gam/{id}");
            return true;
        }

        public async Task<Game> EditGame(int id, Game game)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/game/{id}/games", game);
            return await result.Content.ReadFromJsonAsync<Game>();
        }

        public Task<List<Game>> GetAllGames()
        {
            throw new NotImplementedException();
        }

        public async Task<Game> GetGameById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Game>($"/api/game/{id}");
            return result;
        }
    }
}
