using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oceanNavigationSystem.BL
{
    class Ship
    {
        public string SerialNumber;
        public angle latitude ;
        public angle longitude;
        public Ship(string number, angle latitude, angle longitude)
        {
            this.SerialNumber = number;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public void PrintPosition()
        {
            Console.WriteLine("Ship is at {0} and {1}",latitude.DisplayAngle(), longitude.DisplayAngle());
        }
        public void PrintSerailNumber(angle lati, angle longi)
        {
            if ( lati == latitude && longi == longitude)
            {
                Console.WriteLine("Ship serial number is {0}", SerialNumber);
            }
        }
    }
}
