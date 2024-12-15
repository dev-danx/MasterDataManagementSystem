using FastEndpoints;
using Orleans.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOrleansClient(cfg =>
{
    cfg.UseLocalhostClustering();
    cfg.Configure<ClusterOptions>(opt =>
    {
        opt.ClusterId = "dev";
        opt.ServiceId = "OrleansBasics";
    });
});
builder.Services.AddFastEndpoints();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseFastEndpoints();

app.Run();
