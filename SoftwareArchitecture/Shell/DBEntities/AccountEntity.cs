using SoftwareArchitecture.Core.Models;

namespace SoftwareArchitecture.Shell.DBEntities;

public class AccountEntity
{
    public AccountEntity(int id, string fullName, string phoneNumber, DateTime joiningDate, bool isBlocked, string password)
    {
        Id = id;
        FullName = fullName;
        PhoneNumber = phoneNumber;
        JoiningDate = joiningDate;
        IsBlocked = isBlocked;
        Password = password;
    }


    public int Id { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime JoiningDate { get; set; }
    public bool IsBlocked { get; set; }
    public string Password { get; set; }

    public Account toModel()
    {
        return new Account(this.Id, this.FullName, this.PhoneNumber, this.JoiningDate, this.IsBlocked, this.Password);
    }

    public static AccountEntity toEntity(Account account)
    {
        return new AccountEntity(account.Id, account.FullName, account.PhoneNumber, account.JoiningDate, account.IsBlocked, account.Password);
    }
}