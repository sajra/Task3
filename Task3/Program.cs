using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba połączeń: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Graph> graphs = new List<Graph>();
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Podaj koordynaty połączenia: ");
                string[] conn = Console.ReadLine().Split(' ');
                graphs.Add(new Graph(new Connection(new int[] { Convert.ToInt32(conn[0]), Convert.ToInt32(conn[1]) })));
            }

            foreach (Graph graph in graphs)
            {
                if (graph.isEmpty())
                    continue;
                foreach (Graph graphToCheck in graphs)
                {
                    if (graph.isTheSameWith(graphToCheck) || graph.isEmpty() || graphToCheck.isEmpty())
                        continue;

                    if (graph.hasCommonPartWith(graphToCheck))
                        graph.mergeWith(graphToCheck);
                }
            }

            Console.WriteLine("Liczba grafów: " + graphs.Where(graph => graph.Connections.Count() > 0).Count());
        }
    }
}
