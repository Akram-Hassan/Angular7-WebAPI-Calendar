using Angular7_WebAPI_Calendar.Controllers;
using DAL;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testing
{
    public class ControllerTest : BaseFixture
    {
        private DataController controller;

        private T ExtractValue<T>(IActionResult actionResult) where T : class {
            var result = actionResult as OkObjectResult;
            return result.Value as T;
        }

        [SetUp]
        public void MySetup()
        {
            controller = new DataController(repository);
        }


        [Test]
        public void TestGetOneMeeting()
        {
            var objectResult = controller.MeetingDetails(1);
            var meeting = ExtractValue<Meeting>(objectResult);
            Assert.That(meeting.ID, Is.EqualTo(1));
            Assert.That(meeting.Name, Is.EqualTo("Meeting 1"));
        }

        [Test]
        public void TestMonthMeetings()
        {
            var objectResult = controller.MonthMeetings(3);
            var extractedResult = ExtractValue<IEnumerable<Meeting>>(objectResult);
            var meetings = (extractedResult as IEnumerable<Meeting>)
                .ToArray();

            Assert.That(meetings[0].ID, Is.EqualTo(5));
            Assert.That(meetings[0].Name, Is.EqualTo("Meeting 5"));
        }

        [Test]
        public void TestGetNonExistingMeeting()
        {
            var result = controller.MeetingDetails(1000);
            Assert.That(result, Is.TypeOf<NotFoundResult>());
        }

        [Test]
        public void TestBadRequestForInvalidMonth()
        {
            var result = controller.MonthMeetings(13);
            Assert.That(result, Is.TypeOf<BadRequestResult>());
        }
    }
}
