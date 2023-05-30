using InventoryService.Configurations;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Configuration.AddConfigServer();
ConfigurationManager configuration = builder.Configuration;
var data = new VaultConfiguration(configuration).GetConfigurations().Result;

Console.WriteLine(data);
SqlConnectionStringBuilder providerCs = new SqlConnectionStringBuilder();
providerCs.InitialCatalog = data["dbname3"].ToString();
providerCs.UserID = data["username"].ToString();
providerCs.Password = data["password"].ToString();
string machineName = data["machineName"].ToString();
string serverName = data["serverName"].ToString();
providerCs.DataSource = $"{machineName}\\{serverName}";//data[""].ToString();
//

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
