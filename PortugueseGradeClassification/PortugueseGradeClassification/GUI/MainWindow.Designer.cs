
namespace PortugueseGradeClassification.GUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableFilter1 = new PortugueseGradeClassification.GUI.TableFilter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.graphView1 = new PortugueseGradeClassification.GUI.GraphView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.decisionTreeControl1 = new PortugueseGradeClassification.GUI.DecisionTreeControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.treeVisualizer1 = new PortugueseGradeClassification.GUI.TreeVisualizer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1122, 659);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1114, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableFilter1
            // 
            this.tableFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFilter1.Location = new System.Drawing.Point(3, 3);
            this.tableFilter1.Name = "tableFilter1";
            this.tableFilter1.Size = new System.Drawing.Size(1108, 627);
            this.tableFilter1.TabIndex = 0;
            this.tableFilter1.Load += new System.EventHandler(this.tableFilter1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.graphView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1114, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graph";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // graphView1
            // 
            this.graphView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphView1.Location = new System.Drawing.Point(3, 3);
            this.graphView1.Name = "graphView1";
            this.graphView1.Size = new System.Drawing.Size(1108, 627);
            this.graphView1.TabIndex = 0;
            this.graphView1.Load += new System.EventHandler(this.graphView1_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.decisionTreeControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1114, 633);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Decision Tree";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // decisionTreeControl1
            // 
            this.decisionTreeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionTreeControl1.Location = new System.Drawing.Point(0, 0);
            this.decisionTreeControl1.Name = "decisionTreeControl1";
            this.decisionTreeControl1.Size = new System.Drawing.Size(1114, 633);
            this.decisionTreeControl1.TabIndex = 0;
            this.decisionTreeControl1.Load += new System.EventHandler(this.decisionTreeView_Load);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.treeVisualizer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1114, 633);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tree graph";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // treeVisualizer1
            // 
            this.treeVisualizer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeVisualizer1.Location = new System.Drawing.Point(0, 0);
            this.treeVisualizer1.Name = "treeVisualizer1";
            this.treeVisualizer1.Size = new System.Drawing.Size(1114, 633);
            this.treeVisualizer1.TabIndex = 0;
            this.treeVisualizer1.Load += new System.EventHandler(this.treeVisualizer1_Load);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 659);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "Portuguese grade classification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private TableFilter tableFilter1;
        private GraphView graphView1;
        private DecisionTreeControl decisionTreeControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private TreeVisualizer treeVisualizer1;
    }
}