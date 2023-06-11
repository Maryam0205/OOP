using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oceanNavigationSystem.BL
{
    class angle
    {
        public int degree;
        public float minutes;
        public char direction;
        public angle(int degree, float minutes, char direction)
        {
            this.degree = degree;
            this.minutes = minutes;
            this.direction = direction;
        }
        public void ChangeAngle(int degree, float minute, char direction)
        {
            this.degree = degree;
            this.minutes = minute;
            this.direction = direction;
        }
        public bool DisplayAngle()
        {
            Console.WriteLine(degree + "\u00b0" + minutes + "' " + direction);
            return true;
        }
    }
}
