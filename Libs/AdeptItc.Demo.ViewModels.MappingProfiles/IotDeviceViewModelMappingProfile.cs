namespace AdeptItc.Demo.ViewModels.MappingProfiles;

/// <summary>
/// The mapping profile for <see cref="IotDeviceViewModel"/>.
/// </summary>
public class IotDeviceViewModelMappingProfile : BaseViewModelMappingProfile
{
  /// <summary>
  /// Initializes a new instance of <see cref="IotDeviceViewModelMappingProfile"/>.
  /// </summary>
  public IotDeviceViewModelMappingProfile()
  {
    this.CreateMap<IotDeviceViewModel, IotDeviceModel>();
    this.CreateMap<IotDeviceModel, IotDeviceViewModel>();
  }
}
