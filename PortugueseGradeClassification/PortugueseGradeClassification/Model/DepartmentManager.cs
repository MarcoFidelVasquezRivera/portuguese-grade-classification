using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortugueseGradeClassification.CustomExceptions;

namespace PortugueseGradeClassification.Model
{
    class DepartmentManager
    {
        private DataTable table;
        private List<Student> students; 

        public DepartmentManager()
        {
            table = new DataTable();
            students = new List<Student>();

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
            while(line != null && line != "")
            {
                string[] info = line.Split(';');

                //Cuestionable cantidad de parametros pero it do be like that sometimes ¯\_(ツ)_/¯
                Student toAdd = new Student(info[0], char.Parse(info[1]), int.Parse(info[2]), char.Parse(info[3]), info[4], char.Parse(info[5]),
                    int.Parse(info[6]), int.Parse(info[7]), info[8], info[9], info[10], info[11], int.Parse(info[12]), int.Parse(info[13]),
                    int.Parse(info[14]), info[15], info[16], info[17], info[18], info[19], info[20], info[21], info[22], int.Parse(info[23]),
                    int.Parse(info[24]), int.Parse(info[25]), int.Parse(info[26]), int.Parse(info[27]), int.Parse(info[28]), int.Parse(info[29]),
                    int.Parse(info[30]), int.Parse(info[31]), int.Parse(info[32]));

                DataRow dr = table.NewRow();
                for (int i=0; i<info.Length;i++)
                {
                    dr[i] = info[i]; //carga los datos de cada columna para su respectiva fila
                }
                table.Rows.Add();

                students.Add(toAdd);
                line = reader.ReadLine();

            }

        }


        public void CreateHeaders(String[] headers)
        {
            for(int i = 0; i<headers.Length; i++)
            {
                this.table.Columns.Add(headers[i]);
            }

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
            if (lowerLimit>higherLimit)
            {
                throw new IncorrectLimitsException("the lower limit is greater than the higher limit");
            }
            table.Rows.Clear();
            int info = 0;
            foreach(Student student in students){

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

                if (info<higherLimit && info>lowerLimit)
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

        public Dictionary<string,int> GetStudentsInfo(int typeOfInfo)
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
                        info = student.TravelTime.ToString();
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
    }
}
