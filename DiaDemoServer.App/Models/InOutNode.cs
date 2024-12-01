using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;
namespace DiaDemoServer.App.Models;

public class InOutNode : CustomSvgNodeModel
{
    public InOutNode(Point? position = null) : base(position) { }
    public InOutNode(string Id, Point? position = null) : base(Id,position) { }
}
