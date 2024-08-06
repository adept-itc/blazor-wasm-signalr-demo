namespace AdeptItc.Demo.Services.Interfaces;

/// <summary>
/// Contract for IoT Device services.
/// </summary>
public interface IIotDeviceService
{
  /// <summary>
  /// Gets all of the <see cref="IotDeviceModel"/>s.
  /// </summary>
  /// <returns>
  /// The <see cref="Task{IQueryable{IotDeviceModel}}"/>.
  /// </returns>
  Task<IQueryable<IotDeviceModel>> GetAllAsync();

  /// <summary>
  /// Gets the <see cref="IotDeviceModel"/> by <paramref name="id"/>.
  /// </summary>
  /// <param name="id">
  /// The identifier.
  /// </param>
  /// <returns>
  /// The <see cref="Task{IotDeviceModel?}"/>.
  /// </returns>
  Task<IotDeviceModel?> GetByIdAsync(Guid id);

  /// <summary>
  /// Updates the <paramref name="iotDeviceModel"/> in the data store.
  /// </summary>
  /// <param name="iotDeviceModel">
  /// The <see cref="IotDeviceModel"/>.
  /// </param>
  /// <returns>
  /// A <see cref="Task"/>.
  /// </returns>
  Task UpdateAsync(IotDeviceModel iotDeviceModel);
}
