using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SessionStorage
{
    public class IndexModel : PageModel
    {
        public const bool check = false;
        public const string SessionKeyName = "_Name";
        public const string hashedPassword = "_password";

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            HttpContext.Session.SetString("test", "test");

        }
    }
}
