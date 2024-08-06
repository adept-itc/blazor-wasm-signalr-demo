namespace AdeptItc.App.Api.Demo.Extensions;

/// <summary>
/// Extension methods for use with <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
  /// <summary>
  /// Configures the CORS policies on <paramref name="serviceCollection"/>.
  /// </summary>
  /// <param name="serviceCollection">
  /// The <see cref="IServiceCollection"/>.
  /// </param>
  /// <returns>
  /// The <see cref="IServiceCollection"/>.
  /// </returns>
  public static IServiceCollection ConfigureCorsPolicies(this IServiceCollection serviceCollection)
  {
    serviceCollection
      .AddCors(_ =>
      {
        _.AddPolicy("ApiPolicy", corsPolicy =>
        {
          corsPolicy.AllowAnyHeader()
            .AllowAnyMethod()
            .SetIsOriginAllowed(host => true)
            .AllowCredentials();
        });
      });

    return serviceCollection;
  }

  /// <summary>
  /// Configures the db contexts on <paramref name="serviceCollection"/>.
  /// </summary>
  /// <param name="serviceCollection">
  /// The <see cref="IServiceCollection"/>.
  /// </param>
  /// <returns>
  /// The <see cref="IServiceCollection"/>.
  /// </returns>
  public static IServiceCollection ConfigureDbContexts(this IServiceCollection serviceCollection)
  {
    serviceCollection.AddSingleton<IDbContext>(new DbContext());

    return serviceCollection;
  }

  /// <summary>
  /// Configures mapping profiles on <paramref name="serviceCollection"/>.
  /// </summary>
  /// <param name="serviceCollection">
  /// The <see cref="IServiceCollection"/>.
  /// </param>
  /// <returns>
  /// The <see cref="IServiceCollection"/>.
  /// </returns>
  public static IServiceCollection ConfigureMappingProfiles(this IServiceCollection serviceCollection)
  {
    serviceCollection
      .AddAutoMapper(typeof(BaseModelMappingProfile).Assembly, typeof(BaseViewModelMappingProfile).Assembly);

    return serviceCollection;
  }

  /// <summary>
  /// Configures the repositories on <paramref name="serviceCollection"/>.
  /// </summary>
  /// <param name="serviceCollection">
  /// The <see cref="IServiceCollection"/>.
  /// </param>
  /// <returns>
  /// The <see cref="IServiceCollection"/>.
  /// </returns>
  public static IServiceCollection ConfigureRepositories(this IServiceCollection serviceCollection)
  {
    serviceCollection.AddScoped<IIotDeviceRepository, IotDeviceRepository>();

    return serviceCollection;
  }

  /// <summary>
  /// Configures the services on <paramref name="serviceCollection"/>.
  /// </summary>
  /// <param name="serviceCollection">
  /// The <see cref="IServiceCollection"/>.
  /// </param>
  /// <returns>
  /// The <see cref="IServiceCollection"/>.
  /// </returns>
  public static IServiceCollection ConfigureServices(this IServiceCollection serviceCollection)
  {
    serviceCollection.AddScoped<IIotDeviceService, IotDeviceService>();

    return serviceCollection;
  }

  /// <summary>
  /// Configures swagger on <paramref name="serviceCollection"/>.
  /// </summary>
  /// <param name="serviceCollection">
  /// The <see cref="IServiceCollection"/>.
  /// </param>
  /// <returns>
  /// The <see cref="IServiceCollection"/>.
  /// </returns>
  public static IServiceCollection ConfigureSwagger(this IServiceCollection serviceCollection)
  {
    serviceCollection
      .AddEndpointsApiExplorer()
      .AddSwaggerGen();

    return serviceCollection;
  }
}
