using Domain;

namespace Repository
{
    public interface IGraphRepository
    {
        Task<Graph> GetAllItemsAsync();
    }
}
