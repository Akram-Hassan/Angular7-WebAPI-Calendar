using Angular7_WebAPI_Calendar.Controllers;
using DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class ControllerTest : BaseFixture
    {
        [SetUp]
        public void MySetup()
        {
            controller = new DataController(repository);
        }

        private DataController controller;

        [Test]
        public void TestGetOneMeeting()
        {
            var meeting = controller.MeetingDetails(1);
            Assert.That(meeting.ID, Is.EqualTo(1));
            Assert.That(meeting.Name, Is.EqualTo("Meeting 1"));
        }
    }
}
