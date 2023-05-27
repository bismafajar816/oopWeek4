using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class DegreeProgram
    {
        public string degreeName;
        public int duration;
        public int availableSeats;
        public List<Subject> Subjects;
        public DegreeProgram (string degreeName, int duration, int availableSeats)
        {
            this.degreeName = degreeName;
            this.duration = duration;
            this.availableSeats = availableSeats;
            Subjects = new List<Subject>();
        }
        public int CalculateCreditHours()
        {
            int count = 0;
           for(int x = 0; x < Subjects.Count(); x++)
            {
                count = Subjects[x].creditHours;
            }
            return count;
        }
        public bool AddSubject(Subject s)
        {
            int creditHours = CalculateCreditHours();
            if(creditHours+s.creditHours<=20)
            {
                Subjects.Add(s);
                return true;
            }
            return false;
        }
        public void AddToListDegrees(DegreeProgram d)
        {
            programs.Add(d);
        }
        public bool IssubjectPresent(Subject s)
        {
            foreach(Subject x in Subjects)
            {
                if(s.code == x.code)
                {
                    return true;
                }
            }
            return false;
        }
        public List<DegreeProgram> GetAllAvailablePrograms()
        {
            return programs;
        }
        public bool GenerateMerit(List<Student> students)
        {
            foreach (Student x in students)
            {
                int i = 0;
                if (x.percentage > 80.0F && programs[i].degreeName == x.choices[i] && programs[i].availableSeats > registeredStudents.Count() )
                {
                    registeredStudents.Add(x);
                    return true; 
                }
                else
                {
                  
                    students.Remove(x);
                    return false;
                }
                i++;
                if(i > students.Count())
                {
                    break;
                }
               
            }
            return false;
        }
        public List<Student> RegisteredStudents()
        {
            return registeredStudents;
          /*  Console.WriteLine("Name \t\t FSC Marks \t\t ECAT Marks \t\t Age ");
            foreach(Student x in registeredStudents)
            {
                Console.WriteLine(x.name + "\t\t" + x.fscMarks + "\t\t" + x.ecatMarks + "\t\t" + x.age);
            }*/
        }
        public Student SpecifiedRegisteredStudents(string department)
        {
           /* Console.WriteLine("Name \t\t FSC Marks \t\t ECAT Marks \t\t Age ");*/
            foreach (Student x in registeredStudents)
            {
                int i = 0;
                if(x.choices[i] == department)
                {
                    return x;
                   /* Console.WriteLine(x.name + "\t\t" + x.fscMarks + "\t\t" + x.ecatMarks + "\t\t" + x.age);*/
                }
             
                i++;
                if(i > registeredStudents.Count())
                {
                    break;
                }
            }
            return null;
        }


    }

}
