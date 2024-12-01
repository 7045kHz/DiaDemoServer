using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;
namespace DiaDemoServer.App.Models;

public class ConditionNode : CustomSvgNodeModel
{
    public ConditionNode(Point? position = null) : base(position) { }
    public ConditionNode(string Id, Point? position = null) : base(Id, position) { }
}
