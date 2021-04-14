using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void FilterByChain(String columnName, String chain) 
        {
            table.Rows.Clear();

            List<Student> passedFilter = new List<Student>();

            switch (columnName)
            {
                case "Mother's job":
                    foreach (Student st in students)
                    { 
                        if(st.MotherJob.ToUpper().Equals(chain.ToUpper()))
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
                    break;

                case "Father's job":
                    foreach (Student st in students)
                    {
                        if (st.FatherJob.ToUpper().Equals(chain.ToUpper()))
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
                    break;

                case "Reason":
                    foreach (Student st in students)
                    {
                        if (st.ReasonToStudy.ToUpper().Equals(chain.ToUpper()))
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
                    break;

                case "Guardian":
                    foreach (Student st in students)
                    {
                        if (st.Guardian.ToUpper().Equals(chain.ToUpper()))
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
                    break;
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
