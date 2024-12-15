using Orleans.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.UseOrleans(siloBuilder =>
{
    siloBuilder.UseLocalhostClustering();
    siloBuilder.AddMemoryGrainStorage("Default");
    siloBuilder.Configure<ClusterOptions>(opt =>
    {
        opt.ClusterId = "dev";
        opt.ServiceId = "OrleansBasics";
    });
});
var app = builder.Build();


app.Run();
