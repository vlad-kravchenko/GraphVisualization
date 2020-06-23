using System.Drawing;

namespace GraphVisualization
{
    public class Vertex
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vertex(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public void Draw(Graphics g)
        {
            var rect = new Rectangle(X, Y, 20, 20);
            rect.Offset(-10, -10);
            g.FillEllipse(Brushes.Red, rect);
        }
    }
}