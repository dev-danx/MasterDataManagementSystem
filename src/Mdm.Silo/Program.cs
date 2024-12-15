using Orleans.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseOrleans(static siloBuilder =>
{
    siloBuilder.UseLocalhostClustering();
    siloBuilder.AddMemoryGrainStorage("Elements");
});
var app = builder.Build();


app.Run();
