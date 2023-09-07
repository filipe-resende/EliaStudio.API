using Domain;
using Repository;

namespace Service
{
    public class GraphService : IGraphService
    {
        private readonly IGraphRepository _graphRepository;

        public GraphService(IGraphRepository graphRepository)
        {
            _graphRepository = graphRepository;
        }

        public async Task<Graph> GetAllItemsAsync()
        {
            var items = await _graphRepository.GetAllItemsAsync();
            return items;
        }
    }
}