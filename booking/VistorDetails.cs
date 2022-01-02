using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking
{
    public class VistorDetails
    {
        public int id { get; set; }

        public String name { get; set; }

        public String contact { get; set; }

        public DateTime date
        {
            get; set;
        }
        public DayOfWeek day
        {
            get; set;
        }
        public DateTime CheckInTime
        {
            get; set;
        }

        public int age
        {
            get; set;
        }
        public int group
        {
            get; set;
        }
        public int Duration
        {
            get; set;
        }
        public DateTime CheckoutTime
        {
            get; set;
        }
        public int TotalPrice
        {
            get; set;
        }
    }
}
