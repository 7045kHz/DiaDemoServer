namespace DiaDemoServer.App.Models;

public interface ICustomPortModel
{
    public int PortId
    {
        get;
        set;
    }

    public int NodeId
    {
        get;
        set;
    }


    public string Label
    {
        get;
        set;
    }  

    public string PortAlignment
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