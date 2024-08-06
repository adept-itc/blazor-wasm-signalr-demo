namespace AdeptItc.Demo.Database.Models.MappingProfiles;

/// <summary>
/// The mapping profile for <see cref="IotDeviceModel"/>.
/// </summary>
public class IotDeviceModelMappingProfile : BaseModelMappingProfile
{
  /// <summary>
  /// Initializes a new instance of <see cref="IotDeviceModelMappingProfile"/>.
  /// </summary>
  public IotDeviceModelMappingProfile()
  {
    this.CreateMap<IotDeviceModel, IotDeviceModel>();
  }
}
