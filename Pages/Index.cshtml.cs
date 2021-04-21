using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Shyjus.BrowserDetection;

namespace Middleware.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBrowserDetector _browserDetector;

        public IndexModel(ILogger<IndexModel> logger, IBrowserDetector browserDetector)
        {
            _logger = logger;
            _browserDetector = browserDetector;
        }

        public void OnGet()
        {
            var browser = _browserDetector.Browser;
        }
    }
}
