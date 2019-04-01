using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    class Vertex
    {
        public int value { get; set; }

        
        public List<Vertex> Neighbors { get; set; }
    }
}
