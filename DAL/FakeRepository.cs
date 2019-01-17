using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class FakeRepository : IDataRepository
    {
        #region Fake Data
        private Attendee[] attendees = new Attendee[] {
            new Attendee {ID=1, Name="Attendee 1"},
            new Attendee {ID=2, Name="Attendee 2"},
            new Attendee {ID=3, Name="Attendee 3"},
            new Attendee {ID=4, Name="Attendee 4"},
            new Attendee {ID=5, Name="Attendee 5"},
            new Attendee {ID=6, Name="Attendee 6"},
            new Attendee {ID=7, Name="Attendee 7"},
            new Attendee {ID=7, Name="Attendee 8"},
            new Attendee {ID=7, Name="Attendee 9"},
            new Attendee {ID=7, Name="Attendee 10"}
        };
        private Attendee[] Attendees { get => attendees;}
        private Meeting[] Meetings { get {
                var meetings = new Meeting[]
                {
                    new Meeting
                    {
                        ID = 1,
                        Date = new DateTime(2000,1,1),
                        Name = "Meeting 1",
                        Attendees = new List<Attendee>{attendees[0], attendees[1], attendees[2]}
                    },
                    new Meeting
                    {
                        ID = 2,
                        Date = new DateTime(2000,1,1),
                        Name = "Meeting 2",
                        Attendees = new List<Attendee>{attendees[3]}
                    },
                    new Meeting
                    {
                        ID = 3,
                        Date = new DateTime(2000,1,1),
                        Name = "Meeting 3",
                        Attendees = new List<Attendee>{attendees[4], attendees[5]}
                    },
                    new Meeting
                    {
                        ID = 4,
                        Date = new DateTime(2000,2,1),
                        Name = "Meeting 4",
                        Attendees = new List<Attendee>{attendees[6], attendees[7]}
                    },
                    new Meeting
                    {
                        ID = 5,
                        Date = new DateTime(2000,2,1),
                        Name = "Meeting 5",
                        Attendees = new List<Attendee>{attendees[8]}
                    },
                    new Meeting
                    {
                        ID = 6,
                        Date = new DateTime(2000,3,1),
                        Name = "Meeting 6",
                        Attendees = new List<Attendee>{attendees[8], attendees[9]}
                    },
                    new Meeting
                    {
                        ID = 7,
                        Date = new DateTime(2000,4,1),
                        Name = "Meeting 7",
                        Attendees = new List<Attendee>{attendees[0], attendees[1], attendees[2], attendees[3]}
                    },
                    new Meeting
                    {
                        ID = 8,
                        Date = new DateTime(2000,4,1),
                        Name = "Meeting 8",
                        Attendees = new List<Attendee>{attendees[1]}
                    },
                    new Meeting
                    {
                        ID = 9,
                        Date = new DateTime(2000,4,1),
                        Name = "Meeting 9",
                        Attendees = new List<Attendee>{attendees[0], attendees[2]}
                    },
                    new Meeting
                    {
                        ID = 10,
                        Date = new DateTime(2000,5,1),
                        Name = "Meeting 10",
                        Attendees = new List<Attendee>{attendees[0], attendees[1], attendees[2], attendees[3]}
                    },
                    new Meeting
                    {
                        ID = 11,
                        Date = new DateTime(2000,5,1),
                        Name = "Meeting 11",
                        Attendees = new List<Attendee>{attendees[0], attendees[1]}
                    },
                    new Meeting
                    {
                        ID = 12,
                        Date = new DateTime(2000,6,1),
                        Name = "Meeting 12",
                        Attendees = new List<Attendee>{attendees[0], attendees[1], attendees[4] }
                    },
                    new Meeting
                    {
                        ID = 13,
                        Date = new DateTime(2000,7,1),
                        Name = "Meeting 13",
                        Attendees = new List<Attendee>{attendees[0], attendees[1], attendees[4] }
                    },
                    new Meeting
                    {
                        ID = 14,
                        Date = new DateTime(2000,7,1),
                        Name = "Meeting 14",
                        Attendees = new List<Attendee>{attendees[9], attendees[1], attendees[4] }
                    },
                };

                return meetings;
            }
        }
        #endregion

        public Meeting GetMeeting(int id) 
            => Meetings.FirstOrDefault(x => x.ID == id);

        public IEnumerable<Meeting> GetMonthMeetings(int month)
            => Meetings.Where(x => x.Date.Month == month);
    }
}
