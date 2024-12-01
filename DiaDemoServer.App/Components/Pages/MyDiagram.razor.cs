using Blazor.Diagrams.Core;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

/* required to resolve DiagramCanvas component */
using Blazor.Diagrams.Components;
using Blazor.Diagrams.Core.Options;
using Blazor.Diagrams.Options;
using Blazor.Diagrams;
using Microsoft.AspNetCore.Components;
using Blazor.Diagrams.Core.PathGenerators;
using Blazor.Diagrams.Core.Routers;
using Blazor.Diagrams.Models;
using DiaDemoServer.App.Components.Diagrams;
using DiaDemoServer.App.Models;
using System.Xml.Linq;
using Blazor.Diagrams.Core.Models.Base;

namespace DiaDemoServer.App.Components.Pages;

public partial class MyDiagram
{
    private BlazorDiagram Diagram
    {
        get; set;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        
        var options = new BlazorDiagramOptions
        {
            AllowMultiSelection = true, // Whether to allow multi selection using CTRL
            Links =
      {
      },
            Zoom =
      {
        Minimum = 0.5, // Minimum zoom value
        Inverse = false, // Whether to inverse the direction of the zoom when using the wheel
      }
        };
        Diagram = new BlazorDiagram(options);
        Diagram.RegisterComponent<TerminatorNode, TerminatorWidget>();
        Diagram.RegisterComponent<ProcessNode, ProcessWidget>();
        Diagram.RegisterComponent<ConditionNode, ConditionWidget>();
        Diagram.RegisterComponent<InOutNode, InOutWidget>();
        Setup();
    }

    private void Setup()
    {
        var startNode = Diagram.Nodes.Add(new TerminatorNode(new Point( 50, 50)));
        startNode.Title = "Start";
        startNode.AddPort(PortAlignment.Right);
        startNode.AddPort(PortAlignment.Left);
       
        var sdlcNode = Diagram.Nodes.Add(new ProcessNode(new Point(300, 50)));
        sdlcNode.Title = "SDLC";
        sdlcNode.AddPort(PortAlignment.Right);
        sdlcNode.AddPort(PortAlignment.Left);
        
        var ifApprovedNode = Diagram.Nodes.Add(new ConditionNode(new Point(360, 300)));
        ifApprovedNode.Title = "Y/N";
        ifApprovedNode.AddPort(PortAlignment.Top);
        ifApprovedNode.AddPort(PortAlignment.Bottom);
        
        var link = Diagram.Links.Add(new LinkModel(startNode, sdlcNode));
        link.PathGenerator = new StraightPathGenerator();
        link.Router = new OrthogonalRouter();
        link.SourceMarker = LinkMarker.Circle;
        link.TargetMarker = LinkMarker.Arrow;
        link.AddLabel(" Do This");

        var link2 = Diagram.Links.Add(new LinkModel(sdlcNode, ifApprovedNode));
        link2.PathGenerator = new StraightPathGenerator();
        link2.Router = new OrthogonalRouter();
        link2.SourceMarker = LinkMarker.Circle;
        link2.TargetMarker = LinkMarker.Arrow;
        link2.AddLabel("SDLC Approved");

        var cicdNode = Diagram.Nodes.Add(new InOutNode(new Point(600, 290)));
        cicdNode.Title = "CI/CD";
        cicdNode.AddPort(PortAlignment.Right);
        cicdNode.AddPort(PortAlignment.Left);

        var link3 = Diagram.Links.Add(new LinkModel(ifApprovedNode, cicdNode));
        link3.PathGenerator = new StraightPathGenerator();
        link3.Router = new OrthogonalRouter();
        link3.SourceMarker = LinkMarker.Circle;
        link3.TargetMarker = LinkMarker.Arrow;
        link3.AddLabel("YES");

        /*
        var cicdNode = NewNode(300, 300);
        var ifApprovedNode = NewNode(300, 50);
        Diagram.Nodes.Add(new[] { node1, cicdNode, ifApprovedNode });
        var link = Diagram.Links.Add(new LinkModel(node1, cicdNode));
        link.PathGenerator = new StraightPathGenerator();
        link.Router = new OrthogonalRouter();
        link.SourceMarker = LinkMarker.Circle;
        link.TargetMarker = LinkMarker.Arrow;
        link.AddLabel(" Do This") ;
        */
        //  Diagram.Links.Add(new LinkModel(node1.GetPort(PortAlignment.Right), cicdNode.GetPort(PortAlignment.Left)));
    }

    private static NodeModel NewNode(double x, double y)
    {
        var node = new NodeModel(new Point(x, y));

        node.AddPort(PortAlignment.Left);
        node.AddPort(PortAlignment.Right);
        return node;
    }
}
