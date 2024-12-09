using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;
namespace DiaDemoServer.App.Models;

public class ProcessShape : DiagramSvgNodeModel
{
    public ProcessShape(Point? position = null) : base(position) { }
    public ProcessShape(string Id, Point? position = null) : base(Id,position) { }
}
