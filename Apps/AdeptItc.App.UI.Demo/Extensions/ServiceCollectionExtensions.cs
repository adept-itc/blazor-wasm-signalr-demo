namespace AdeptItc.App.UI.Demo.Extensions;

/// <summary>
/// Extension methods for use with <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
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
      .AddAutoMapper(typeof(BaseViewModelMappingProfile).Assembly);

    return serviceCollection;
  }
}
