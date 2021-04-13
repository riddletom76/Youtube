using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogDemoApplication
{
    public class LogDemoController : Controller
    {
        private readonly ILogger<LogDemoController> _logger;

        public LogDemoController(ILogger<LogDemoController> logger)
        {
            _logger = logger;
        }

        public void SampleMethodToDemoLogging() 
        {
            _logger.LogTrace("This is a trace log");
            _logger.LogDebug("debug Log");
            _logger.LogInformation("information log");
            _logger.LogWarning("warning log");
            _logger.LogCritical("critical log");
            _logger.LogError("error log");
            //Trace < Debug < information < Warning < Error < Critical
        }
    }
}
