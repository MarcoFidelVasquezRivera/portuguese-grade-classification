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
using PortugueseGradeClassification.CustomExceptions;
using PortugueseGradeClassification.Model;

namespace PortugueseGradeClassification
{
    public partial class MainWindow : Form
    {
        private enum Type { NUMERIC, CATEGORIC, CHAIN}
        private Dictionary<string, Type> columnTypes;
        private DepartmentManager manager;

        public MainWindow(DepartmentManager manager)
        {
            
            InitializeComponent();
            this.manager = manager;
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
                { "Mother's job",Type.CATEGORIC },
                { "Father's job",Type.CATEGORIC },
                { "Reason",Type.CATEGORIC },
                { "Guardian",Type.CATEGORIC },
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

            PortuTable.DataSource = manager.GetTable();
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
            String field = FilterComboBox.Text;
            filter(field);
        }

        private void filter(String field)
        {
            if (!field.Equals(""))
            {
                try
                {
                    switch (field)
                    {
                        case "School":
                            if (BiComboBox.Text.Equals("Mousinho da Silveira School"))
                            {
                                manager.FilterByCategory("School", "MS");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("Gabriel Pereira School"))
                            {

                                manager.FilterByCategory("School", "GB");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Sex":
                            if (BiComboBox.Text.Equals("Male"))
                            {
                                manager.FilterByCategory("Sex", "M");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("Female"))
                            {
                                manager.FilterByCategory("Sex", "F");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Age":
                            int age1 = int.Parse(FilterText1.Text);
                            int age2 = int.Parse(FilterText2.Text);

                            manager.FilterByInterval("AGE", age1, age2);
                            PortuTable.DataSource = manager.GetTable();

                            break;
                        case "Address":
                            if (BiComboBox.Text.Equals("Rural"))
                            {
                                manager.FilterByCategory("Address", "R");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("Urban"))
                            {
                                manager.FilterByCategory("Address", "U");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Family size":
                            if (BiComboBox.Text.Equals("Less or equal to 3"))
                            {
                                manager.FilterByCategory("Family Size", "LE3");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("Greater than 3"))
                            {
                                manager.FilterByCategory("Family Size", "GT3");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Parents status":
                            if (BiComboBox.Text.Equals("Living together"))
                            {
                                manager.FilterByCategory("Parents status", "T");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("Apart"))
                            {
                                manager.FilterByCategory("Parents status", "A");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Mother's education":
                            int m1 = int.Parse(FilterText1.Text);
                            int m2 = int.Parse(FilterText2.Text);

                            manager.FilterByInterval("MOTHER'S EDUCATION", m1, m2);
                            PortuTable.DataSource = manager.GetTable();

                            break;
                        case "Father's education":
                            int f1 = int.Parse(FilterText1.Text);
                            int f2 = int.Parse(FilterText2.Text);

                            manager.FilterByInterval("FATHER'S EDUCATION", f1, f2);
                            PortuTable.DataSource = manager.GetTable();

                            break;
                        case "Mother's job":
                            if (BiComboBox.Text.Equals("teacher"))
                            {
                                manager.FilterByCategory("Mother's job", "teacher");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("health"))
                            {
                                manager.FilterByCategory("Mother's job", "health");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("services"))
                            {
                                manager.FilterByCategory("Mother's job", "services");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("at_home"))
                            {
                                manager.FilterByCategory("Mother's job", "at_home");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("other"))
                            {
                                manager.FilterByCategory("Mother's job", "other");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;

                        case "Father's job":

                            if (BiComboBox.Text.Equals("teacher"))
                            {
                                manager.FilterByCategory("Father's job", "teacher");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("health"))
                            {
                                manager.FilterByCategory("Father's job", "health");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("services"))
                            {
                                manager.FilterByCategory("Father's job", "services");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("at_home"))
                            {
                                manager.FilterByCategory("Father's job", "at_home");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("other"))
                            {
                                manager.FilterByCategory("Father's job", "other");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Reason":
                            
                            if (BiComboBox.Text.Equals("home"))
                            {
                                manager.FilterByCategory("Reason", "home");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("reputation"))
                            {
                                manager.FilterByCategory("Reason", "reputation");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("course"))
                            {
                                manager.FilterByCategory("Reason", "course");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("other"))
                            {
                                manager.FilterByCategory("Reason", "other");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }

                            break;
                        case "Guardian":

                            if (BiComboBox.Text.Equals("mother"))
                            {
                                manager.FilterByCategory("Guardian", "mother");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("father"))
                            {
                                manager.FilterByCategory("Guardian", "father");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else if (BiComboBox.Text.Equals("other"))
                            {
                                manager.FilterByCategory("Guardian", "other");
                                PortuTable.DataSource = manager.GetTable();
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            String guardian = FilterText1.Text;

                            break;
                        case "Travel time":
                            int t1 = int.Parse(FilterText1.Text);
                            int t2 = int.Parse(FilterText2.Text);

                            break;
                        case "Study time":
                            int s1 = int.Parse(FilterText1.Text);
                            int s2 = int.Parse(FilterText2.Text);

                            break;
                        case "Failures":
                            int fai1 = int.Parse(FilterText1.Text);
                            int fai2 = int.Parse(FilterText2.Text);

                            break;
                        case "School support":
                            if (BiComboBox.Text.Equals("Yes"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else if (BiComboBox.Text.Equals("No"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Family support":
                            if (BiComboBox.Text.Equals("Yes"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else if (BiComboBox.Text.Equals("No"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Extra paid classes":
                            if (BiComboBox.Text.Equals("Yes"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else if (BiComboBox.Text.Equals("No"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Extra activities":
                            if (BiComboBox.Text.Equals("Yes"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else if (BiComboBox.Text.Equals("No"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Nursery":
                            if (BiComboBox.Text.Equals("Yes"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else if (BiComboBox.Text.Equals("No"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Higher education":
                            if (BiComboBox.Text.Equals("Yes"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else if (BiComboBox.Text.Equals("No"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Internet access":
                            if (BiComboBox.Text.Equals("Yes"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else if (BiComboBox.Text.Equals("No"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Romantic relationship":
                            if (BiComboBox.Text.Equals("Yes"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else if (BiComboBox.Text.Equals("No"))
                            {
                                //Pedir datos a model para cargar la tabla
                            }
                            else
                            {
                                BiComboBox.Text = "Please select a value";
                            }
                            break;
                        case "Family relation":
                            int fRel1 = int.Parse(FilterText1.Text);
                            int fRel2 = int.Parse(FilterText2.Text);

                            break;
                        case "Free time":
                            int ft1 = int.Parse(FilterText1.Text);
                            int ft2 = int.Parse(FilterText2.Text);

                            break;
                        case "Go out":
                            int g1 = int.Parse(FilterText1.Text);
                            int g2 = int.Parse(FilterText2.Text);

                            break;
                        case "Weekday alcohol":
                            int wd1 = int.Parse(FilterText1.Text);
                            int wd2 = int.Parse(FilterText2.Text);

                            break;
                        case "Weekend alcohol":
                            int we1 = int.Parse(FilterText1.Text);
                            int we2 = int.Parse(FilterText2.Text);

                            break;
                        case "Health":
                            int h1 = int.Parse(FilterText1.Text);
                            int h2 = int.Parse(FilterText2.Text);

                            break;
                        case "Absences":
                            int abs1 = int.Parse(FilterText1.Text);
                            int abs2 = int.Parse(FilterText2.Text);

                            break;
                        case "Grade 1":
                            int grade1Min = int.Parse(FilterText1.Text);
                            int grade1Max = int.Parse(FilterText2.Text);

                            break;
                        case "Grade 2":
                            int grade2Min = int.Parse(FilterText1.Text);
                            int grade2Max = int.Parse(FilterText2.Text);

                            break;
                        case "Grade 3":
                            int grade3Min = int.Parse(FilterText1.Text);
                            int grade3Max = int.Parse(FilterText2.Text);

                            break;
                        default:

                            break;
                    }
                } catch (IncorrectLimitsException e)
                {
                    MessageBox.Show(e.Message, "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                    switch (field)
                    {
                        case "School":
                            BiComboBox.Items.Clear();
                            String[] schools = new string[] { "Mousinho da Silveira School", "Gabriel Pereira School" };
                            BiComboBox.Items.AddRange(schools);
                            break;
                        case "Sex":
                            BiComboBox.Items.Clear();
                            String[] sex = new string[] { "Female", "Male" };
                            BiComboBox.Items.AddRange(sex);
                            break;
                        case "Address":
                            BiComboBox.Items.Clear();
                            String[] address = new string[] { "Rural", "Urban" };
                            BiComboBox.Items.AddRange(address);
                            break;
                        case "Family size":
                            BiComboBox.Items.Clear();
                            String[] fsize = new string[] { "Less or equal to 3", "Greater than 3" };
                            BiComboBox.Items.AddRange(fsize);
                            break;
                        case "Parents status":
                            BiComboBox.Items.Clear();
                            String[] pstatus = new string[] { "Living together", "Apart" };
                            BiComboBox.Items.AddRange(pstatus);
                            break;
                        case "Mother's job":
                            BiComboBox.Items.Clear();
                            String[] mjob = new string[] { "teacher", "health", "services","at_home","other" };
                            BiComboBox.Items.AddRange(mjob);
                            break;
                        case "Father's job":
                            BiComboBox.Items.Clear();
                            String[] fjob = new string[] { "teacher", "health", "services", "at_home", "other" };
                            BiComboBox.Items.AddRange(fjob);
                            break;
                        case "School support":
                            BiComboBox.Items.Clear();
                            String[] scsupp = new string[] { "Yes", "No" };
                            BiComboBox.Items.AddRange(scsupp);
                            break;
                        case "Reason":
                            BiComboBox.Items.Clear();
                            String[] reason = new string[] { "home", "reputation","course","other" };
                            BiComboBox.Items.AddRange(reason);
                            break;
                        case "Guardian":
                            BiComboBox.Items.Clear();
                            String[] guardian = new string[] { "mother", "father", "other" };
                            BiComboBox.Items.AddRange(guardian);
                            break;
                        case "Family support":
                            BiComboBox.Items.Clear();
                            String[] fsupp = new string[] { "Yes", "No" };
                            BiComboBox.Items.AddRange(fsupp);
                            break;
                        case "Extra paid classes":
                            BiComboBox.Items.Clear();
                            String[] extraPaid = new string[] { "Yes", "No" };
                            BiComboBox.Items.AddRange(extraPaid);
                            break;
                        case "Extra activities":
                            BiComboBox.Items.Clear();
                            String[] extraAct = new string[] { "Yes", "No" };
                            BiComboBox.Items.AddRange(extraAct);
                            break;
                        case "Nursery":
                            BiComboBox.Items.Clear();
                            String[] nursery = new string[] { "Yes", "No" };
                            BiComboBox.Items.AddRange(nursery);
                            break;
                        case "Higher education":
                            BiComboBox.Items.Clear();
                            String[] higher = new string[] { "Yes", "No" };
                            BiComboBox.Items.AddRange(higher);
                            break;
                        case "Internet access":
                            BiComboBox.Items.Clear();
                            String[] internet = new string[] { "Yes", "No" };
                            BiComboBox.Items.AddRange(internet);
                            break;
                        case "Romantic relationship":
                            BiComboBox.Items.Clear();
                            String[] roman = new string[] { "Yes", "No" };
                            BiComboBox.Items.AddRange(roman);
                            break;
                        default:

                            break;

                    }
                    break;

                case Type.NUMERIC:
                    BiComboBox.Visible = false;
                    FilterText1.Visible = true;
                    FilterText2.Visible = true;
                    FilterText1.Text = "Min. Value...";
                    FilterText2.Text = "Max. Value...";
                    break;
            }
        }

        private void loadStudentToTable(Student stu)
        {
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
}
