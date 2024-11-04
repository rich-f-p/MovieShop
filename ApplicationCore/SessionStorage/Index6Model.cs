using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SessionStorage
{
    public class Index6Model : PageModel
    {
        const string SessionKeyTime = "_Time";
        public string? SessionInfo_SessionTime { get; private set; }
        private readonly ILogger<Index6Model> _logger;

        public Index6Model(ILogger<Index6Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var currentTime = DateTime.Now;

            // Requires SessionExtensions from sample.
            if (HttpContext.Session.Get<DateTime>(SessionKeyTime) == default)
            {
                HttpContext.Session.Set<DateTime>(SessionKeyTime, currentTime);
            }
            _logger.LogInformation("Current Time: {Time}", currentTime);
            _logger.LogInformation("Session Time: {Time}",
            HttpContext.Session.Get<DateTime>(SessionKeyTime));

        }
    }
}
