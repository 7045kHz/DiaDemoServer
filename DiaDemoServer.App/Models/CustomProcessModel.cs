using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;
namespace DiaDemoServer.App.Models;

public class CustomProcessModel :ICustomProcessModel
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
    } = string.Empty;
    public string Description
    {
        get;
        set;
    } = string.Empty;
    public string Label
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
