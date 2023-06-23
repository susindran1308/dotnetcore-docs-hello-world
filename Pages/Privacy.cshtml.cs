using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnetcoresample.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnGet()
    {
        // Define an array or list of valid HTTP error codes
        int[] validErrorCodes = { 200, 400, 401, 403, 404, 406, 500, 501, 502, 200, 200, 200, 200, 200, 200 };

        // Generate a random index to select a random error code from the array/list
        Random random = new Random();
        int randomIndex = random.Next(validErrorCodes.Length);

        // Get the random error code
        int randomErrorCode = validErrorCodes[randomIndex];

        // Return the error response with the random error code
        return StatusCode(randomErrorCode);
    }
}

