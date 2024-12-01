using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;
namespace DiaDemoServer.App.Models;

public class ProcessNode : CustomSvgNodeModel
{
    public ProcessNode(Point? position = null) : base(position) { }
    public ProcessNode(string Id, Point? position = null) : base(Id,position) { }
}
