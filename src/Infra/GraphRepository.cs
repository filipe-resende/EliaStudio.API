using Domain;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;

namespace Repository
{
    public class GraphyRepository : IGraphRepository
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _cliente;

        public GraphyRepository(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _configuration = configuration;
            _cliente = httpClientFactory.CreateClient("graph");
        }

        public async Task<Graph> GetAllItemsAsync()
        {
            string token = _configuration["GRAPH_APP_TOKEN"]!; 

            var response = await _cliente.GetAsync($"/me/media?fields=media_url,permalink,media_type&limit={11}&access_token={token}");
            
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<Graph>();
        }
    }
}