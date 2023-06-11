using oceanNavigationSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oceanNavigationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ship> ships = new List<Ship>();
            while(true)
            {
                string option = menu();
                if (option == "1")
                {
                    string serial;
                    Console.Write("Enter Ship Number ");
                    serial = Console.ReadLine();
                    angle lat = GetLatitude();
                    angle lon = GetLongitude();
                    Ship s = new Ship(serial, lat, lon);
                    ships.Add(s);
                }
                if (option == "2")
                {
                    Console.WriteLine("Enter Ship Serial Number ");
                    string serial = Console.ReadLine();
                    foreach(Ship s in ships)
                    {
                        if (serial == s.SerialNumber)
                        {
                            s.PrintPosition();
                        }
                    }
                }
                if (option == "3")
                {
                    angle lat = GetLatitude();
                    angle lon = GetLongitude();
                    foreach(Ship s in ships)
                    {
                        s.PrintSerailNumber(lat, lon);
                    }
                }
                if (option == "4")
                {
                    string serial;
                    int check = 0;
                    Console.Write("Enter Ship Serial Number ");
                    serial = Console.ReadLine();
                    foreach(Ship s in ships)
                    {
                        if(serial == s.SerialNumber)
                        {
                            s.latitude = GetLatitude();
                            s.longitude = GetLongitude();
                            check++;
                        }
                    }
                    if(check == 0)
                    {
                        Console.WriteLine("Ship not Found ");
                    }
                }
                if (option == "5")
                {
                    break;
                }
                Console.ReadKey();
            }
        }
        public static string menu()
        {
            string option;
            Console.WriteLine("1. Add Ship ");
            Console.WriteLine("2. View Ship Position ");
            Console.WriteLine("3. View Ship Serial Number ");
            Console.WriteLine("4. Change Ship Position ");
            Console.WriteLine("5. Exit ");
            option = Console.ReadLine();
            return option;
        }
        public static angle GetLatitude()
        {
            int deg;
            float min;
            char dir;
            Console.WriteLine("Enter Ship Latitude ");
            Console.Write("Enter latitude degree ");
            deg = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter latitude minutes ");
            min = float.Parse(Console.ReadLine());
            Console.Write("Enter latitude direction ");
            dir = char.Parse(Console.ReadLine());
            angle lat = new angle(deg, min, dir);
            return lat;
        }
        public static angle GetLongitude()
        {
            int deg;
            float min;
            char dir;
            Console.WriteLine("Enter Ship Longitude ");
            Console.Write("Enter longitude degree ");
            deg = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter longitude minutes ");
            min = float.Parse(Console.ReadLine());
            Console.Write("Enter longitude direction ");
            dir = char.Parse(Console.ReadLine());
            angle lon = new angle(deg, min, dir);
            return lon;
        }
    }
}
