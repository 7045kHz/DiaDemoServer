using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;
namespace DiaDemoServer.App.Models;

public class ConditionShape : DiagramSvgNodeModel
{
    public ConditionShape(Point? position = null) : base(position) { }
    public ConditionShape(string Id, Point? position = null) : base(Id, position) { }
}
