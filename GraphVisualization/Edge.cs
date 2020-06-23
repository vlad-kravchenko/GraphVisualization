using System.Drawing;

namespace GraphVisualization
{
    public class Edge
    {
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }

        public Edge(Vertex vertex1, Vertex vertex2)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(Vertex1.X, Vertex1.Y), new Point(Vertex2.X, Vertex2.Y));
        }
    }
}