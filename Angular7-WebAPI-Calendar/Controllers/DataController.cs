using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace Angular7_WebAPI_Calendar.Controllers
{
    [Route("api/data")]
    public class DataController : Controller
    {
        private readonly IDataRepository repository;

        public DataController(IDataRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("meetings/{month}")]
        public IEnumerable<Meeting> MonthMeetings(int month)
        {
            var result = repository.GetMonthMeetings(month);

            return result;
        }

        [HttpGet("meeting/{id}")]
        public Meeting MeetingDetails(int id)
        {
            return repository.GetMeeting(id);
        }
    }
}
