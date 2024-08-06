namespace AdeptItc.App.UI.Demo.Client.Components;

/// <summary>
/// The IoT Device component.
/// </summary>
public partial class IotDevice
{
  /// <summary>
  /// The <see cref="IotDeviceViewModel"/>.
  /// </summary>
  [Parameter]
  public IotDeviceViewModel Item { get; set; } = null!;

  /// <summary>
  /// Event callback for when the item has changed.
  /// </summary>
  [Parameter]
  public EventCallback<IotDeviceViewModel> ItemChanged { get; set; }

  /// <summary>
  /// Updates <see cref="IotDeviceViewModel.IsOpen"/>
  /// </summary>
  /// <param name="isOpen">
  /// A value indicating whether the IoT Device is open.
  /// </param>
  /// <returns>
  /// A <see cref="Task"/>.
  /// </returns>
  private async Task OnIsOpenChanged(bool isOpen)
  {
    this.Item.IsOpen = isOpen;
    await this.IotDeviceHasBeenUpdated();
  }

  /// <summary>
  /// Updates <see cref="IotDeviceViewModel.IsLocked"/>
  /// </summary>
  /// <param name="isLocked">
  /// A value indicating whether the IoT Devices is locked.
  /// </param>
  /// <returns>
  /// A <see cref="Task"/>.
  /// </returns>
  private async Task OnIsLockedChanged(bool isLocked)
  {
    this.Item.IsLocked = isLocked;
    await this.IotDeviceHasBeenUpdated();
  }

  /// <summary>
  /// Updates <see cref="IotDeviceViewModel.IsAlarmed"/>
  /// </summary>
  /// <param name="isAlarmed">
  /// A value indicating whether the IoT Device is alarmed.
  /// </param>
  /// <returns>
  /// A <see cref="Task"/>.
  /// </returns>
  private async Task OnIsAlarmedChanged(bool isAlarmed)
  {
    this.Item.IsAlarmed = isAlarmed;
    await this.IotDeviceHasBeenUpdated();
  }

  /// <summary>
  /// Fired when the IoT Device has been updated.
  /// </summary>
  /// <returns>
  /// A <see cref="Task"/>.
  /// </returns>
  private async Task IotDeviceHasBeenUpdated()
  {
    await this.ItemChanged.InvokeAsync(this.Item);
    this.StateHasChanged();
  }
}
