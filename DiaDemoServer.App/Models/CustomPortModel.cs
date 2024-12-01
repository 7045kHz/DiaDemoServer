using Blazor.Diagrams.Models;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Models;

namespace DiaDemoServer.App.Models;

public class CustomPortModel :  ICustomPortModel
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
    } = string.Empty;

    public string PortAlignment
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
