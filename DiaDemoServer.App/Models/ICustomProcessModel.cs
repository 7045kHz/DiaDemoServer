namespace DiaDemoServer.App.Models;

public interface ICustomProcessModel
{
    public int ProcessId
    {
        get;
        set;
    }
    public string ProcessType
    {
        get;
        set;
    } 
    public string Description
    {
        get;
        set;
    } 
    public string Label
    {
        get;
        set;
    } 


    public string Action
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