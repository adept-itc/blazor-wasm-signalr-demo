namespace AdeptItc.App.UI.Demo.Client.Pages;

/// <summary>
/// The home page.
/// </summary>
public partial class Home
{
  /// <summary>
  /// The <see cref="HubConnection?"/>.
  /// </summary>
  private HubConnection? _hubConnection;

  /// <summary>
  /// The <see cref="IList{IotDeviceViewModel}"/>.
  /// </summary>
  private IList<IotDeviceViewModel> _iotDeviceViewModels = new List<IotDeviceViewModel>();

  /// <inheritdoc />
  protected override async Task OnInitializedAsync()
  {
    this._hubConnection = new HubConnectionBuilder()
      .WithUrl("https://localhost:7031/iotdevices")
      .Build();

    this._hubConnection.On("UpdatedAsync", (IotDeviceViewModel iotDeviceViewModel) =>
    {
      var existingIotDeviceViewModel = this._iotDeviceViewModels.FirstOrDefault(_ => _.Id.Equals(iotDeviceViewModel.Id));

      if (existingIotDeviceViewModel == null)
        return;

      existingIotDeviceViewModel.IsOpen = iotDeviceViewModel.IsOpen;
      existingIotDeviceViewModel.IsLocked = iotDeviceViewModel.IsLocked;
      existingIotDeviceViewModel.IsAlarmed = iotDeviceViewModel.IsAlarmed;

      this.InvokeAsync(this.StateHasChanged);
    });

    await this._hubConnection.StartAsync();

    this._iotDeviceViewModels = await this._hubConnection.InvokeAsync<IList<IotDeviceViewModel>>("InitialLoadAsync");
  }

  /// <summary>
  /// Handles the IoT Device changed event.
  /// </summary>
  /// <param name="iotDeviceViewModel">
  /// The <see cref="IotDeviceViewModel"/>.
  /// </param>
  private void OnIotDeviceChanged(IotDeviceViewModel iotDeviceViewModel)
  {
    if (this._hubConnection == null)
      return;

    this._hubConnection.SendAsync("UpdatedAsync", iotDeviceViewModel).Wait();
    this.StateHasChanged();
  }

  /// <summary>
  /// Disposes of resources.
  /// </summary>
  /// <returns>
  /// A <see cref="ValueTask"/>.
  /// </returns>
  public async ValueTask DisposeAsync()
  {
    if (this._hubConnection != null)
      await this._hubConnection.DisposeAsync();
  }
}
