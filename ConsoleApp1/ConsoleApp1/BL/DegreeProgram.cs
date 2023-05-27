using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.BL
{
    class DegreeProgram
    {
        public string degreeName;
        public int duration;
        public int availableSeats;
        public List<Subject> selectSubject = new List<Subject>();

        public void AddDegreeToList( List<DegreeProgram> programs, DegreeProgram d)
        {
            if(d.selectSubject[0].fees != 0)
            {
                programs.Add(d);
            }          
        }
        public void AddSubjectToDegree(Subject s)
        {
            selectSubject.Add(s);
        }
        public int GetCreditHours()
        {
            int hour = 0;
            foreach (Subject x in selectSubject)
            {
                hour = x.creditHours + hour; 
            }
            return hour;           
        }
    }
}
