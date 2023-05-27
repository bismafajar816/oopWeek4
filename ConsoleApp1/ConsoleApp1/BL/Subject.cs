using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.BL
{
    class Subject
    {
        public string name;
        public string code;
        public int creditHours;
        public int fees;

        public void RegisterSubject(List<Student> registeredStudents , List<DegreeProgram> degrees, List<DegreeProgram> subjects,string name, string code)
        {
            int i = 0;
            foreach(Student x in registeredStudents)
            {
                if (name == x.name)
                {
                    foreach(DegreeProgram y in degrees)
                    {
                        if(code == y.selectSubject[i].code)
                        {
                           
                            subjects.Add(y);
                            if (i > degrees.Count())
                            {
                                break;
                            }
                            i++;
                        }
                      
                    }
                }
            }
           
            
        }

        public int RegisterSubjectsFees(List<Student> registeredStudents, List<DegreeProgram> degrees, List<DegreeProgram> subjects, string name)
        {
            int i = 0;
            int fees = 0;
            foreach (Student x in registeredStudents)
            {
                if (name == x.name)
                {
                    foreach (DegreeProgram y in subjects)
                    {
                        fees = y.selectSubject[i].fees + fees;
                        if (i > degrees.Count())
                        {
                            break;
                        }
                        i++;

                    }
                }
            }
            return fees;
        }


    }
}
