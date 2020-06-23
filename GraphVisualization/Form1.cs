using System;
using System.Windows.Forms;

namespace GraphVisualization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PanelModeChanged(object sender, EventArgs e)
        {
            if (rbEdge.Checked)
                mainPanel.PanelMode = PanelMode.DrawEdge;
            else if (rbVertex.Checked)
                mainPanel.PanelMode = PanelMode.DrawVertex;
            mainPanel.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mainPanel.ClearAll();
        }
    }
}