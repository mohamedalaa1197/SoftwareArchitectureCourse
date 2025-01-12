using SoftwareArchitecture.Core.Models;
using SoftwareArchitecture.Core.OutputPort;
using SoftwareArchitecture.Shell.DBEntities;

namespace SoftwareArchitecture.Shell.Repositories;

public class InMemoryRepository : IAccountRepository
{
    List<AccountEntity> _inMemoryAccounts =
    [
        new(1, "Mohamed Alaa", "0112788444", DateTime.Now, false, "123456"),
        new(2, "Ahmed Mohamed", "0112788444", DateTime.Now, false, "123456"),
        new(3, "Ali Ahmed", "0112788444", DateTime.Now, false, "123456"),
    ];


    public Account GetAccountByPhone(string phoneNumber)
    {
        var accountEntity = _inMemoryAccounts.FirstOrDefault(account => account.PhoneNumber == phoneNumber);
        if (accountEntity is null)
        {
            throw new Exception("Account not found");
        }

        return accountEntity.toModel();
    }

    public Account GetAccountById(int id)
    {
        var accountEntity = _inMemoryAccounts.FirstOrDefault(account => account.Id == id);
        if (accountEntity is null)
        {
            throw new Exception("Account not found");
        }

        return accountEntity.toModel();
    }

    public void AddAccount(Account account)
    {
        var accountEntity = AccountEntity.toEntity(account);
        _inMemoryAccounts.Add(accountEntity);
    }
}