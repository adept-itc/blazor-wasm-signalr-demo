namespace AdeptItc.Demo.Database.Contexts;

/// <summary>
/// The database context.
/// </summary>
public class DbContext : IDbContext
{
  /// <inheritdoc/>
  public IList<IotDeviceModel> IotDevices { get; set; } = new List<IotDeviceModel>()
  {
    new(name: "IoT Device 1", "Entrance hall door", isOpen: true),
    new(name: "IoT Device 2", "Lobby door"),
    new(name: "IoT Device 3", "Control room door", isOpen: false, isLocked: true, isAlarmed: true),
    new(name: "IoT Device 4", "Staff room door", isOpen: true),
    new(name: "IoT Device 5", "VIP area door", isOpen: false, isLocked: true, isAlarmed: true),
  };

  /// <inheritdoc/>
  public Task SaveChangesAsync()
  {
    // Largely empty for the purposes of the test. This would usually perform a transactional
    // update to the database, handling rollbacks as needed.

    return Task.CompletedTask;
  }
}
