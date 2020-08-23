using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TimeZone.Models;

namespace TimeZone.Controllers
{
    public class TimeController : Controller
    {
        [HttpGet("/clock")]
        public IActionResult GetTime()
        {
            DateTime date = DateTime.Now;
            return View(date);
        }
        [HttpGet("/worldclock")]
        public IActionResult GetTimeByTimezone(string timezone)
        {
            DateTime date = DateTime.Now;
            DateTime destinationDate = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(date, timezone);
            return View(destinationDate);
        }
    }
}