using DAL;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;

namespace Testing
{
    public class RepositoryTests : BaseFixture
    {
        [Test]
        public void TestGetOneMeeting()
        {
            var meeting = repository.GetMeeting(1);
            Assert.That(meeting.ID, Is.EqualTo(1));
            Assert.That(meeting.Name, Is.EqualTo("Meeting 1"));
        }

        [Test]
        public void TestGetNonExistingMeeting()
        {
            var meeting = repository.GetMeeting(1000);
            Assert.That(meeting, Is.Null);
        }

        [Test]
        public void TestMeetingListForMonth()
        {
            var meetings = repository.GetMonthMeetings(1).ToArray();
            Assert.That(meetings.Length, Is.EqualTo(2));

            Assert.That(meetings[0].ID, Is.EqualTo(1));
            Assert.That(meetings[0].Name, Is.EqualTo("Meeting 1"));

            Assert.That(meetings[1].ID, Is.EqualTo(2));
            Assert.That(meetings[1].Name, Is.EqualTo("Meeting 2"));
        }

        [Test]
        public void TestInvalidMonthValue()
        {
            Assert.Throws(Is.TypeOf<ArgumentException>()
                    .And.Message.EqualTo("Invalid Month Value"),
                    delegate {
                        repository.GetMonthMeetings(100);
                    });
        }
    }
}