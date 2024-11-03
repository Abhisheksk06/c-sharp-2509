using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Time
    {
        public int hours;
        public int minutes;
        public int seconds;

        //Method to set time using hours and minutes
        public void SetTime(int hours, int minutes)
        {
            if (hours >= 0 && hours < 24 && minutes >= 0 && minutes < 60)
            {
                this.hours = hours;
                this.minutes = minutes;
            }
            else
            {
                Console.WriteLine("Invalid hours or minutes. Please enter valid values");
            }
        }
        //Method to set the time using totalseconds
        public void SetTime(int totalseconds)
        {
            if (totalseconds >= 0 && totalseconds < 86400)
            {
                this.hours = totalseconds / 3600; //convert total number of seconds into hours
                totalseconds = totalseconds % 3600; //remaining seconds
                this.minutes = totalseconds / 60; //converts remaining seconds to minutes
                this.seconds = totalseconds % 60; //remaining seconds after the minutes 
            }
            else
            {
                Console.WriteLine("Invalid total seconds.");
            }
        }

        public void DisplayTime()
        {
            Console.WriteLine($"Time: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
