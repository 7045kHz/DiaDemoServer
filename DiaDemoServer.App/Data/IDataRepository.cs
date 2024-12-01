using DiaDemoServer.App.Models;

namespace DiaDemoServer.App.Data;

public interface IDataRepository
{
    Task<IEnumerable<CustomNodeModel>> GetAllNodesAsync();
    Task<IEnumerable<CustomPortModel>> GetAllPortsAsync();

    Task<IEnumerable<CustomProcessModel>> GetAllProcessAsync();
    Task<IEnumerable<CustomProcessLinkModel>> GetAllProcessLinksAsync();
}