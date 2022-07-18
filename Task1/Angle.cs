using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Angle
    {
        int degrees;
        int minutes;
        int seconds;
        public bool isCorrect = true;

        public int Degrees
        {
            get
            {
                return degrees;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    degrees = value % 360; 
            }
        }
        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    minutes = value % 60;
                Degrees += value / 60;
            }
        }
        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    seconds = value % 60;
                    Minutes += value / 60;
            }
        }

        public Angle (int degrees, int minutes, int seconds)
        {
            this.Degrees = degrees;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public double ToRadians()
        {
            return ((degrees + minutes / 60 + seconds / (60 * 60)) * Math.PI) / 180;
        }

    }
}
