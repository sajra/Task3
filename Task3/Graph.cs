using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    public class Graph
    {
        private List<Connection> connections = new List<Connection>();

        public Graph(Connection conn) => connections.Add(conn);

        public List<Connection> Connections
        {
            get => connections;
            set => connections = value;
        }

        public bool isTheSameWith(Graph graphToCheck)
        {
            var connFound = true;
            foreach (Connection conn in connections)
            {
                if (!connFound)
                    return false;
                connFound = false;
                foreach (Connection connToCompare in graphToCheck.connections)
                {
                    if (conn.isTheSameWith(connToCompare))
                    {
                        connFound = true;
                        continue;
                    }
                }
            }
            return connFound;
        }

        public bool isEmpty()
        {
            if (connections.Count().Equals(0))
                return true;
            return false;
        }

        public bool hasCommonPartWith(Graph graphToCheck)
        {
            foreach (Connection conn in connections)
            {
                foreach (Connection connToCompare in graphToCheck.connections)
                {
                    if (conn.hasCommonParhWith(connToCompare))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void mergeWith(Graph graphToMerge)
        {
            connections.AddRange(graphToMerge.connections);
            graphToMerge.connections.Clear();
        }
    }
}
