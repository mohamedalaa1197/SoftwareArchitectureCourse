using Microsoft.AspNetCore.Mvc;
using SoftwareArchitecture.Core.InputPort;
using SoftwareArchitecture.Core.Services;

namespace SoftwareArchitecture.Shell.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly IAccountAuthenticationPort _accountAuthenticationPort;

    public AuthenticationController(IAccountAuthenticationPort accountAuthenticationPort)
    {
        _accountAuthenticationPort = accountAuthenticationPort;
    }

    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody] AuthenticationRequest request)
    {
        var response = _accountAuthenticationPort.Authenticate(request);
        return Ok(response);
    }
}