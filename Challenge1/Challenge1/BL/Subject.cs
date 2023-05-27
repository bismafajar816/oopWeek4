using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class Subject
    {
        public string type;
        public string code;
        public int creditHours;
        public int fees;
        public Subject(string code, string type, int creditHours, int subjectFees)
        {
            this.code = code;
            this.type = type;
            this.creditHours = creditHours;
            this.fees = subjectFees;
        }


       
    }
}
