using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdjacencyList.Code;

namespace AdjacencyList
{
    class Program
    {
        static void Main(string[] args)
        {

            Graph graph = new Graph(10);

            graph.Add("ORGANIC", 10, 0);
            graph.Add("HOMOSAPIANS", 20, 0);
            graph.Add("HUMANS", 30, 0);
            graph.Add("PLATO", 40, 0);

            graph.Add("MATERIAL", 10, 1);
            graph.Add("METAL", 20, 1);
            graph.Add("CAR", 30, 1);
            graph.Add("BMW", 40, 1);

            Console.WriteLine(graph);
            Console.WriteLine(graph.IsConnected(0,"HUMANS"));


        }
    }
}
