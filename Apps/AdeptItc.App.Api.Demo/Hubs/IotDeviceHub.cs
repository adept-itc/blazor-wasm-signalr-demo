namespace AdeptItc.App.Api.Demo.Hubs;

/// <summary>
/// The SignalR hub for IoT Devices.
/// </summary>
public class IotDeviceHub : Hub
{
  /// <summary>
  /// The <see cref="IIotDeviceService"/>.
  /// </summary>
  private readonly IIotDeviceService _iotDeviceService;

  /// <summary>
  /// The <see cref="IMapper"/>.
  /// </summary>
  private readonly IMapper _mapper;

  /// <summary>
  /// Initializes a new instance of <see cref="IotDeviceHub"/>.
  /// </summary>
  /// <param name="iotDeviceService">
  /// The <see cref="IIotDeviceService"/>.
  /// </param>
  /// <param name="mapper">
  /// The <see cref="IMapper"/>.
  /// </param>
  public IotDeviceHub(
    IIotDeviceService iotDeviceService,
    IMapper mapper)
  {
    this._iotDeviceService = iotDeviceService;
    this._mapper = mapper;
  }

  /// <summary>
  /// Provides the current IoT Device data.
  /// </summary>
  /// <returns>
  /// The <see cref="Task{IList{IotDeviceModel}}"/>.
  /// </returns>
  public async Task<IList<IotDeviceViewModel>> InitialLoadAsync()
  {
    var iotDeviceModels = (await this._iotDeviceService.GetAllAsync()).ToList();

    var iotDeviceViewModels = this._mapper.Map<IList<IotDeviceViewModel>>(iotDeviceModels);

    return iotDeviceViewModels;
  }

  /// <summary>
  /// Updates the states for a specific IoT Device.
  /// </summary>
  /// <param name="iotDeviceViewModel">
  /// The <see cref="IList{IotDeviceViewModel}"/>.
  /// </param>
  /// <returns>
  /// A <see cref="Task"/>.
  /// </returns>
  public async Task UpdatedAsync(IotDeviceViewModel iotDeviceViewModel)
  {
    var iotDeviceModel = this._mapper.Map<IotDeviceModel>(iotDeviceViewModel);
    
    await this._iotDeviceService.UpdateAsync(iotDeviceModel);

    await this.Clients.All.SendAsync("UpdatedAsync", iotDeviceViewModel);
  }
}
