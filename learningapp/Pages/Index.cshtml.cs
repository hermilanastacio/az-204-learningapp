using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace learningapp.Pages;

public class IndexModel : PageModel
{
    public string Environment;

    private readonly ILogger<IndexModel> _logger;

    private IConfiguration _configuration;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public void OnGet()
    {
        var config = _configuration.GetSection("Common:Settings");
        string connString = config.GetValue<string>("Environment");
        Environment = connString;
    }
}
