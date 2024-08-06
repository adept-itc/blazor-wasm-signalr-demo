namespace AdeptItc.Demo.Database.Models;

/// <summary>
/// IoT Device model.
/// </summary>
public class IotDeviceModel
{
  /// <summary>
  /// Initializes a new instance of <see cref="IotDeviceModel"/>.
  /// </summary>
  public IotDeviceModel()
  { }

  /// <summary>
  /// Initializes a new instance of <see cref="IotDeviceModel"/>.
  /// </summary>
  /// <param name="name">
  /// The name.
  /// </param>
  /// <param name="location">
  /// The location.
  /// </param>
  /// <param name="isOpen">
  /// Optional: a value indicating whether the IoT Device is open.
  /// </param>
  /// <param name="isLocked">
  /// Optional: a value indicating whether the IoT Device is locked.
  /// </param>
  /// <param name="isAlarmed">
  /// Optional: a value indicating whether the IoT Device is alarmed.
  /// </param>
  public IotDeviceModel(
    string name,
    string location,
    bool isOpen = false,
    bool isLocked = false,
    bool isAlarmed = false)
  {
    this.Name = name;
    this.Location = location;
    this.IsOpen = isOpen;
    this.IsLocked = isLocked;
    this.IsAlarmed = isAlarmed;
  }

  /// <summary>
  /// Gets or sets the identifier.
  /// </summary>
  public Guid Id { get; set; } = Guid.NewGuid();

  /// <summary>
  /// Gets or sets the name of the IoT Device.
  /// </summary>
  public string Name { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the location of the IoT Device.
  /// </summary>
  public string Location { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets a value indicating whether a IoT Device is open.
  /// </summary>
  public bool IsOpen { get; set; } = false;

  /// <summary>
  /// Gets or sets a value indicating whether a IoT Device is locked.
  /// </summary>
  public bool IsLocked { get; set; } = false;

  /// <summary>
  /// Gets or sets a value indicating whether a IoT Device is alarmed.
  /// </summary>
  public bool IsAlarmed { get; set; } = false;
}

