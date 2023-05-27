using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.BL
{
    class Student
    {
        public string name;
        public int age;
        public int fscMarks;
        public int ecatMarks;
        public float percentage;
        public List<string> choices = new List<string>();
        public Student()
        {

        }
        public Student(string name, int age, int fscMarks, int ecatMarks)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
        }
        public bool AddPreference(string choice)
        {
            if(choice != null )
            {
                choices.Add(choice);
                return true;
            }
            return false;
         
        }
        public float CalculateMerit()
        {
            this.percentage = (fscMarks * 60) / 1100.0F + (ecatMarks * 40) / 400;
            return percentage;
        }
        public void StudentAddToList(List<Student> TotalStudents, Student p)
        {
            TotalStudents.Add(p);
        }

    }

}
