using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.UI
{
    class MenuUI
    {
        public static void header()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("         UAMS             ");
            Console.WriteLine("**************************");
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();
        }
        public static int Menu()
        {
            header();
            int option;
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Studetn of a specific program");
            Console.WriteLine("6. Register Subject for a specific student");
            Console.WriteLine("7. Calculate Fees for All Registered Students");
            Console.WriteLine("8. Exit");
            Console.Write("Enter Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
