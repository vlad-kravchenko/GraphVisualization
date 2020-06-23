namespace GraphVisualization
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.modePanel = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbEdge = new System.Windows.Forms.RadioButton();
            this.rbVertex = new System.Windows.Forms.RadioButton();
            this.mainPanel = new GraphVisualization.GraphPanel();
            this.modePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // modePanel
            // 
            this.modePanel.Controls.Add(this.btnClear);
            this.modePanel.Controls.Add(this.rbEdge);
            this.modePanel.Controls.Add(this.rbVertex);
            this.modePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.modePanel.Location = new System.Drawing.Point(0, 0);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(800, 40);
            this.modePanel.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(186, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbEdge
            // 
            this.rbEdge.AutoSize = true;
            this.rbEdge.Location = new System.Drawing.Point(103, 12);
            this.rbEdge.Name = "rbEdge";
            this.rbEdge.Size = new System.Drawing.Size(77, 17);
            this.rbEdge.TabIndex = 1;
            this.rbEdge.Text = "Draw edge";
            this.rbEdge.UseVisualStyleBackColor = true;
            this.rbEdge.CheckedChanged += new System.EventHandler(this.PanelModeChanged);
            // 
            // rbVertex
            // 
            this.rbVertex.AutoSize = true;
            this.rbVertex.Checked = true;
            this.rbVertex.Location = new System.Drawing.Point(12, 12);
            this.rbVertex.Name = "rbVertex";
            this.rbVertex.Size = new System.Drawing.Size(82, 17);
            this.rbVertex.TabIndex = 0;
            this.rbVertex.TabStop = true;
            this.rbVertex.Text = "Draw vertex";
            this.rbVertex.UseVisualStyleBackColor = true;
            this.rbVertex.CheckedChanged += new System.EventHandler(this.PanelModeChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.LightBlue;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.PanelMode = GraphVisualization.PanelMode.DrawVertex;
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modePanel);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph visualization";
            this.modePanel.ResumeLayout(false);
            this.modePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GraphPanel mainPanel;
        private System.Windows.Forms.Panel modePanel;
        private System.Windows.Forms.RadioButton rbEdge;
        private System.Windows.Forms.RadioButton rbVertex;
        private System.Windows.Forms.Button btnClear;
    }
}

