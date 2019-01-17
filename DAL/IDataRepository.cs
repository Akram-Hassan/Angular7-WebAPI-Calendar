using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDataRepository
    {
        IEnumerable<Meeting> GetMonthMeetings(int month);
        Meeting GetMeeting(int id);
    }
}
