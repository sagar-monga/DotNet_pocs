using _01WebApi;
using _01WebApi.DbContexts;
using _01WebApi.Interfaces;
using _01WebApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;  // Will return 406 if the format specified in 'Accept' is not supported by our API
})
//! Order is important herer
.AddNewtonsoftJson()
.AddXmlDataContractSerializerFormatters(); //* Registers controllers

builder.Services.AddSingleton<IGreetingService, GreetingService>();
builder.Services.AddSingleton<EmployeeDataStore>();

//* the LocalMailService will be used in this case as it si registered last
// builder.Services.AddTransient<IMailService, CloudMailService>();
// builder.Services.AddTransient<IMailService, LocalMailService>();

//* Another way of registering services based on debug and release config COMPILER DIRECTIVES
// #if DEBUG
// builder.Services.AddTransient<IMailService, LocalMailService>();
// #else
// builder.Services.AddTransient<IMailService, CloudMailService>();
// #endif

builder.Services.AddTransient<IMailService, MailService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); //* Adds Swagger
builder.Services.AddSwaggerGen(); //* Adds Swagger

// Add breakpoint below to check the providers
// var config = builder.Configuration["MailService:from"];

builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer("Server=localhost;Database=dev-01WebApi;Trusted_Connection=True;"));

var app = builder.Build(); //* Builds the App

// Configure the HTTP request pipeline. -- important

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
}

// * Middlewaers added here
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

/* Alternate/older way of registering controllers (MapControllers combines this into one)
    
app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

*/

app.Run();
