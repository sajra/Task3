using System.Linq;

namespace Task3
{
    public class Connection
    {
        private int[] vertices = new int[2];

        public Connection(int[] vrts) => vertices = vrts;

        public bool isTheSameWith(Connection conn)
        {
            if (vertices.Intersect(conn.vertices).Count().Equals(vertices.Count()))
                return true;
            return false;
        }

        public bool hasCommonParhWith(Connection conn)
        {
            if (vertices.Intersect(conn.vertices).Count() > 0)
                return true;
            return false;
        }
    }
}