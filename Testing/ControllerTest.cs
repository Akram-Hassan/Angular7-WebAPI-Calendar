using Angular7_WebAPI_Calendar.Controllers;
using DAL;
using Microsoft.AspNetCore.Mvc;
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
            var actionResult = controller.MeetingDetails(1);
            var result = actionResult as OkObjectResult;
            var meeting = result.Value as Meeting;

            Assert.That(meeting.ID, Is.EqualTo(1));
            Assert.That(meeting.Name, Is.EqualTo("Meeting 1"));
        }
    }
}
