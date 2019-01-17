using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular7_WebAPI_Calendar.DAL
{
    public interface IDataRepository
    {
        IEnumerable<Meeting> GetMonthMeetings(int month);
        Meeting GetMeeting(int id);
    }
}
