﻿namespace DiaDemoServer.App.Models;

public interface ICustomNodeModel
{
    public int NodeId
    {
        get;
        set;
    }

    public string Name
    {
        get;
        set;
    }  
    public string Title
    {
        get;
        set;
    }  
    public string Group
    {
        get;
        set;
    } 
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
    } 
    public string Label
    {
        get;
        set;
    } 
    public string Description
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