
namespace PortugueseGradeClassification.Gui
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PortuGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.PortuComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PortuTable = new System.Windows.Forms.DataGridView();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.FilterText1 = new System.Windows.Forms.TextBox();
            this.FilterText2 = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.BiComboBox = new System.Windows.Forms.ComboBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortuGraph)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortuTable)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(833, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Classification";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PortuComboBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.PortuGraph);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(833, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Charts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PortuGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.PortuGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PortuGraph.Legends.Add(legend1);
            this.PortuGraph.Location = new System.Drawing.Point(284, 6);
            this.PortuGraph.Name = "PortuGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PortuGraph.Series.Add(series1);
            this.PortuGraph.Size = new System.Drawing.Size(443, 359);
            this.PortuGraph.TabIndex = 1;
            this.PortuGraph.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose graphic data";
            // 
            // PortuComboBox
            // 
            this.PortuComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortuComboBox.FormattingEnabled = true;
            this.PortuComboBox.Items.AddRange(new object[] {
            "School name",
            "Free time",
            "Study time",
            "Address",
            "Internet access"});
            this.PortuComboBox.Location = new System.Drawing.Point(28, 97);
            this.PortuComboBox.Name = "PortuComboBox";
            this.PortuComboBox.Size = new System.Drawing.Size(180, 22);
            this.PortuComboBox.TabIndex = 3;
            this.PortuComboBox.Text = "Field...";
            this.PortuComboBox.SelectedIndexChanged += new System.EventHandler(this.PortuComboBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BiComboBox);
            this.tabPage1.Controls.Add(this.FilterButton);
            this.tabPage1.Controls.Add(this.FilterText2);
            this.tabPage1.Controls.Add(this.FilterText1);
            this.tabPage1.Controls.Add(this.FilterComboBox);
            this.tabPage1.Controls.Add(this.PortuTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(833, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PortuTable
            // 
            this.PortuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PortuTable.Location = new System.Drawing.Point(8, 6);
            this.PortuTable.Name = "PortuTable";
            this.PortuTable.Size = new System.Drawing.Size(818, 318);
            this.PortuTable.TabIndex = 0;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "School",
            "Sex",
            "Age",
            "Address",
            "Family size",
            "Parents status",
            "Mother\'s education",
            "Father\'s education",
            "Mother\'s job",
            "Father\'s job",
            "Reason",
            "Guardian",
            "Travel time",
            "Study time",
            "Failures",
            "School support",
            "Family support",
            "Extra paid classes",
            "Extra activities",
            "Nursery",
            "Higher education",
            "Internet access",
            "Romantic relationship",
            "Family relation",
            "Free time",
            "Go out",
            "Weekday alcohol",
            "Weekend alcohol",
            "Health",
            "Absences",
            "Grade 1",
            "Grade 2",
            "Grade 3"});
            this.FilterComboBox.Location = new System.Drawing.Point(9, 331);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(121, 21);
            this.FilterComboBox.TabIndex = 1;
            this.FilterComboBox.Text = "Filter by...";
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // FilterText1
            // 
            this.FilterText1.Location = new System.Drawing.Point(217, 331);
            this.FilterText1.Name = "FilterText1";
            this.FilterText1.Size = new System.Drawing.Size(100, 20);
            this.FilterText1.TabIndex = 2;
            this.FilterText1.Visible = false;
            // 
            // FilterText2
            // 
            this.FilterText2.Location = new System.Drawing.Point(323, 331);
            this.FilterText2.Name = "FilterText2";
            this.FilterText2.Size = new System.Drawing.Size(100, 20);
            this.FilterText2.TabIndex = 3;
            this.FilterText2.Visible = false;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(136, 330);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 4;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // BiComboBox
            // 
            this.BiComboBox.FormattingEnabled = true;
            this.BiComboBox.Location = new System.Drawing.Point(217, 331);
            this.BiComboBox.Name = "BiComboBox";
            this.BiComboBox.Size = new System.Drawing.Size(121, 21);
            this.BiComboBox.TabIndex = 5;
            this.BiComboBox.Text = "Pick a value...";
            this.BiComboBox.Visible = false;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Location = new System.Drawing.Point(0, 2);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(841, 399);
            this.TabControl1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 401);
            this.Controls.Add(this.TabControl1);
            this.Name = "MainWindow";
            this.Text = "Portuguese grade classification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed_1);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortuGraph)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortuTable)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox PortuComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart PortuGraph;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox BiComboBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.TextBox FilterText2;
        private System.Windows.Forms.TextBox FilterText1;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.DataGridView PortuTable;
        private System.Windows.Forms.TabControl TabControl1;
    }
}