using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.Model
{
    class Student
    {
        public string SchoolName { get; }
        public char Sex { get; }
        public int Age { get; }
        public char Address { get; }
        public string FamilySize { get; }
        public char ParentsStatus { get; }
        public int MotherEducation { get; }
        public int FatherEducation { get; }
        public string MotherJob { get; }
        public string FatherJob { get; }
        public string ReasonToStudy { get; }
        public string Guardian { get; }
        public int TravelTime { get; }
        public int StudyTime { get; }
        public int PreviousFailures { get; }
        public string SchoolSupport { get; }
        public string FamilySupport { get; }
        public string ExtraPaidClasses { get; }
        public string ExtraCurricularActivities { get; }
        public string NurserySchool { get; }
        public string HigherEducation { get; }
        public string InternetAccess { get; }
        public string InRomanticRelationship { get; }
        public int FamilyRelationshipQuality { get; }
        public int FreeTime { get; }
        public int GoOutFrecuency { get; }
        public int DrinksAlcoholLaboralDays { get; }
        public int DrinksAlcoholNonLaroralDays { get; }
        public int HealthStatus { get; }
        public int Absences { get; }
        public int FirstGrade { get; }
        public int SecondGrade { get; }
        public int ThirdGrade { get; }

        public Student(string schoolName, char sex, int age, char address, string familySize, char parentsStatus, int motherEducation, int fatherEducation, string motherJob, 
                        string fatherJob, string reasonToStudy, string guardian, int travelTime, int studyTime, int previousFailures, string schoolSupport, string familySupport, 
                        string extraPaidClasses, string extraCurricularActivities, string nurserySchool, string higherEducation, string internetAccess, string inRomanticRelationship, 
                        int familyRelationshipQuality, int freeTime, int goOutFrecuency, int drinksAlcoholLaboralDays, int drinksAlcoholNonLaroralDays, int healthStatus, int absences,
                        int firstGrade, int secondGrade, int thirdGrade)
        {
            this.SchoolName = schoolName;
            this.Sex = sex;
            this.Age = age;
            this.Address = address;
            this.FamilySize = familySize;
            this.ParentsStatus = parentsStatus;
            this.MotherEducation = motherEducation;
            this.FatherEducation = fatherEducation;
            this.MotherJob = motherJob;
            this.FatherJob = fatherJob;
            this.ReasonToStudy = reasonToStudy;
            this.Guardian = guardian;
            this.TravelTime = travelTime;
            this.StudyTime = studyTime;
            this.PreviousFailures = previousFailures;
            this.SchoolSupport = schoolSupport;
            this.FamilySupport = familySupport;
            this.ExtraPaidClasses = extraPaidClasses;
            this.ExtraCurricularActivities = extraCurricularActivities;
            this.NurserySchool = nurserySchool;
            this.HigherEducation = higherEducation;
            this.InternetAccess = internetAccess;
            this.InRomanticRelationship = inRomanticRelationship;
            this.FamilyRelationshipQuality = familyRelationshipQuality;
            this.FreeTime = freeTime;
            this.GoOutFrecuency = goOutFrecuency;
            this.DrinksAlcoholLaboralDays = drinksAlcoholLaboralDays;
            this.DrinksAlcoholNonLaroralDays = drinksAlcoholNonLaroralDays;
            this.HealthStatus = healthStatus;
            this.Absences = absences;
            this.FirstGrade = firstGrade;
            this.SecondGrade = secondGrade;
            this.ThirdGrade = thirdGrade;

        }

        public String GetAllData() 
        {
            //Marco lo siento no encontre una mejor forma no me eches del grupo por favor
            String str = SchoolName + "," + Sex + "," + Age + "," + Address + "," + FamilySize + "," + ParentsStatus + "," + MotherEducation 
                + "," + FatherEducation + "," + MotherJob + "," + FatherJob + "," + ReasonToStudy + "," + Guardian + "," + TravelTime
                + "," + StudyTime + "," + PreviousFailures + "," + SchoolSupport + "," + FamilySupport + "," + ExtraPaidClasses + "," + ExtraCurricularActivities
                + "," + NurserySchool + "," + HigherEducation + "," + InternetAccess + "," + InRomanticRelationship + "," + FamilyRelationshipQuality
                + "," + FreeTime + "," + GoOutFrecuency + "," + DrinksAlcoholLaboralDays + "," + DrinksAlcoholNonLaroralDays + "," + HealthStatus
                + "," + Absences + "," + FirstGrade + "," + SecondGrade + "," + ThirdGrade;
            return str;
        }

        public override string ToString()
        {
            return SchoolName + Sex + Age + Address + FamilySize + ParentsStatus + MotherEducation + FatherEducation + MotherJob + FatherJob + ReasonToStudy +
                   Guardian + TravelTime + StudyTime + PreviousFailures + SchoolSupport + FamilySupport + ExtraPaidClasses + ExtraCurricularActivities + NurserySchool + 
                   HigherEducation + InternetAccess + InRomanticRelationship +FamilyRelationshipQuality + FreeTime + GoOutFrecuency + DrinksAlcoholLaboralDays + 
                   DrinksAlcoholNonLaroralDays + HealthStatus + Absences + FirstGrade + SecondGrade + ThirdGrade;
        }
    }
}
