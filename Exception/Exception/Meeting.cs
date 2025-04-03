using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Meeting
    {
        public int FromDate { get; set; }
        public int ToDate { get; set; }
        public string FullName { get; set; }

        public Meeting(int fromDate,int toDate,string fullName)
            
        {
            FromDate = fromDate;
            ToDate = toDate;
            FullName = fullName;
        }
    }
}
