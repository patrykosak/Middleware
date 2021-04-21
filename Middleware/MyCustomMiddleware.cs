using Microsoft.AspNetCore.Http;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware.Middleware
{
    public class MyCustomMiddleware
    {
        private RequestDelegate next;

        public MyCustomMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext,
                                      IBrowserDetector detector)
        {
            var browser = detector.Browser;

            if (browser.Name == BrowserNames.Edge||browser.Name==BrowserNames.EdgeChromium||browser.Name==BrowserNames.InternetExplorer)
            {
                await httpContext.Response
                      .WriteAsync("Przegladarka nie jest obslugiwana");
            }
                await next.Invoke(httpContext);
        }
    }
}