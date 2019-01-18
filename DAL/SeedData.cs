using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SeedData
    {
        public static readonly Attendee[] Attendees = new Attendee[] {
                new Attendee { ID = 1, Name = "Att 1", MeetingId = 1 },
                new Attendee { ID = 2, Name = "Att 2", MeetingId = 1 },
                new Attendee { ID = 3, Name = "Att 3", MeetingId = 3 },
                new Attendee { ID = 4, Name = "Att 4", MeetingId = 2 },
                new Attendee { ID = 5, Name = "Att 5", MeetingId = 4 },
                new Attendee { ID = 6, Name = "Att 6", MeetingId = 4 },
                new Attendee { ID = 7, Name = "Att 7", MeetingId = 4 },
                new Attendee { ID = 8, Name = "Att 8", MeetingId = 4 },
                new Attendee { ID = 9, Name = "Att 9", MeetingId = 4 },
                new Attendee { ID = 10, Name = "Att 10", MeetingId = 5 },
                new Attendee { ID = 11, Name = "Att 11", MeetingId = 5 },
                new Attendee { ID = 12, Name = "Att 12", MeetingId = 5 },
            };
        public static readonly Meeting[] Meetings = new Meeting[] {
                new Meeting {
                    ID = 1,
                    Name = "Meeting 1",
                    Date = new DateTime(2000,1,1),
                },
                new Meeting{
                    ID = 2,
                    Name = "Meeting 2",
                    Date = new DateTime(2000,1,1),
                },
                new Meeting{
                    ID = 3,
                    Name = "Meeting 3",
                    Date = new DateTime(2000,2,1),
                },
                new Meeting{
                    ID = 4,
                    Name = "Meeting 4",
                    Date = new DateTime(2000,2,1),
                },
                new Meeting{
                    ID = 5,
                    Name = "Meeting 5",
                    Date = new DateTime(2000,3,1),
                },
                new Meeting{
                    ID = 6,
                    Name = "Meeting 6",
                    Date = new DateTime(2000,3,1),
                },
                new Meeting{
                    ID = 7,
                    Name = "Meeting 7",
                    Date = new DateTime(2000,3,1),
                },
                new Meeting{
                    ID = 8,
                    Name = "Meeting 8",
                    Date = new DateTime(2000,3,1),
                },
                new Meeting{
                    ID = 9,
                    Name = "Meeting 9",
                    Date = new DateTime(2000,4,1),
                },
                new Meeting{
                    ID = 10,
                    Name = "Meeting 10",
                    Date = new DateTime(2000,4,1),
                },
                new Meeting{
                    ID = 11,
                    Name = "Meeting 11",
                    Date = new DateTime(2000,5,1),
                }
            };
    }
}
