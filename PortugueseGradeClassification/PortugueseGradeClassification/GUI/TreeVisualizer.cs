using PortugueseGradeClassification.DecisionTreeSpace;
using PortugueseGradeClassification.Model;
using PortugueseGradeClassification.TreeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeNode = PortugueseGradeClassification.TreeView.TreeNode;

namespace PortugueseGradeClassification.GUI
{
    public partial class TreeVisualizer : UserControl
    {

        private DepartmentManager manager;
        private Node rootNode;
        private TreeNode graphRoot;
        public TreeVisualizer()
        {
            InitializeComponent();
        }

        public void SetManager(DepartmentManager manager)
        {
            this.manager = manager;
            this.rootNode = manager.getTreeRootNode();

            this.graphRoot = new TreeNode(new InformationNode(rootNode.ToString()));
            this.GenerateTree(rootNode);
            this.Arrange();
        }

        private void drawTreeButton_Click(object sender, EventArgs e)
        {

            /*
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            graphRoot.DrawTree(e.Graphics);
            Console.WriteLine("finaliza la tarea" + graphRoot);
            */
        }

        private void GenerateTree(Node rootTree)
        {
            this.graphRoot = new TreeNode(new InformationNode(rootTree.ToString()));
            //Console.WriteLine(rootTree.ToString());

            if (((DecisionNode)rootTree).TrueNode != null)
            {
                AddNode(((DecisionNode)rootTree).TrueNode, this.graphRoot);
            }

            if (((DecisionNode)rootTree).FalseNode != null)
            {
                AddNode(((DecisionNode)rootTree).TrueNode, this.graphRoot);
            }
        }

        private void AddNode(Node t, TreeNode parent)
        {

            TreeNode newNode = new TreeNode(new InformationNode(t.ToString()));
            //Console.WriteLine(t.ToString());

            if (parent.TrueNode == null)
            {
                parent.TrueNode = newNode;
            }
            else
            {
                parent.FalseNode = newNode;
            }
            if (t is DecisionNode)
            {
                if (((DecisionNode)t).TrueNode != null)
                {
                    AddNode(((DecisionNode)t).TrueNode, newNode);
                }
                if (((DecisionNode)t).FalseNode != null)
                {
                    AddNode(((DecisionNode)t).FalseNode, newNode);
                }
            }

        }

        private void Arrange()
        {
            using (Graphics gr = pictureBox1.CreateGraphics())
            {
                float xmin = 0, ymin = 0;
                graphRoot.Arrange(gr, ref xmin, ref ymin);

                xmin = (pictureBox1.ClientSize.Width - xmin) / 2;
                ymin = 10;
                this.graphRoot.Arrange(gr, ref xmin, ref ymin);

            }

            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            if (graphRoot!=null)
            {
                graphRoot.DrawTree(e.Graphics);
            }
        }


    }
}
