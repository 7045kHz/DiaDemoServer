using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;
namespace DiaDemoServer.App.Models;

public class TerminatorNode : CustomSvgNodeModel
{
    public TerminatorNode(Point? position = null) : base(position) { }
    public TerminatorNode(string Id, Point? position = null) : base(Id,position) { }
}
