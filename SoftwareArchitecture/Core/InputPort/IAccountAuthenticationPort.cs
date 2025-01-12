using SoftwareArchitecture.Core.Services;

namespace SoftwareArchitecture.Core.InputPort;

public interface IAccountAuthenticationPort
{
    AuthenticationResponseModel Authenticate(AuthenticationRequest authenticationRequest);
}