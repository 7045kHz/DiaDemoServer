using Blazor.Diagrams.Models;

namespace DiaDemoServer.App.Models;

public class DiagramProcessLinkModel :  IDiagramProcessLinkModel
{
    public int ProcessId
    {
        get;
        set;
    }

    public int SourceNodeId
    {
        get;
        set;
    }
    public int TargetNodeId
    {
        get;
        set;
    }

    public string Label
    {
        get;
        set;
    } = string.Empty;

    public string PathGenerator
    {
        get;
        set;
    } = string.Empty;
    public string Router
    {
        get;
        set;
    } = string.Empty;
    public string SourceMaker
    {
        get;
        set;
    } = string.Empty;
    public string TargetMaker
    {
        get;
        set;
    } = string.Empty;
    public bool IsOnError
    {
        get;
        set;
    }
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
