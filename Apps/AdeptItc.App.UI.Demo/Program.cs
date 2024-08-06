var webApplicationBuilder = WebApplication.CreateBuilder(args);

// Add services to the container.
webApplicationBuilder.Services.AddRazorComponents()
  .AddInteractiveServerComponents()
  .AddInteractiveWebAssemblyComponents();

webApplicationBuilder
  .Services
  .ConfigureMappingProfiles();

var webApplication = webApplicationBuilder.Build();

// Configure the HTTP request pipeline.
if (webApplication.Environment.IsDevelopment())
{
  webApplication.UseWebAssemblyDebugging();
}
else
{
  webApplication.UseExceptionHandler("/Error", createScopeForErrors: true);
  webApplication.UseHsts();
}

webApplication.UseHttpsRedirection();

webApplication.UseStaticFiles();
webApplication.UseAntiforgery();

webApplication.MapRazorComponents<App>()
  .AddInteractiveServerRenderMode()
  .AddInteractiveWebAssemblyRenderMode()
  .AddAdditionalAssemblies(typeof(AdeptItc.App.UI.Demo.Client._Imports).Assembly);

webApplication.Run();
