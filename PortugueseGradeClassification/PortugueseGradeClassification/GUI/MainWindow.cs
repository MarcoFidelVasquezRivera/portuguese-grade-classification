using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortugueseGradeClassification.Model;

namespace PortugueseGradeClassification
{
    public partial class MainWindow : Form
    {
        enum Type { NUMERIC, CATEGORIC, CHAIN}
        private Dictionary<string, Type> columnTypes;

        //Seria bueno tener la hash de estudiantes como atributo
        public MainWindow()
        {
            //Le falta la clase controladora
            InitializeComponent();

            //Inicializacion de la tabla hash con los tipos
            columnTypes = new Dictionary<string, Type>()
            {
                { "School",Type.CATEGORIC },
                { "Sex",Type.CATEGORIC },
                { "Age",Type.NUMERIC },
                { "Address",Type.CATEGORIC },
                { "Family size",Type.CATEGORIC },
                { "Parents status",Type.CATEGORIC },
                { "Mother's education",Type.NUMERIC },
                { "Father's education",Type.NUMERIC },
                { "Mother's job",Type.CHAIN },
                { "Father's job",Type.CHAIN },
                { "Reason",Type.CHAIN },
                { "Guardian",Type.CHAIN },
                { "Travel time",Type.NUMERIC },
                { "Study time",Type.NUMERIC },
                { "Failures",Type.NUMERIC },
                { "School support",Type.CATEGORIC },
                { "Family support",Type.CATEGORIC },
                { "Extra paid classes",Type.CATEGORIC },
                { "Extra activities",Type.CATEGORIC },
                { "Nursery",Type.CATEGORIC },
                { "Higher education",Type.CATEGORIC },
                { "Internet access",Type.CATEGORIC },
                { "Romantic relationship",Type.CATEGORIC },
                { "Family relation",Type.NUMERIC },
                { "Free time",Type.NUMERIC },
                { "Go out",Type.NUMERIC },
                { "Weekday alcohol",Type.NUMERIC },
                { "Weekend alcohol",Type.NUMERIC },
                { "Health",Type.NUMERIC },
                { "Absences",Type.NUMERIC },
                { "Grade 1",Type.NUMERIC },
                { "Grade 2",Type.NUMERIC },
                { "Grade 3",Type.NUMERIC },
            };

            Hashtable students = new Hashtable();

            foreach (DictionaryEntry element in students)
            {
                Student stu = (Student)element.Value;
                int n = PortuTable.Rows.Add();
                PortuTable.Rows[n].Cells[0].Value = stu.SchoolName;
                PortuTable.Rows[n].Cells[1].Value = stu.Sex;
                PortuTable.Rows[n].Cells[2].Value = stu.Age;
                PortuTable.Rows[n].Cells[3].Value = stu.Address;
                PortuTable.Rows[n].Cells[4].Value = stu.FamilySize;
                PortuTable.Rows[n].Cells[5].Value = stu.ParentsStatus;
                PortuTable.Rows[n].Cells[6].Value = stu.MotherEducation;
                PortuTable.Rows[n].Cells[7].Value = stu.FatherEducation;
                PortuTable.Rows[n].Cells[8].Value = stu.MotherJob;
                PortuTable.Rows[n].Cells[9].Value = stu.FatherJob;
                PortuTable.Rows[n].Cells[10].Value = stu.ReasonToStudy;
                PortuTable.Rows[n].Cells[11].Value = stu.Guardian;
                PortuTable.Rows[n].Cells[12].Value = stu.TravelTime;
                PortuTable.Rows[n].Cells[13].Value = stu.StudyTime;
                PortuTable.Rows[n].Cells[14].Value = stu.PreviousFailures;
                PortuTable.Rows[n].Cells[15].Value = stu.SchoolSupport;
                PortuTable.Rows[n].Cells[16].Value = stu.FamilySupport;
                PortuTable.Rows[n].Cells[17].Value = stu.ExtraPaidClasses;
                PortuTable.Rows[n].Cells[18].Value = stu.ExtraCurricularActivities;
                PortuTable.Rows[n].Cells[19].Value = stu.NurserySchool;
                PortuTable.Rows[n].Cells[20].Value = stu.HigherEducation;
                PortuTable.Rows[n].Cells[21].Value = stu.InternetAccess;
                PortuTable.Rows[n].Cells[22].Value = stu.InRomanticRelationship;
                PortuTable.Rows[n].Cells[23].Value = stu.FamilyRelationshipQuality;
                PortuTable.Rows[n].Cells[24].Value = stu.FreeTime;
                PortuTable.Rows[n].Cells[25].Value = stu.GoOutFrecuency;
                PortuTable.Rows[n].Cells[26].Value = stu.DrinksAlcoholLaboralDays;
                PortuTable.Rows[n].Cells[27].Value = stu.DrinksAlcoholNonLaroralDays;
                PortuTable.Rows[n].Cells[28].Value = stu.HealthStatus;
                PortuTable.Rows[n].Cells[29].Value = stu.Absences;
                PortuTable.Rows[n].Cells[30].Value = stu.FirstGrade;
                PortuTable.Rows[n].Cells[31].Value = stu.SecondGrade;
                PortuTable.Rows[n].Cells[32].Value = stu.ThirdGrade;            
            }

                
        }

        private void PortuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            String currentField = PortuComboBox.SelectedItem.ToString();
            switch (currentField)
            {
                case "School name":
                    // Torta
                    PortuGraph.Titles.Clear();
                    PortuGraph.Series["Series1"].Points.Clear();
                    PortuGraph.Titles.Add("School name");
                    PortuGraph.Series["Series1"].IsValueShownAsLabel = true;
                    PortuGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    //Tomamos la hash de estudiantes
                    Hashtable students = new Hashtable();
                    int msSchool = 0;
                    int gpSchool = 0;   
                    //conteo de estudiantes en cada escuela
                    foreach (DictionaryEntry element in students)
                    {
                        Student stu = (Student)element.Value;
                        if (stu.SchoolName.Equals("MS"))
                        {
                            msSchool++;
                        }
                        else
                        {
                            gpSchool++;
                        }
                    }
                    //Agregamos los datos a la torta
                    PortuGraph.Series["Series1"].Points.AddXY("Mousinho da Silveira School", msSchool);
                    PortuGraph.Series["Series1"].Points.AddXY("Gabriel Pereira School", gpSchool);
                    break;
                case "Free time":
                    // Barra
                    PortuGraph.Titles.Clear();
                    PortuGraph.Series["Series1"].Points.Clear();
                    PortuGraph.Titles.Add("Free time");
                    PortuGraph.Series["Series1"].IsValueShownAsLabel = true;
                    PortuGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    //Tomamos la hash de estudiantes
                    Hashtable students2 = new Hashtable();
                    int time1 = 0;
                    int time2 = 0;
                    int time3 = 0;
                    int time4 = 0;
                    int time5 = 0;

                    //conteo de estudiantes en cada escuela
                    foreach (DictionaryEntry element in students2)
                    {
                        Student stu = (Student)element.Value;
                        if (stu.FreeTime == 1)
                        {
                            time1++;
                        }
                        else if(stu.FreeTime == 2)
                        {
                            time2++;

                        }else if(stu.FreeTime == 3)
                        {
                            time3++;
                        }else if(stu.FreeTime == 4)
                        {
                            time4++;
                        }
                        else
                        {
                            time5++;
                        }
                    }
                    //Agregamos los datos a la torta
                    PortuGraph.Series["Series1"].Points.AddXY("Almost none",time1 );
                    PortuGraph.Series["Series1"].Points.AddXY("Few", time2);
                    PortuGraph.Series["Series1"].Points.AddXY("Moderate", time3);
                    PortuGraph.Series["Series1"].Points.AddXY("Many", time4);
                    PortuGraph.Series["Series1"].Points.AddXY("A lot", time5);
                    break;
                case "Study time":
                    //Barra
                    PortuGraph.Titles.Clear();
                    PortuGraph.Series["Series1"].Points.Clear();
                    PortuGraph.Titles.Add("Study time");
                    PortuGraph.Series["Series1"].IsValueShownAsLabel = true;
                    PortuGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    //Tomamos la hash de estudiantes
                    Hashtable students3 = new Hashtable();
                    int study1 = 0;
                    int study2 = 0;
                    int study3 = 0;
                    int study4 = 0;
                    int study5 = 0;

                    //conteo de estudiantes en cada escuela
                    foreach (DictionaryEntry element in students3)
                    {
                        Student stu = (Student)element.Value;
                        if (stu.StudyTime == 1)
                        {
                            study1++;
                        }
                        else if (stu.StudyTime == 2)
                        {
                            study2++;

                        }
                        else if (stu.StudyTime == 3)
                        {
                            study3++;
                        }
                        else if (stu.StudyTime == 4)
                        {
                            study4++;
                        }
                        else
                        {
                            study5++;
                        }
                    }
                    //Agregamos los datos a la torta
                    PortuGraph.Series["Series1"].Points.AddXY("Almost none", study1);
                    PortuGraph.Series["Series1"].Points.AddXY("Few", study2);
                    PortuGraph.Series["Series1"].Points.AddXY("Moderate", study3);
                    PortuGraph.Series["Series1"].Points.AddXY("Many", study4);
                    PortuGraph.Series["Series1"].Points.AddXY("A lot", study5);
                    break;
                case "Address":
                    //Torta
                    PortuGraph.Titles.Clear();
                    PortuGraph.Series["Series1"].Points.Clear();
                    PortuGraph.Titles.Add("Address");
                    PortuGraph.Series["Series1"].IsValueShownAsLabel = true;
                    PortuGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    //Tomamos la hash de estudiantes
                    Hashtable students4 = new Hashtable();
                    int rural = 0;
                    int urban = 0;
                    //conteo de estudiantes en cada escuela
                    foreach (DictionaryEntry element in students4)
                    {
                        Student stu = (Student)element.Value;
                        if (stu.Address.Equals("U"))
                        {
                            urban++;
                        }
                        else
                        {
                            rural++;
                        }
                    }
                    //Agregamos los datos a la torta
                    PortuGraph.Series["Series1"].Points.AddXY("Urban", urban);
                    PortuGraph.Series["Series1"].Points.AddXY("Rural", rural);
                    break;
                case "Internet access":
                    //Torta
                    PortuGraph.Titles.Clear();
                    PortuGraph.Series["Series1"].Points.Clear();
                    PortuGraph.Titles.Add("Internet access");
                    PortuGraph.Series["Series1"].IsValueShownAsLabel = true;
                    PortuGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    //Tomamos la hash de estudiantes
                    Hashtable students5 = new Hashtable();
                    int yes = 0;
                    int no = 0;
                    //conteo de estudiantes en cada escuela
                    foreach (DictionaryEntry element in students5)
                    {
                        Student stu = (Student)element.Value;
                        if (stu.InternetAccess.Equals("yes"))
                        {
                            yes++;
                        }
                        else
                        {
                            no++;
                        }
                    }
                    //Agregamos los datos a la torta
                    PortuGraph.Series["Series1"].Points.AddXY("Yes", yes);
                    PortuGraph.Series["Series1"].Points.AddXY("No", no);
                    break;
                default:

                    break;
            }
           
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            String field = PortuComboBox.Text;
            filter(field);
        }

        private void filter(String field)
        {
            if (!field.Equals(""))
            {
                //Falta implementar el filtro de datos
            }
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String field = FilterComboBox.Text;
            Type type = columnTypes[field]; 

            switch (type)
            {
                case Type.CATEGORIC:
                    BiComboBox.Visible = true;
                    FilterText1.Visible = false;
                    FilterText2.Visible = false;
                    BiComboBox.Text = "Pick a value...";
                    break;

                case Type.NUMERIC:
                    BiComboBox.Visible = false;
                    FilterText1.Visible = true;
                    FilterText2.Visible = true;
                    FilterText1.Text = "Min. Value...";
                    FilterText2.Text = "Max. Value...";
                    break;

                case Type.CHAIN:
                    BiComboBox.Visible = false;
                    FilterText1.Visible = true;
                    FilterText2.Visible = false;
                    FilterText1.Text = "Keyword...";
                    break;
            }
        }
    }
}
