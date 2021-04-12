using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.Model
{
    class LoadData
    {
        private List<Student> students; //ArrayList rustico de students porque no se que vamos a utilizar

        public void Load(string path)
        {
            var reader = new StreamReader(File.OpenRead(@path));
            string line = reader.ReadLine();
            string[] headers = line.Split(';');

            line = reader.ReadLine();

            while(line != null && line != "")
            {
                string[] info = line.Split(';');

                //Reducirle parametros a student, esta cosa está horrible
                Student toAdd = new Student(info[0], char.Parse(info[1]), int.Parse(info[2]), char.Parse(info[3]), info[4], char.Parse(info[5]),
                    int.Parse(info[6]), int.Parse(info[7]), info[8], info[9], info[10], info[11], int.Parse(info[12]), int.Parse(info[13]),
                    int.Parse(info[14]), info[15], info[16], info[17], info[18], info[19], info[20], info[21], info[22], int.Parse(info[23]),
                    int.Parse(info[24]), int.Parse(info[25]), int.Parse(info[26]), int.Parse(info[27]), int.Parse(info[28]), int.Parse(info[29]),
                    int.Parse(info[30]), int.Parse(info[31]), int.Parse(info[32]));



                students.Add(toAdd);
                line = reader.ReadLine();

            }

        }

        public List<Student> getStudents()
        {
            return students;
        }
    }
}
