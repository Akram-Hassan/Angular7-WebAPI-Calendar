using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular7_WebAPI_Calendar.DAL
{
    public class FakeRepository : IDataRepository
    {
        public Meeting GetMeeting(int id)
        {
            var rng = new Random();
            return Enumerable.Range(1, 6).Select(index => new Meeting
            {
                ID = index,
                Name = $"Event {index}",
                Date = new DateTime(2000, index, 1)
            })
            .FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Meeting> GetMonthMeetings(int month)
        {
            return Enumerable.Range(1, 6).Select(index => new Meeting
            {
                ID = index,
                Name = $"Event {index}",
                Date = new DateTime(2000, index, 1)
            })
            .Where(x => x.Date.Month == month);
        }
    }
}
