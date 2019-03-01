using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    class Edges
    {
        public Vertex VertA { get; set; }
        public Vertex VertB { get; set; }
        public int Weight { get; set; }


        public Edges(Vertex a, Vertex b, int weight)
        { 
            //edge on the left
            VertA = a;
            //edge on the right    
            VertB = b;
            //weight of edge
            Weight = weight;
        }


    }
}
