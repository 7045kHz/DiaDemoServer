using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;
namespace DiaDemoServer.App.Models;

public class InOutShape : DiagramSvgNodeModel
{
    public InOutShape(Point? position = null) : base(position) { }
    public InOutShape(string Id, Point? position = null) : base(Id,position) { }
}
