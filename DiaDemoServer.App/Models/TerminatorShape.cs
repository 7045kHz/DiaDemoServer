using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;
namespace DiaDemoServer.App.Models;

public class TerminatorShape : DiagramSvgNodeModel
{
    public TerminatorShape(Point? position = null) : base(position) { }
    public TerminatorShape(string Id, Point? position = null) : base(Id,position) { }
}
