using SoftwareArchitecture.Core.Services;

namespace SoftwareArchitecture.Core.Models;

public class Account
{
    public Account(int id, string fullName, string phoneNumber, DateTime joiningDate, bool isBlocked, string password)
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

    public AuthenticationResponseModel Authenticate()
    {
        return new AuthenticationResponseModel(Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
    }
}