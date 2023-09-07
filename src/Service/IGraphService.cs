using Domain;

namespace Service
{
    public interface IGraphService
    {
        Task<Graph> GetAllItemsAsync();
    }
}
