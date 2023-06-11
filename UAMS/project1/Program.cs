using project1.BL;
using project1.DL;
using project1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string subjectPath = "subject.txt";
            string degreePath = "degree.txt";
            string studentPath = "student.txt";
            if(SubjectDL.readFromFile(subjectPath))
            {
                Console.WriteLine("Subject Data Loaded Successfully");
            }
            if(DegreeProgramDL.readFromFile(degreePath))
            {
                Console.WriteLine("DEgreeProgram Data Loaded Successfully");
            }
            if(StudentDL.readFromFile(studentPath))
            {
                Console.WriteLine("Student data loaded Successfully");
            }
            int option;
            do
            {
                option = MenuUI.Menu();
                MenuUI.clearScreen();
                if (option == 1)
                {
                    if (DegreeProgramDL.programList.Count > 0)
                    {
                        Student s = StudentUI.takeInputForStudent();
                        StudentDL.addIntoStudentList(s);
                        StudentDL.storeintoFile(studentPath, s);
                    }
                }
                else if (option == 2)
                {
                    DegreeProgram d = DegreeProgramUI.takeInputForDegree();
                    DegreeProgramDL.addIntoDegreeList(d);
                    DegreeProgramDL.storeintoFile(degreePath, d);
                }
                else if (option == 3)
                {
                    List<Student> sortedStudentList = new List<Student>();
                    sortedStudentList = StudentDL.sortStudentByMerit();
                    StudentDL.giveAdmission(sortedStudentList);
                    StudentUI.printStudents();
                }
                else if (option == 4)
                {
                    StudentUI.viewRegisteredStudennts();
                }
                else if (option == 5)
                {
                    string degName;
                    Console.Write("enter DEgree Name: ");
                    degName = Console.ReadLine();
                    StudentUI.viewStudentInDegree(degName);
                }
                else if (option == 6)
                {
                    Console.Write("Enter the student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentDL.StudentPresent(name);
                    if (s != null)
                    {
                        SubjectUI.viewSubjects(s);
                        SubjectUI.registerSubject(s);
                    }
                }
                else if (option == 7)
                {
                    StudentUI.calculateFeeForAll();
                }
                MenuUI.clearScreen();
            }
            while (option != 8);
        }
    }
}
