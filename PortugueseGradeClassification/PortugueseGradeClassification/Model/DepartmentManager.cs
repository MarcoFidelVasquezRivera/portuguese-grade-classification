using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PortugueseGradeClassification.CustomExceptions;
using PortugueseGradeClassification.DecisionTreeSpace;

namespace PortugueseGradeClassification.Model
{
    public class DepartmentManager
    {      
        private List<Student> students;
        private DataTable table;
        private DataTable tableTwo;//esta tabla es necesaria para el arbol con libreria
        private DecisionTree tree;
        private DecisionTreeLibrary treeLibrary;

        public DepartmentManager()
        {
            table = new DataTable();
            tableTwo = new DataTable();
            students = new List<Student>();
            treeLibrary = new DecisionTreeLibrary();
        }

        public Tuple<double, double, double, double> TrainTree(double percent) 
        {
            DataTable copy = new DataTable();
            DataTable copylibrary = new DataTable();
            DataTable training = new DataTable();
            DataTable traininglibrary = new DataTable();

            for (int i = 0; i < 33; i++) 
            {
                string header = Convert.ToString(table.Columns[i].ColumnName);
                if (i == 2 || i == 6 || i == 7 || (i >= 12 && i <= 14) || i >= 23)
                {
                    copylibrary.Columns.Add(header,typeof(double));
                    traininglibrary.Columns.Add(header, typeof(double));
                }
                else
                {
                    copylibrary.Columns.Add(header, typeof(string));
                    traininglibrary.Columns.Add(header, typeof(string));
                }
                copy.Columns.Add(header);
                training.Columns.Add(header);

            }

            
            foreach (DataRow dr in table.Rows) 
            {
                copy.Rows.Add(dr.ItemArray);
            }

            foreach (DataRow dr in tableTwo.Rows)
            {
                copylibrary.Rows.Add(dr.ItemArray);
            }


            Random a = new Random();
            for (int i = 0; i < table.Rows.Count*percent; i++)
            {
                int randmNum = a.Next(0,copy.Rows.Count);

                training.Rows.Add(copy.Rows[randmNum].ItemArray);
                traininglibrary.Rows.Add(copylibrary.Rows[randmNum].ItemArray);


                copy.Rows[randmNum].Delete();
                copylibrary.Rows[randmNum].Delete();
            }
            
            tree = new DecisionTree(training);
            tree.BuildTree();

            double correct = 0;

            var sw = new Stopwatch();
            sw.Start();
            foreach (DataRow dr in copy.Rows)
            {
                string classification = tree.Classify(dr);

                if (classification.Equals(dr[32]))
                {
                    correct++;
                }
            }

            sw.Stop();
            double timeManualTree = sw.ElapsedMilliseconds;
            double impPercent = correct/Convert.ToDouble(copy.Rows.Count);

            //entrenamiento del segundo arbol
            treeLibrary.TrainTree(traininglibrary);

            sw = new Stopwatch();
            sw.Start();
            double libPercent = treeLibrary.Test(copylibrary);

            sw.Stop();
            double timeLibraryTree = sw.ElapsedMilliseconds;

            Tuple<double, double, double, double> percents = new Tuple<double,double,double,double>(impPercent, libPercent, timeManualTree, timeLibraryTree);
            return percents;
        }

        public string Clasify(String[] info)
        {
            DataRow dr = table.NewRow();
            for (int i = 0; i < info.Length; i++)
            {
                dr[i] = info[i]; //carga los datos de cada columna para su respectiva fila
            }
            
            return tree.Classify(dr);
        }

        public string LibraryClassify(String[] info)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < 32; i++)
            {
                string header = Convert.ToString(table.Columns[i].ColumnName);
                if (i == 2 || i == 6 || i == 7 || (i >= 12 && i <= 14) || i >= 23)
                {
                    dt.Columns.Add(header, typeof(double));
                }
                else
                {
                    dt.Columns.Add(header, typeof(string));
                }
                
            }

            DataRow dr = dt.NewRow();
            for (int i = 0; i < info.Length; i++)
            {
                if (i == 2 || i == 6 || i == 7 || (i >= 12 && i <= 14) || i >= 23)
                {
                    dr[i] = Convert.ToDouble(info[i]); //carga los datos de cada columna para su respectiva fila
                }
                else
                {
                    dr[i] = info[i]; //carga los datos de cada columna para su respectiva fila
                }
            }
            dt.Rows.Add(dr);
            return treeLibrary.Classify(dt);
        }

        public void Load(string path)
        {
            this.table.Clear();
            this.students.Clear();

            var reader = new StreamReader(File.OpenRead(@path));
            string line = reader.ReadLine();

            //Read the headers in the CSV and create columns accordingly
            string[] headers = line.Split(';');
            CreateHeaders(headers);

            line = reader.ReadLine();

            while (line != null && line != "")
            {
                string[] info = line.Split(';', ',');

                for (int i = 0; i < info.Length; i++)
                {
                    info[i] = info[i].TrimStart('"');
                    info[i] = info[i].TrimEnd('"');
                }

                //Cuestionable cantidad de parametros pero it do be like that sometimes ¯\_(ツ)_/¯
                Student toAdd = new Student(info[0], char.Parse(info[1]), int.Parse(info[2]), char.Parse(info[3]), info[4], char.Parse(info[5]),
                    int.Parse(info[6]), int.Parse(info[7]), info[8], info[9], info[10], info[11], int.Parse(info[12]), int.Parse(info[13]),
                    int.Parse(info[14]), info[15], info[16], info[17], info[18], info[19], info[20], info[21], info[22], int.Parse(info[23]),
                    int.Parse(info[24]), int.Parse(info[25]), int.Parse(info[26]), int.Parse(info[27]), int.Parse(info[28]), int.Parse(info[29]),
                    int.Parse(info[30]), int.Parse(info[31]), int.Parse(info[32]));

                students.Add(toAdd);

                DataRow dr = table.NewRow();
                for (int i = 0; i < info.Length; i++)
                {
                    dr[i] = info[i]; //carga los datos de cada columna para su respectiva fila
                }
                table.Rows.Add(dr);

                DataRow dr2 = tableTwo.NewRow();
                for (int i = 0; i < info.Length; i++)
                {
                    if (i == 2 || i == 6 || i == 7 || (i >= 12 && i <= 14) || i >= 23)
                    {
                        dr2[i] = Convert.ToDouble(info[i]); //carga los datos de cada columna para su respectiva fila
                    }
                    else
                    {
                        dr2[i] = info[i]; //carga los datos de cada columna para su respectiva fila
                    }

                }
                tableTwo.Rows.Add(dr2);

                line = reader.ReadLine();
            }
            Experiment();
        }

        public void CreateHeaders(String[] headers)
        {
            for (int i = 0; i < headers.Length; i++)
            {
                if (i == 2 || i == 6 || i == 7 || (i >= 12 && i <= 14) || i >= 23)
                {
                    this.tableTwo.Columns.Add(headers[i], typeof(double));
                }
                else
                {
                    this.tableTwo.Columns.Add(headers[i], typeof(string));
                }
                this.table.Columns.Add(headers[i]);
            }
        }

        //ni idea de si esto funciona
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);

        public void Experiment()
        {
            StreamWriter sw = new StreamWriter("C:/Users/User/Desktop/Test.csv");
            List<double> percents = new List<double>();
            List<string> information = new List<string>();

            percents.Add(0.2);
            percents.Add(0.4);
            percents.Add(0.6);
            percents.Add(0.8);

            information.Add("Implementacion utilizada,porcentaje de entrenamiento,ram del os,tiempo usado,correctitud");
           
            long ram;
            GetPhysicallyInstalledSystemMemory(out ram);
            ram = ram / 1024 / 1024;//convierte la cantidad de ram obtenida a GB

            //revisa la cantidad de ram del sistema y dependiendo de esta pone el nivel que esta es en el experimento
            if (ram >= 8)
            {
                ram = 3;
            }
            else if (ram >= 6)
            {
                ram = 2;
            }
            else
            {
                ram = 1;
            }

            foreach (double percent in percents)
            {
                for (int i=0; i<4;i++)
                {
                    Tuple<double,double,double,double> data = this.TrainTree(percent);

                    string infoManualTree = $"2,{(percents.IndexOf(percent) + 1)},{ram},{data.Item4},{data.Item2}";
                    string infoLibraryTree = $"1,{(percents.IndexOf(percent) + 1)},{ram},{data.Item3},{data.Item1}";

                    information.Add(infoManualTree);
                    information.Add(infoLibraryTree);
                }

            }

            //escribe todos lo datos obtenidos en un archivo de texto plano
            foreach(string row in information)
            {
                sw.WriteLine(row);
            }
            sw.Close();

        }

        public void FilterByCategory(String rowName, String category)
        {
            table.Rows.Clear();
            String info = "";

            foreach (Student st in students)
            {
                switch (rowName)
                {
                    case "Mother's job":
                        info = st.MotherJob;
                        break;

                    case "Father's job":
                        info = st.FatherJob;
                        break;

                    case "Reason":
                        info = st.ReasonToStudy;
                        break;

                    case "Guardian":
                        info = st.Guardian;
                        break;

                    case "School":
                        info = st.SchoolName;
                        break;

                    case "Sex":
                        info = Convert.ToString(st.Sex);
                        break;

                    case "Address":
                        info = Convert.ToString(st.Address);
                        break;

                    case "Family Size":
                        info = st.FamilySize;
                        break;

                    case "Parents status":
                        info = Convert.ToString(st.ParentsStatus);
                        break;

                    case "School support":
                        info = st.SchoolSupport;
                        break;

                    case "Family support":
                        info = st.FamilySupport;
                        break;

                    case "Extra paid classes":
                        info = st.ExtraPaidClasses;
                        break;

                    case "Extra activities":
                        info = st.ExtraCurricularActivities;
                        break;

                    case "Nursery":
                        info = st.NurserySchool;
                        break;

                    case "Higher education":
                        info = st.HigherEducation;
                        break;

                    case "Internet access":
                        info = st.InternetAccess;
                        break;

                    case "Romantic relationship":
                        info = st.InRomanticRelationship;
                        break;
                }

                info = info.ToUpper();
                if (info.Equals(category.ToUpper()))
                {
                    DataRow dr = table.NewRow();
                    String[] parameters = st.ToString().Split(',');

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        dr[i] = parameters[i];
                    }
                    table.Rows.Add(dr);
                }
            }
        }

        public void FilterByInterval(string rowName, int lowerLimit, int higherLimit)
        {
            if (lowerLimit > higherLimit)
            {
                throw new IncorrectLimitsException("The lower limit is greater than the higher limit.");
            }
            table.Rows.Clear();
            int info = 0;
            foreach (Student student in students)
            {
                switch (rowName.ToUpper())
                {
                    case "AGE":
                        info = student.Age;
                        break;

                    case "MOTHER'S EDUCATION":
                        info = student.MotherEducation;
                        break;

                    case "FATHER'S EDUCATION":
                        info = student.FatherEducation;
                        break;

                    case "TRAVEL TIME":
                        info = student.TravelTime;
                        break;

                    case "STUDY TIME":
                        info = student.StudyTime;
                        break;

                    case "FAILURES":
                        info = student.PreviousFailures;
                        break;

                    case "FAMILY RELATION":
                        info = student.FamilyRelationshipQuality;
                        break;

                    case "FREE TIME":
                        info = student.FreeTime;
                        break;

                    case "GO OUT":
                        info = student.GoOutFrecuency;
                        break;

                    case "WEEKDAY ALCOHOL":
                        info = student.DrinksAlcoholLaboralDays;
                        break;

                    case "WEEKEND ALCOHOL":
                        info = student.DrinksAlcoholNonLaroralDays;
                        break;

                    case "HEALTH":
                        info = student.HealthStatus;
                        break;

                    case "ABSENCES":
                        info = student.Absences;
                        break;

                    case "GRADE 1":
                        info = student.FirstGrade;
                        break;

                    case "GRADE 2":
                        info = student.SecondGrade;
                        break;

                    case "GRADE 3":
                        info = student.ThirdGrade;
                        break;
                }

                if (info <= higherLimit && info >= lowerLimit)
                {
                    DataRow dr = table.NewRow();
                    String[] parameters = student.ToString().Split(',');

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        dr[i] = parameters[i];
                    }
                    table.Rows.Add(dr);
                }
            }
        }

        public Dictionary<string, int> GetStudentsInfo(int typeOfInfo)
        {
            Dictionary<string, int> studentsInfo = new Dictionary<string, int>();

            string info = "";
            foreach (Student student in students)
            {
                switch (typeOfInfo)
                {
                    case 1:
                        info = student.SchoolName;
                        break;

                    case 2:
                        info = student.FreeTime.ToString();
                        break;

                    case 3:
                        info = student.StudyTime.ToString();
                        break;

                    case 4:
                        info = student.Address.ToString();
                        break;

                    case 5:
                        info = student.InternetAccess;
                        break;
                }

                if (studentsInfo.ContainsKey(info))
                {
                    studentsInfo[info]++;
                }
                else
                {
                    studentsInfo.Add(info, 1);
                }
            }

            return studentsInfo;
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public DataTable GetTable()
        {
            return this.table;
        }

        public Node getTreeRootNode()
        {
            if (tree != null)
            {
                Node nodeToReturn = tree.RootNode;
                return nodeToReturn;
            }
            else { return null; }   
        }
    }
}