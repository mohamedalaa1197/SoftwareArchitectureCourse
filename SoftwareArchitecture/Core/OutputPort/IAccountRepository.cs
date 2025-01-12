using SoftwareArchitecture.Core.Models;

namespace SoftwareArchitecture.Core.OutputPort;

public interface IAccountRepository
{
    Account GetAccountByPhone(string phoneNumber);
    Account GetAccountById(int id);
    void AddAccount(Account account);
}