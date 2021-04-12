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

        public MainWindow()
        {
            //Le falta la clase controladora
            InitializeComponent();

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
    }
}
