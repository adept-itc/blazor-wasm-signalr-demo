namespace AdeptItc.Demo.Database.Contexts.Interfaces;

/// <summary>
/// Contract for the database context.
/// </summary>
public interface IDbContext
{
  /// <summary>
  /// Gets or sets the <see cref="IList{IotDeviceModel}"/>.
  /// </summary>
  IList<IotDeviceModel> IotDevices { get; set; }

  /// <summary>
  /// Saves the changes.
  /// </summary>
  /// <returns>
  /// A <see cref="Task"/>.
  /// </returns>
  Task SaveChangesAsync();
}