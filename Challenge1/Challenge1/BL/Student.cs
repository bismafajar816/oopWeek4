using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class Student
    {
        public string name;
        public int age;
        public int fscMarks;
        public int ecatMarks;
        public float percentage;     
        public List<DegreeProgram> preferences;
        public List<Subject> regSubject;
        public DegreeProgram regDegree;

        public Student (string name,int age, int fscMarks, int ecatMarks, List<DegreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preferences = preferences;
            regSubject = new List<Subject>();
        }
        public void PreferencesAddToList(List<Student> TotalStudents , Student p)
        {
            TotalStudents.Add(p);
        }
        public float CalculateMerit()
        {
            this.percentage = (fscMarks * 60) / 1100.0F + (ecatMarks * 40) / 400;
            return percentage;
        }
        public List<string> GetAllPreferences()
        {
            return choices;
        }

    }
}
