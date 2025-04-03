using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class MeetingSchedule
    {
        public Meeting[] meetings = new Meeting[16];
        public int MeetingDay = 0;
        public void SetMeeting(string fullName,DateTime from,DateTime to)
        {
            try
            {
                if (from>=to)
                Console.WriteLine(WrongDateIntervalException ());   
                for (int i=0; i<MeetingDay;i++)
            }
            catch 
            {
                Console.WriteLine(ReservedDateInterval ());
            }
            
        }
    }
}
