using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GraphVisualization
{
    public partial class GraphPanel : Panel
    {
        List<Vertex> points = new List<Vertex>();
        List<Edge> edges = new List<Edge>();
        Vertex prevSelected = null;

        public PanelMode PanelMode { get; set; }

        public GraphPanel()
        {
            InitializeComponent();

            points.Add(new Vertex(100, 150));
            points.Add(new Vertex(200, 120));
            points.Add(new Vertex(300, 90));
            points.Add(new Vertex(400, 160));
            points.Add(new Vertex(500, 290));

            this.MouseDown += PanelMouseDown;
            PanelMode = PanelMode.DrawEdge;
        }

        public void ClearAll()
        {
            edges.Clear();
            points.Clear();
            Invalidate();
        }

        private void PanelMouseDown(object sender, MouseEventArgs e)
        {
            switch (PanelMode)
            {
                case PanelMode.DrawVertex:
                    switch (e.Button)
                    {
                        case MouseButtons.Left:
                            var pointNew = new Vertex(e.Location.X, e.Location.Y);
                            points.Add(pointNew);
                            Invalidate();
                            break;
                        case MouseButtons.Right:
                            var pointRemove = points.FirstOrDefault(p => Math.Abs(p.X - e.Location.X) < 10 && Math.Abs(p.Y - e.Location.Y) < 10);
                            if (pointRemove != null)
                            {
                                edges.RemoveAll(edg => edg.Vertex1 == pointRemove || edg.Vertex2 == pointRemove);
                                points.Remove(pointRemove);
                                Invalidate();
                            }
                            break;
                    }
                    break;
                case PanelMode.DrawEdge:
                    switch (e.Button)
                    {
                        case MouseButtons.Left:
                            if (prevSelected == null)
                            {
                                prevSelected = points.FirstOrDefault(p => Math.Abs(p.X - e.Location.X) < 10 && Math.Abs(p.Y - e.Location.Y) < 10);
                                if (prevSelected != null)
                                    Invalidate();
                            }
                            else
                            {
                                var current = points.FirstOrDefault(p => Math.Abs(p.X - e.Location.X) < 10 && Math.Abs(p.Y - e.Location.Y) < 10);
                                if (current != null)
                                {
                                    var edge = new Edge(prevSelected, current);
                                    edges.Add(edge);
                                    prevSelected = null;
                                    Invalidate();
                                }
                            }
                            break;
                        case MouseButtons.Right:
                            if (prevSelected == null)
                            {
                                prevSelected = points.FirstOrDefault(p => Math.Abs(p.X - e.Location.X) < 10 && Math.Abs(p.Y - e.Location.Y) < 10);
                                if (prevSelected != null)
                                    Invalidate();
                            }
                            else
                            {
                                var current = points.FirstOrDefault(p => Math.Abs(p.X - e.Location.X) < 10 && Math.Abs(p.Y - e.Location.Y) < 10);
                                if (current != null)
                                {
                                    edges.RemoveAll(edge => edge.Vertex1 == prevSelected && edge.Vertex2 == current);
                                    edges.RemoveAll(edge => edge.Vertex2 == prevSelected && edge.Vertex1 == current);
                                    prevSelected = null;
                                    Invalidate();
                                }
                            }
                            break;
                    }
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            points.ForEach(p => p.Draw(e.Graphics));
            edges.ForEach(p => p.Draw(e.Graphics));
        }
    }
}
