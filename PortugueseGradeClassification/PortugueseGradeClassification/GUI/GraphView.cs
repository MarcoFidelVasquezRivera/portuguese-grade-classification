using PortugueseGradeClassification.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PortugueseGradeClassification.GUI
{
    public partial class GraphView : UserControl
    {
        private DepartmentManager manager { get; set; }

        public GraphView()
        {
            InitializeComponent();
        }

        public void setManager(DepartmentManager manager)
        {
            this.manager = manager;
        }

        private void PortuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PortuComboBox.SelectedItem != null)
            {
                String currentField = PortuComboBox.SelectedItem.ToString();

                switch (currentField)
                {
                    case "School name":
                        // Torta
                        PortuGraph.Titles.Clear();
                        PortuGraph.Series.Clear();
                        PortuGraph.Series.Add("Series1");
                        PortuGraph.Series["Series1"].Points.Clear();
                        PortuGraph.Titles.Add("School name");
                        PortuGraph.Series["Series1"].IsValueShownAsLabel = true;
                        PortuGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                        Dictionary<String, int> students = manager.GetStudentsInfo(1);
                        foreach (KeyValuePair<String, int> element in students)
                        {
                            PortuGraph.Series["Series1"].Points.AddXY(element.Key, element.Value);
                        }

                        break;

                    case "Free time":
                        // Barra
                        PortuGraph.Titles.Clear();
                        PortuGraph.Series.Clear();
                        var verylow = PortuGraph.Series.Add("Very Low");
                        var low = PortuGraph.Series.Add("Low");
                        var regular = PortuGraph.Series.Add("Regular");
                        var high = PortuGraph.Series.Add("High");
                        var veryhigh = PortuGraph.Series.Add("Very High");
                        PortuGraph.Titles.Add("Free time");
                        //PortuGraph.Series["Series1"].IsValueShownAsLabel = true;
                        PortuGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        //Tomamos la hash de estudiantes
                        Dictionary<String, int> students2 = manager.GetStudentsInfo(2);

                        foreach (KeyValuePair<String, int> element in students2)
                        {
                            //PortuGraph.Series["Series1"].Points.AddXY(Convert.ToInt32(element.Key), element.Value);
                            if (element.Key.Equals("1"))
                            {
                                verylow.Points.AddXY(Convert.ToInt32(element.Key), element.Value);
                            }
                            if (element.Key.Equals("2"))
                            {
                                low.Points.AddXY(Convert.ToInt32(element.Key), element.Value);
                            }
                            if (element.Key.Equals("3"))
                            {
                                regular.Points.AddXY(Convert.ToInt32(element.Key), element.Value);
                            }
                            if (element.Key.Equals("4"))
                            {
                                high.Points.AddXY(Convert.ToInt32(element.Key), element.Value);
                            }
                            if (element.Key.Equals("5"))
                            {
                                veryhigh.Points.AddXY(Convert.ToInt32(element.Key), element.Value);
                            }
                        }

                        //PortuGraph.Series["Series1"].Sort(PointSortOrder.Ascending, "X");
                        PortuGraph.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                        PortuGraph.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                        break;

                    case "Study time":
                        // Barra
                        PortuGraph.Titles.Clear();
                        PortuGraph.Series.Clear();
                        var one = PortuGraph.Series.Add(">2 Hours");
                        var two = PortuGraph.Series.Add("2 to 5 Hours");
                        var three = PortuGraph.Series.Add("5 to 10 Hours");
                        var four = PortuGraph.Series.Add(">10 Hours");
                        PortuGraph.Titles.Add("Study time");
                        //PortuGraph.Series["Series1"].IsValueShownAsLabel = true;
                        PortuGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        //Tomamos la hash de estudiantes
                        Dictionary<String, int> students3 = manager.GetStudentsInfo(3);

                        foreach (KeyValuePair<String, int> element in students3)
                        {
                            //PortuGraph.Series["Series1"].Points.AddXY(Convert.ToInt32(element.Key), element.Value);
                            if (element.Key.Equals("1"))
                            {
                                one.Points.AddXY(Convert.ToInt32(element.Key), element.Value);
                            }
                            if (element.Key.Equals("2"))
                            {
                                two.Points.AddXY(Convert.ToInt32(element.Key), element.Value);
                            }
                            if (element.Key.Equals("3"))
                            {
                                three.Points.AddXY(Convert.ToInt32(element.Key), element.Value);
                            }
                            if (element.Key.Equals("4"))
                            {
                                four.Points.AddXY(Convert.ToInt32(element.Key), element.Value);
                            }
                        }

                        //PortuGraph.Series["Series1"].Sort(PointSortOrder.Ascending, "X");
                        PortuGraph.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                        PortuGraph.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;

                        break;

                    case "Address":
                        //Torta
                        PortuGraph.Titles.Clear();
                        PortuGraph.Series.Clear();
                        PortuGraph.Series.Add("Series1");
                        PortuGraph.Series["Series1"].Points.Clear();
                        PortuGraph.Titles.Add("Address");
                        PortuGraph.Series["Series1"].IsValueShownAsLabel = true;
                        PortuGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        //Tomamos la hash de estudiantes
                        Dictionary<String, int> students4 = manager.GetStudentsInfo(4);
                        foreach (KeyValuePair<String, int> element in students4)
                        {
                            PortuGraph.Series["Series1"].Points.AddXY(element.Key, element.Value);
                        }

                        break;

                    case "Internet access":
                        //Torta
                        PortuGraph.Titles.Clear();
                        PortuGraph.Series.Clear();
                        PortuGraph.Series.Add("Series1");
                        PortuGraph.Series["Series1"].Points.Clear();
                        PortuGraph.Titles.Add("Internet Access");
                        PortuGraph.Series["Series1"].IsValueShownAsLabel = true;
                        PortuGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        //Tomamos la hash de estudiantes
                        Dictionary<String, int> students5 = manager.GetStudentsInfo(5);
                        foreach (KeyValuePair<String, int> element in students5)
                        {
                            PortuGraph.Series["Series1"].Points.AddXY(element.Key, element.Value);
                        }

                        break;

                    default:

                        break;
                }
            }
        }
    }
}