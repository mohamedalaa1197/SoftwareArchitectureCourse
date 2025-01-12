using SoftwareArchitecture.Core.Models;

namespace SoftwareArchitecture.Shell.DBEntities;

public class DeviceEntity
{
    public int Id { get; set; }
    public Guid DeviceToken { get; set; }

    public Device toModel()
    {
        return new Device
        {
            Id = this.Id,
            DeviceToken = this.DeviceToken
        };
    }


    public static DeviceEntity toEntity(Device device)
    {
        return new DeviceEntity
        {
            Id = device.Id,
            DeviceToken = device.DeviceToken
        };
    }
}