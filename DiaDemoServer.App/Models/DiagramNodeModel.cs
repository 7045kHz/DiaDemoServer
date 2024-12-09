using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Models;
namespace DiaDemoServer.App.Models;

public class DiagramNodeModel : NodeModel, IDiagramNodeModel
{
    public DiagramNodeModel(Point? position = null) : base(position) { }
    public DiagramNodeModel(string? Id, Point? position = null) : base(Id, position) { }
    public int NodeId
    {
        get;
        set;
    }

    public string Name
    {
        get;
        set;
    } = string.Empty;
    public string Title
    {
        get;
        set;
    } = string.Empty;
    public string Group
    {
        get;
        set;
    } = string.Empty;
    public double X
    {
        get; set;
    }
    public double Y
    {
        get; set;
    }
    public double L
    {
        get; set;
    }
    public string FlowType
    {
        get;
        set;
    } = string.Empty;
    public string Label
    {
        get;
        set;
    } = string.Empty;
    public string Description
    {
        get;
        set;
    } = string.Empty;

    public string Action
    {
        get;
        set;
    } = string.Empty;
    public bool IsActive
    {
        get;
        set;
    }
    public string LastUpdatedBy
    {
        get;
        set;
    } = string.Empty;

    public DateTime LastUpdated
    {
        get;
        set;
    }
}
