using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.BL;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Student> registeredStudents = new List<Student>();
            Student input = new Student();
            List<DegreeProgram> degrees = new List<DegreeProgram>();
            DegreeProgram inputDegree = new DegreeProgram();
            List<DegreeProgram> subjects = new List<DegreeProgram>();
            int option = Menu();
            {
                while(option!= 0)
                {
                    if(option == 1)
                    {
                        //Add Student
                        input = AddStudent(students);
                        input.StudentAddToList(students, input);
                        Console.WriteLine("Student Added");
                        option = Menu();
                    }
                    else if(option == 2)
                    {
                        // Add Degree 
                        inputDegree = AddDegree(degrees);
                        inputDegree.AddDegreeToList(degrees, inputDegree);
                        Console.WriteLine("Degree added");
                        Console.ReadKey();
                        option = Menu();
                    }
                    else if (option == 3)
                    {
                        PrintMerit(students, degrees, registeredStudents);
                        Console.ReadKey();
                        option = Menu();
                    }
                    else if (option == 4)
                    {
                        PrintStudentsForSpecificDegree(students, registeredStudents);
                        Console.ReadKey();
                        option = Menu();
                    }
                    else if (option == 5)
                    {
                        PrintRegisteredStudents(registeredStudents);
                        Console.ReadKey();
                        option = Menu();
                    }
                    else if (option == 6)
                    {
                        SubjectReg(registeredStudents, degrees, subjects);
                        Console.ReadKey();
                        option = Menu();
                    }
                    else if (option == 7)
                    {
                        Fees(registeredStudents, degrees, subjects);
                        Console.ReadKey();
                        option = Menu();
                    }
                }
            }
           
          
         

            Console.ReadKey();

        }
        static Student AddStudent(List<Student> students)
        {
            Student info = new Student();
            Console.WriteLine("Enter name: ");
            info.name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            info.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fsc marks: ");
            info.fscMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ecat marks: ");
            info.ecatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of preferences: ");
            int num = int.Parse(Console.ReadLine());
            for (int x = 0; x < num; x++)
            {
                Console.WriteLine("Enter preference: ");
                string choose = Console.ReadLine();
                if (info.AddPreference(choose))
                {
                    Console.WriteLine("preference entered");
                }
            }
            info.percentage =    info.CalculateMerit();
            return info;
        }
        static DegreeProgram AddDegree(List<DegreeProgram> degrees)
        {
            DegreeProgram info = new DegreeProgram();
            Console.WriteLine("Enter name: ");
            info.degreeName = Console.ReadLine();
            Console.WriteLine("Enter duration: ");
            info.duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter available seats: ");
            info.availableSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of Subjects: ");
            int num = int.Parse(Console.ReadLine());
            for (int x = 0; x < num; x++)
            {
                if(info.GetCreditHours() <= 20)
                {
                    Subject selectSubject = new Subject();
                    Console.WriteLine("Enter Subject Code: ");
                    selectSubject.code = Console.ReadLine();
                    Console.WriteLine("Enter Subject Type: ");
                    selectSubject.name = Console.ReadLine();
                    Console.WriteLine("Enter Subject Credit Hours: ");
                    selectSubject.creditHours = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Subject Fees: ");
                    selectSubject.fees = int.Parse(Console.ReadLine());
                    info.AddSubjectToDegree(selectSubject);
                }
                else
                {
                    break;
                }
             
            } 
            return info;
        }
        static void PrintMerit(List<Student> students  , List<DegreeProgram> degrees,List<Student> registeredStudents)
        {
           
            foreach(Student x in students)
            {
                foreach(DegreeProgram y in degrees)
                {

                    if (x.percentage > 85 && y.availableSeats > 0 && x.choices[0] == y.degreeName)
                    {
                        Console.WriteLine(x.name + " got admission in " + x.choices[0]);
                        registeredStudents.Add(x);

                    }
                   else  if(y.selectSubject.Count()> 1)
                    {
                         if (x.percentage > 85 && y.availableSeats > 0 && x.choices[1] == y.degreeName)
                        {
                            Console.WriteLine(x.name + " got admission in " + x.choices[1]);
                            registeredStudents.Add(x);
                        }
                    }
                    
                    else
                    {
                        Console.WriteLine(x.name + " does not got admission. " );
                    }
                
                   
                }
               
            }          
        }
        static void PrintRegisteredStudents(List<Student> registeredStudents)
        {
            Console.WriteLine("Name \t\t Age \t\t Ecat \t\t Fsc");
            foreach(Student x in registeredStudents)
            {
                Console.WriteLine(x.name + " \t\t " + x.age + " \t\t " + x.ecatMarks + " \t\t " + x.fscMarks);
            }
        }
        static void PrintStudentsForSpecificDegree(List<Student> students, List<Student> registeredStudents)
        {
            Console.WriteLine("Enter degree name: ");
            string degree = Console.ReadLine();
            Console.WriteLine("Name \t\t Age \t\t Ecat \t\t Fsc");
            foreach (Student x in students)
            {
                foreach(Student y in registeredStudents)
                {
                    if(x.name == y.name && ( x.choices[0] == y.choices[0]  || x.choices[1] == y.choices[0]) && (x.choices[0] == degree || degree == y.choices[0]))
                    {
                       
                        Console.WriteLine(y.name + " \t\t " + y.age + " \t\t " + y.ecatMarks + " \t\t " + y.fscMarks);

                    }
                }
            }
        }
        static void SubjectReg(List<Student> registeredStudents, List<DegreeProgram> degrees, List<DegreeProgram> subjects)
        {
            Subject info = new Subject();
            Console.WriteLine("Enter registered name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Subject Code : ");
            string code = Console.ReadLine();
            info.RegisterSubject(registeredStudents, degrees, subjects, name, code);

        }
        static void Fees(List<Student> registeredStudents, List<DegreeProgram> degrees, List<DegreeProgram> subjects)
        {
            Subject info = new Subject();
            Console.WriteLine("Enter registered name: ");
            string name = Console.ReadLine();
          
            int fee=   info.RegisterSubjectsFees(registeredStudents, degrees, subjects, name);
            Console.WriteLine("Your fee: " + fee);

        }
        static void Header()
        {
            Console.Clear();
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("                                UAMS                                  ");
            Console.WriteLine("**********************************************************************");
        }
        static int Menu()
        {
            Header();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Add degree programs");
            Console.WriteLine("3. Add Generate merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Registered students for specified programs");
            Console.WriteLine("6. Register Subject");
            Console.WriteLine("7. Calculate Fees for all registered Students");
            Console.WriteLine("Enter Your choice: ");
            int opt = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            return opt;
        }
    }
}
