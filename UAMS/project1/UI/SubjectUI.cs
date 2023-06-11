using project1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.UI
{
    class SubjectUI
    {
        public static subject takeInputForSubjet()
        {
            string code;
            string type;
            int creditHours;
            int subjectFees;
            Console.Write("Enter Subject Code: ");
            code = Console.ReadLine();
            Console.Write("Enter Subject Type: ");
            type = Console.ReadLine();
            Console.Write("Enter Subject Credit Hours: ");
            creditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees: ");
            subjectFees = int.Parse(Console.ReadLine());
            subject sub = new subject(code, type, creditHours, subjectFees);
            return sub;
        }
        public static void viewSubjects(Student s)
        {
            if(s.regDegree != null)
            {
                Console.WriteLine("Sub code\tSub type ");
                foreach (subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.code + "\t\t" + sub.type);
                }
            }
        }
        public static void registerSubject(Student s)
        {
            Console.WriteLine("Enter how many subject you want to register");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Enter the subject Code");
                string code = Console.ReadLine();
                bool flag = false;
                foreach(subject sub in s.regDegree.subjects)
                {
                    if(code == sub.code && !(s.regSubject.Contains(sub)))
                    {
                        if(s.regStudentSubject(sub))
                        {
                            flag = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("A student can not have more than 9 CH");
                            flag = true;
                            break;
                        }
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("Enter Valid Course");
                    x--;
                }
            }
        }
    }
}
