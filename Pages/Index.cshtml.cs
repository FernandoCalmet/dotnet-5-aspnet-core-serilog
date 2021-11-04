using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace WebAppSerilog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            {
                _logger.LogInformation("Requested the Index Page");
                int count;
                try
                {
                    for (count = 0; count <= 5; count++)
                    {
                        if (count == 3)
                        {
                            throw new Exception("RandomException");
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Exception Caught");
                }
            }
        }
    }
}
