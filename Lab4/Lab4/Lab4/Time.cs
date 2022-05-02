using System;

namespace Lab4
{
    public class Time
    {
        private readonly int hours, minutes, seconds;
        
        public Time()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        
        public Time(int hours, int minutes = 0, int seconds = 0)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        
        public Time(Time protoTime)
        {
            hours = protoTime.hours;
            minutes = protoTime.minutes;
            seconds = protoTime.seconds;
        }

        public int Hours() => hours;

        public int Minutes() => minutes;

        public int Seconds() => seconds;

        public Time ToEod() => new Time(23 - hours, 59 - minutes, 60 - seconds);
        
        public static Time operator +(Time currT, int minutes)
        {
            int hours = 0;
            int m = minutes;
            m += 2;
            if (m >= 60)
            {
                hours++;
                minutes -= 60;
            }
            return new Time(currT.hours + hours, currT.minutes + minutes, currT.seconds);
        }
        
        public static Time operator -(Time t1, Time t2)
        {
            DateTime dt1 = DateTime.Parse($"{t1.hours}:{t1.minutes}:{t1.seconds}");
            DateTime dt2 = DateTime.Parse($"{t2.hours}:{t2.minutes}:{t2.seconds}");
            return new Time((dt1 - dt2).Hours, (dt1 - dt2).Minutes, (dt1 - dt2).Seconds);
        }
    }
}