﻿using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheetHrEmployeeApp.Interface;
using TimeSheetHrEmployeeApp.Models;
using TimeSheetHrEmployeeApp.Models.DTO;
using TimeSheetHrEmployeeApp.Services;

namespace TimeSheetHrEmployeeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("reactApp")]
    public class TimeSheetController : ControllerBase
    {
        private readonly ITimeSheetService _TimesheetService;
        private readonly ILogger _logger;
        public TimeSheetController(ITimeSheetService TimesheetService, ILogger<TimeSheetController> logger)
        {
            _TimesheetService = TimesheetService;
            _logger = logger;
        }
        /// <summary>
        /// adding the timesheet
        /// </summary>
        /// <param name="timeSheet"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult AddTimeSheet(TimeSheet timeSheet)
        {
            var result = _TimesheetService.AddTimeSheet(timeSheet);
            if (result)
            {
                return Ok(timeSheet);
            }
            _logger.LogError("time sheet failed");
            return BadRequest("Could not add time sheet");
        }
        /// <summary>
        /// get all timesheet for users
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAllTimeSheets(string Username)
        {
            var timesheet = _TimesheetService.GetAllTimeSheets(Username);
            if (timesheet != null)
            {
                _logger.LogInformation("Get all time sheets from user");
                return Ok(timesheet);
            }

            _logger.LogError("failed to get timesheet");
            return BadRequest("No timesheets found");
        }

    }
}
