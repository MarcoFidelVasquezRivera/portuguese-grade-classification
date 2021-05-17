using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.TreeView
{
    public class TreeNode
    {
        private InformationNode data;

        public TreeNode TrueNode { get; set; }
        public TreeNode FalseNode { get; set; }

        private float HOffSet = 5;
        private float VOffset = 10;

        private float indent = 20;
        private float spotRadius = 5;

        private PointF dataCenter;

        public Font font = new Font("Snap ITC", 12);
        public Pen pen = Pens.Black;
        public Brush fontBrush = Brushes.Black;
        public Brush backgroundBrush = Brushes.White;

        public TreeNode(InformationNode new_data)
        {
            this.data = new_data;
        }
        public TreeNode(InformationNode new_data, Font font)
        {
            this.data = new_data;
            this.font = font;
        }

        public void SetTreeDrawingParameters(float h_offset, float v_offset, float indent, float node_radius)
        {
            HOffSet = h_offset;
            VOffset = v_offset;
            this.indent = indent;
            spotRadius = node_radius;

            this.TrueNode.SetTreeDrawingParameters(h_offset, v_offset, indent, node_radius);
            this.FalseNode.SetTreeDrawingParameters(h_offset, v_offset, indent, node_radius);
        }

        public void Arrange(Graphics gr, ref float xmin, ref float ymin)
        {
            this.ArrangeHorizontally(gr, ref xmin, ref ymin);
        }

        private void ArrangeHorizontally(Graphics graph, ref float xmin, ref float ymin)
        {
            SizeF size = data.GetSize(graph, this.font);

            float x = xmin;
            float biggest_ymin = ymin + size.Height;
            float subtree_ymin = ymin + size.Height + VOffset;


            if (this.TrueNode != null)
            {
                float child_ymin = subtree_ymin;
                this.TrueNode.Arrange(graph, ref x, ref child_ymin);

                if (biggest_ymin < child_ymin) biggest_ymin = child_ymin;

                x += HOffSet;
            }

            if (this.FalseNode != null)
            {
                float child_ymin = subtree_ymin;
                this.FalseNode.Arrange(graph, ref x, ref child_ymin);

                if (biggest_ymin < child_ymin)
                    biggest_ymin = child_ymin;

                x += HOffSet;
            }

            if (this.TrueNode != null || this.FalseNode != null)
                x -= HOffSet;


            float subtree_width = x - xmin;
            if (size.Width > subtree_width)
            {
                x = xmin + (size.Width - subtree_width) / 2;

                if (this.TrueNode != null)
                {
                    this.TrueNode.Arrange(graph, ref x, ref subtree_ymin);
                    x += HOffSet;
                }

                if (this.FalseNode != null)
                {
                    this.FalseNode.Arrange(graph, ref x, ref subtree_ymin);
                    x += HOffSet;
                }

                subtree_width = size.Width;
            }

            dataCenter = new PointF(xmin + subtree_width / 2,ymin + size.Height / 2);


            xmin += subtree_width;
            ymin = biggest_ymin;
        }

        public void DrawTree(Graphics gr, ref float x, float y)
        {
            Arrange(gr, ref x, ref y);
            DrawTree(gr);
        }

        public void DrawTree(Graphics gr)
        {
            DrawSubtreeLinks(gr);
            DrawSubtreeNodes(gr);
        }

        private void DrawSubtreeLinks(Graphics gr)
        {
            DrawSubtreeLinksHorizontal(gr);
        }

        private void DrawSubtreeLinksHorizontal(Graphics graph)
        {
            if (this.TrueNode != null)
            {
                graph.DrawLine(this.pen, dataCenter, this.TrueNode.dataCenter);
                this.TrueNode.DrawSubtreeLinksHorizontal(graph);
            }
            if (this.FalseNode != null)
            {
                graph.DrawLine(this.pen, dataCenter, this.FalseNode.dataCenter);
                this.FalseNode.DrawSubtreeLinksHorizontal(graph);
            }
        }

        // Draw the nodes for the subtree rooted at this node.
        private void DrawSubtreeNodes(Graphics graph)
        {
            this.data.Draw(dataCenter.X, dataCenter.Y, graph, this.pen, this.backgroundBrush, this.fontBrush, this.font);

            if (this.TrueNode != null)
            {
                this.TrueNode.DrawSubtreeNodes(graph);
            }
            if (this.FalseNode != null)
            {
                this.FalseNode.DrawSubtreeNodes(graph);
            }
        }
    }
}
