using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular7_WebAPI_Calendar.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Angular7_WebAPI_Calendar.Controllers
{
    [Route("api/data")]
    public class DataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("meetings/{month}")]
        public IEnumerable<Meeting> MonthMeetings(int month)
        {
            var rng = new Random();
            return Enumerable.Range(1, 6).Select(index => new Meeting
            {
                ID = index,
                Name = $"Event {index}",
                Date = new DateTime(2000,index,1)
            })
            .Where(x => x.Date.Month == month);
        }

        [HttpGet("meeting/{id}")]
        public Meeting MeetingDetails(int id)
        {
            var rng = new Random();
            return Enumerable.Range(1, 6).Select(index => new Meeting
            {
                ID = index,
                Name = $"Event {index}",
                Date = new DateTime(2000, index, 1)
            })
            .FirstOrDefault(x => x.ID == id);
        }
    }
}
