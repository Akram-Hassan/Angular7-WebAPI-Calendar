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
            => context.Meetings
                .Include(x => x.Attendees)
                .FirstOrDefault(x => x.ID == id);

        public IEnumerable<Meeting> GetMonthMeetings(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentException("Invalid Month Value");
            }
            return context.Meetings.Where(x => x.Date.Month == month);
        }
    }
}
