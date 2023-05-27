using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesments
{
    class Student
    {
        public string name;
        public string rollNumber;
        public float cgpa;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;
        public Student(string name, string rollNumber, float cgpa, int matricMarks, int fscMarks, int ecatMarks, string homeTown, bool isHostelite, bool isTakingScholarship)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.cgpa = cgpa;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.homeTown = homeTown;
            this.isHostelite = isHostelite;
            this.isTakingScholarship = isTakingScholarship;
        }
        public float CalculateMerit()
        {
            int merit = ((this.fscMarks * 60) / 1100) + ((this.ecatMarks * 40) / 400);
            return merit;
        }
        public bool IsEligibleForScholarship(float percentage)
        {
            if(percentage > 80.0F)
            {
                return true;
            }
            return false;
        }

    }
}
