namespace AdeptItc.Demo.Repositories;

/// <summary>
/// The IoT Device repository.
/// </summary>
public class IotDeviceRepository : IIotDeviceRepository
{
  /// <summary>
  /// The <see cref="IDbContext"/>.
  /// </summary>
  private readonly IDbContext _dbContext;

  /// <summary>
  /// The <see cref="IMapper"/>.
  /// </summary>
  private readonly IMapper _mapper;

  /// <summary>
  /// Initializes a new instance of <see cref="IotDeviceRepository"/>.
  /// </summary>
  /// <param name="dbContext">
  /// The <see cref="IDbContext"/>.
  /// </param>
  /// <param name="mapper">
  /// The <see cref="IMapper"/>.
  /// </param>
  public IotDeviceRepository(
    IDbContext dbContext,
    IMapper mapper)
  {
    this._dbContext = dbContext;
    this._mapper = mapper;
  }

  /// <inheritdoc/>
  public async Task<IQueryable<IotDeviceModel>> GetAllAsync()
    => this._dbContext
      .IotDevices
      .AsQueryable();

  /// <inheritdoc/>
  public async Task<IotDeviceModel?> GetByIdAsync(Guid id)
    => this._dbContext
      .IotDevices
      .FirstOrDefault(_ => _.Id.Equals(id));

  /// <inheritdoc/>
  public async Task UpdateAsync(IotDeviceModel iotDeviceModel)
  {
    if (iotDeviceModel == null)
      throw new Exception($"A {typeof(IotDeviceModel)} was not provided and could not therefore be updated.");

    var existingIotDeviceModel = await this.GetByIdAsync(iotDeviceModel.Id);

    if (existingIotDeviceModel == null)
      throw new Exception($"{iotDeviceModel.GetType()} with id of '{iotDeviceModel.Id}' could not be found and has not been updated.");

    this._mapper.Map(iotDeviceModel, existingIotDeviceModel);

    await this._dbContext.SaveChangesAsync();
  }
}
