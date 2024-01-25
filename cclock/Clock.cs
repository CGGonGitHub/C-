using System;

namespace cclock
{
    public class Clock
    {
        public Clock()
        { 
            
        }
        // returns Minutes to Seconds
        public int MinutesToSeconds(int min)
        {
            return min * 60;
        }

        // returns Seconds to Minutes
        public int SecondsToMinutes(int sec)
        {
            return sec / 60;
        }

        // Converts Time String to variables to use
        public (int, int, int) ConvertTimeString(string timeString)
        {
            string[] times = timeString.Split(':');
            int hours = int.Parse(times[0]);
            int minutes = int.Parse(times[1]);
            int seconds = int.Parse(times[2]);
            return (hours, minutes, seconds);

        }
        // Current Time
        public static (int, int, int) GetTimeNow()
        {
            int hour = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int seconds = DateTime.Now.Second;
            return (hour, minutes, seconds);
        }
    }
}
