using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataRepository : IDataRepository
    {
        private readonly AppDbContext context;

        public DataRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Meeting GetMeeting(int id)
        {

            Meeting meeting = context.Meetings.Include(x => x.Attendees)
                .FirstOrDefault(x => x.ID == id);

            //var attendees = meeting.Attendees;

            ////Todo: Remove this
            //meeting.Attendees = new List<Attendee>();
            //foreach (var item in attendees)
            //{
            //    meeting.Attendees.Add(new Attendee { ID = item.ID, Name = item.Name });
            //}

            return meeting;
        }

        public IEnumerable<Meeting> GetMonthMeetings(int month) 
            => context.Meetings.Where(x => x.Date.Month == month);
    }
}
