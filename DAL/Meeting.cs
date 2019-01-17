using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular7_WebAPI_Calendar.DAL
{
    public class Meeting
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<Attendee> Attendees { get; set; }
    }
}
