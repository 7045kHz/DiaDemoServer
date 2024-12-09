namespace DiaDemoServer.App.Models;

public interface IDiagramProcessLinkModel
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
    }  

    public string PathGenerator
    {
        get;
        set;
    }  
    public string Router
    {
        get;
        set;
    }  
    public string SourceMaker
    {
        get;
        set;
    }  
    public string TargetMaker
    {
        get;
        set;
    } 
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
    }  

    public DateTime LastUpdated
    {
        get;
        set;
    }
}