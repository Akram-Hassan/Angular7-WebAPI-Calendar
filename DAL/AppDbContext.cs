using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Meeting> Meetings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var att1 = new Attendee { ID = 1, Name = "Att 1", MeetingId = 1};
            var att2 = new Attendee { ID = 2, Name = "Att 2", MeetingId = 1 };
            var att3 = new Attendee { ID = 3, Name = "Att 3", MeetingId = 3 };

            var meeting1 = new Meeting
            {
                ID = 1,
                Name = "Meeting 1",
                Date = DateTime.Today,
            };

            var meeting2 = new Meeting
            {
                ID = 2,
                Name = "Meeting 2",
                Date = DateTime.Today,
            };

            var meeting3 = new Meeting
            {
                ID = 3,
                Name = "Meeting 3",
                Date = DateTime.Today.AddMonths(1),
            };

            modelBuilder.Entity<Meeting>().HasData(meeting1, meeting2, meeting3);
            modelBuilder.Entity<Attendee>().HasData(att1, att2, att3);
        }
    }
}
