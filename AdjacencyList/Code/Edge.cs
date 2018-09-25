using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyList.Code
{
    class Edge
    {
        public int Weight;
        public string Vertex;

        public Edge(int weight, string vertex)
        {
            Weight = weight;
            Vertex = vertex;
        }
    }
}
