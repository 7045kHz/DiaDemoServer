using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;
namespace DiaDemoServer.App.Models;

public class PersonShape : DiagramNodeModel
{
    public PersonShape(Point? position = null) : base(position) { }
    public PersonShape(string Id, Point? position = null) : base(Id,position) { }
}
