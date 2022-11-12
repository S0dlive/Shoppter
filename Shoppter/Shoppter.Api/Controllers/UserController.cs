using Microsoft.AspNetCore.Mvc;

namespace Shoppter.Api.Controllers;

[Route("api/v1/user")]
public class UserController : Controller
{
    [HttpGet("information")]
    public async Task<IActionResult> GetUserInformationAsync()
    {
        throw new NotImplementedException();
    }

    [HttpGet("conversation/")]
    public async Task<IActionResult> GetUserConversationAsync()
    {
        throw new NotImplementedException();
    }

    [HttpGet("conversation/{id}")]
    public async Task<IActionResult> GetSpecificConversationMessageAsync(string id)
    {
        throw new NotImplementedException();
    }

    [HttpPost("conversation/{id}")]
    public async Task<IActionResult> PostMessageInAConversationAsync(string id, [FromBody] object messageNotImplemented)
    {
        throw new NotImplementedException();
    }
}