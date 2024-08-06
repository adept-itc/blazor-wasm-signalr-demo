var webApplicationBuilder = WebApplication.CreateBuilder(args);

webApplicationBuilder
  .Services
  .ConfigureCorsPolicies()
  .ConfigureDbContexts()
  .ConfigureMappingProfiles()
  .ConfigureRepositories()
  .ConfigureServices()
  .ConfigureSwagger();

webApplicationBuilder.Services.AddSignalR();

var webApplication = webApplicationBuilder.Build();

if (webApplication.Environment.IsDevelopment())
{
  webApplication.UseSwagger();
  webApplication.UseSwaggerUI();
}

webApplication.UseHttpsRedirection();

webApplication.UseCors("ApiPolicy");

webApplication.MapHub<IotDeviceHub>("/iotdevices");

webApplication.Run();
