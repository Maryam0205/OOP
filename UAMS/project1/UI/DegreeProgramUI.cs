using project1.BL;
using project1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.UI
{
    class DegreeProgramUI
    {
        public static DegreeProgram takeInputForDegree()
        {
            string degreeName;
            float degreeDuration;
            int seats;
            Console.Write("Enter Degree Name: ");
            degreeName = Console.ReadLine();
            Console.Write("Enter Degree Duraion: ");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.Write("Enter Seats for degree: ");
            seats = int.Parse(Console.ReadLine());

            DegreeProgram degProg = new DegreeProgram(degreeName, degreeDuration, seats);
            Console.Write("Enter how many subject to enter: ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                subject s = SubjectUI.takeInputForSubjet();
                if(degProg.AddSubject(s))
                {
                    if(!(SubjectDL.subjectList.Contains(s)))
                    {
                        SubjectDL.addSubjectIntoList(s);
                        SubjectDL.storeintoFile("subject.txt", s);
                    }
                    Console.WriteLine("Subject added");
                }
                else
                {
                    Console.WriteLine("Subject not added");
                    Console.WriteLine("20 credit hour limit exceede");
                    x--;
                }
            }
            return degProg;
        }
        public static void viewDegreePrograms()
        {
            foreach (DegreeProgram dp in DegreeProgramDL.programList)
            {
                Console.WriteLine(dp.degreeName);
            }
        }
    }
}
