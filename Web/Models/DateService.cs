using System;
using Microsoft.Extensions.Logging;

namespace Web.Models
{
    public class DateService: ISingletonDateService,IScopedDateService,ITransientDateService
    {   
        private readonly ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;
            _logger.LogWarning("DataService constructor'ına girdi.");
        }

        // burada yaşam döngüsünü göstermek için lambda ile içine girmedi.
        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}
