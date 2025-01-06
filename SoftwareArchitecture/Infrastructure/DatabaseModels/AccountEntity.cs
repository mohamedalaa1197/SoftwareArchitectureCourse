using SoftwareArchitecture.Domain.BussinessModels;

namespace SoftwareArchitecture.Infrastructure.DatabaseModels;

public class AccountEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public AccountEntity MapDbToEntity(Account account)
    {
        return new AccountEntity
        {
            Id = account.Id,
            Name = account.Name
        };
    }
}