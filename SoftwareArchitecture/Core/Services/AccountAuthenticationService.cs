using SoftwareArchitecture.Core.InputPort;
using SoftwareArchitecture.Core.Models;
using SoftwareArchitecture.Core.OutputPort;

namespace SoftwareArchitecture.Core.Services;

public class AccountAuthenticationService : IAccountAuthenticationPort
{
    private readonly IAccountRepository _accountRepository;
    private readonly ILoggerService<AccountAuthenticationService> _loggerService;

    public AccountAuthenticationService(IAccountRepository accountRepository, ILoggerService<AccountAuthenticationService> loggerService)
    {
        _accountRepository = accountRepository;
        _loggerService = loggerService;
    }

    public AuthenticationResponseModel Authenticate(AuthenticationRequest authenticationRequest)
    {
        _loggerService.LogInfo("Authenticating account with phone number: " + authenticationRequest.PhoneNumber);
        var account = ExistingAccountOrNewAccount(authenticationRequest.PhoneNumber, authenticationRequest.Password);
        return account.Authenticate();
    }

    private Account ExistingAccountOrNewAccount(string phoneNumber, string password)
    {
        _loggerService.LogInfo("Checking if account exists for phone number: " + phoneNumber);
        var existingAccount = _accountRepository.GetAccountByPhone(phoneNumber);
        if (existingAccount != null)
        {
            return existingAccount;
        }

        var newAccount = new Account(0, phoneNumber, phoneNumber, DateTime.Now, false, password);
        _accountRepository.AddAccount(newAccount);
        return newAccount;
    }
}