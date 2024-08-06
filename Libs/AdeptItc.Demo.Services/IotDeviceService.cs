namespace AdeptItc.Demo.Services;

/// <summary>
/// The IoT Device service.
/// </summary>
public class IotDeviceService : IIotDeviceService
{
  /// <summary>
  /// The <see cref="IIotDeviceRepository"/>.
  /// </summary>
  private readonly IIotDeviceRepository _iotDeviceRepository;

  /// <summary>
  /// Initializes a new instance of <see cref="IotDeviceService"/>.
  /// </summary>
  /// <param name="iotDevicesRepository">
  /// The <see cref="IIotDeviceRepository"/>.
  /// </param>
  public IotDeviceService(IIotDeviceRepository iotDeviceRepository)
    => this._iotDeviceRepository = iotDeviceRepository;

  /// <inheritdoc/>
  public async Task<IQueryable<IotDeviceModel>> GetAllAsync()
    => await this._iotDeviceRepository.GetAllAsync();

  /// <inheritdoc/>
  public async Task<IotDeviceModel?> GetByIdAsync(Guid id)
    => await this._iotDeviceRepository.GetByIdAsync(id);

  /// <inheritdoc/>
  public async Task UpdateAsync(IotDeviceModel iotDeviceModel)
    => await this._iotDeviceRepository.UpdateAsync(iotDeviceModel);
}
