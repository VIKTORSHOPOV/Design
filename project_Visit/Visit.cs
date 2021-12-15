using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Visit
{
    class Visit
    {
        string date;
        string clock;
        int day;
        int bytes;
        int seconds;
        string web;

        public string Date
        {
            set { date = value; }
            get { return date; }
        }
        public string Clock
        {
            set { clock = value; }
            get { return clock; }
        }
        public int Day
        {
            set { if (value >= 1 && value <= 7) day = value; }
            get { return day; }
        }
        public int Bytes
        {
            set { bytes = value; }
            get { return bytes; }
        }
        public int Seconds
        {
            set { if (value >= 0) seconds = value; }
            get { return seconds; }
        }
        public string Web
        {
            set { web = value; }
            get { return web; }
        }

        public Visit()
        {
            Date = "";
            Clock = "";
            Day = 1;
            Bytes = 0;
            Seconds = 0;
            Web = "";
        }

        public Visit(string aDate, string aClock, int aDay, int aBytes, int aSeconds, string aWeb)
        {
            Date = aDate;
            Clock = aClock;
            Day = aDay;
            Bytes = aBytes;
            Seconds = aSeconds;
            Web = aWeb;
        }

        public string CalcTime()
        {
            return $"{Seconds / 3600}:{Seconds / 60 % 60}:{Seconds % 60}";
        }

        public string InfoForVisit()
        {
            string dayOfTheWeekS = "";
            switch (Day)
            {
                case 1: dayOfTheWeekS = "Monday"; break;
                case 2: dayOfTheWeekS = "Tuesday"; break;
                case 3: dayOfTheWeekS = "Wednesday"; break;
                case 4: dayOfTheWeekS = "Thursday"; break;
                case 5: dayOfTheWeekS = "Friday"; break;
                case 6: dayOfTheWeekS = "Saturday"; break;
                case 7: dayOfTheWeekS = "Sunday"; break;

                default:
                    break;
            }
            return ($"{Date}/{Clock}, {dayOfTheWeekS}, {Bytes} B, stay {CalcTime()}, {Web}");
        }

        
    }
}
