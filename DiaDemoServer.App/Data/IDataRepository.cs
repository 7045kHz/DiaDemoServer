using DiaDemoServer.App.Models;

namespace DiaDemoServer.App.Data;

public interface IDataRepository
{
    Task<IEnumerable<DiagramNodeModel>> GetAllNodesAsync();
    Task<IEnumerable<DiagramPortModel>> GetAllPortsAsync();

    Task<IEnumerable<DiagramProcessModel>> GetAllProcessAsync();
    Task<IEnumerable<DiagramProcessLinkModel>> GetAllProcessLinksAsync();
}