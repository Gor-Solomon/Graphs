using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyList.Code
{
    class Graph
    {
        LinkedList<Edge>[] _edges;
        public Graph(int vertex)
        {
            _edges = new LinkedList<Edge>[vertex];

            for (int i = 0; i < 10; i++)
            {
                _edges[i] = new LinkedList<Edge>();
            }
        }

        public void Add(string vertx, int weight, int list)
        {
            _edges[list].AddLast(new Edge(weight, vertx));
        }

        public bool IsConnected(int u, string v)
        {
            return _edges[u].Any(edge => edge.Vertex == v);
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (var items in _edges)
            {
                foreach (var item in items)
                {
                    result += "(" + item.Vertex + "," + item.Weight + ")" + "-> ";
                }

                if(items.Count > 0)
                {
                    result = result.Remove(result.Length - 3, 3);
                    result += "\n";
                }
            }

            return result;
        }

    }
}
