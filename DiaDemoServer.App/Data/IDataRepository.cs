using DiaDemoServer.App.Models;

namespace DiaDemoServer.App.Data;

public interface IDataRepository
{
    Task<IEnumerable<CustomSvgNodeModel>> GetAllNodesAsync();
}