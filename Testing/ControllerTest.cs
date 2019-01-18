using Angular7_WebAPI_Calendar.Controllers;
using DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class ControllerTest
    {
        private AppDbContext context;
        private DataRepository repository;

        [SetUp]
        public void Setup()
        {
            context = AppContextFactory.CreateContext();
            repository = new DataRepository(context);
            controller = new DataController(repository);
        }

        [TearDown]
        public void TearDown()
        {
            context.Dispose();
            context = null;
            repository = null;
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
