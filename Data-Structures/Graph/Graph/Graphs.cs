using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    class Graphs
    {
        public Dictionary<Vertex, List<Vertex>> AdjList { get; set; }
        public Vertex Vertex { get; set; }
        public List<Edges > Edges { get; set; }

        public Graphs()
        {
            AdjList = new Dictionary<Vertex, List<Vertex>>();
            Edges = new List<Edges>();

        }

        //adds node to the graph
        public void AddNode(Vertex vertex)
        {
            AdjList.Add(Vertex, new List<Vertex>());
        }

        //adds edges to the graph
        public Vertex AddEdge(Vertex p1, Vertex p2, int weight)
        {
            Edges.Add(new Edges(p1, p2, weight));
            AdjList[p1].Add(p2);
            return p1;
        }

        // gets a list of the nodes in the graph
        public object GetNodes()
        {
            return AdjList.Keys;
        }

        //returns the list of adjacent verticies of the specified vertex
        public object GetNeighbors(Vertex vertex)
        {
            return AdjList[Vertex];
        }

        //returns the number of nodes (int) in the graph
        public int Size()
        {
            return AdjList.Count;
        }
    }
}
