namespace AdeptItc.Demo.ViewModels;

/// <summary>
/// View model for IoT Devices.
/// </summary>
public class IotDeviceViewModel
{
  /// <summary>
  /// Gets or sets the identifier.
  /// </summary>
  public Guid Id { get; set; } = Guid.NewGuid();

  /// <summary>
  /// Gets or sets the name of the IoT Device.
  /// </summary>
  [DisplayName(nameof(Name))]
  [Required]
  public string Name { get; set; } = null!;

  /// <summary>
  /// Gets or sets the location of the IoT Device.
  /// </summary>
  [DisplayName(nameof(Location))]
  [Required]
  public string Location { get; set; } = null!;

  /// <summary>
  /// Gets or sets a value indicating whether a IoT Device is open.
  /// </summary>
  [DisplayName("Is open?")]
  [Required]
  public bool IsOpen { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether a IoT Device is locked.
  /// </summary>
  [DisplayName("Is locked?")]
  [Required]
  public bool IsLocked { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether a IoT Device is alarmed.
  /// </summary>
  [DisplayName("Is alarmed?")]
  [Required]
  public bool IsAlarmed { get; set; }
}
