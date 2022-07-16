using BookingAppDio.Passenger;
using BookingAppDio.Passenger.Data.Context;
using BookingAppDio.Bus;
using BookingAppDio.Core.Generator;
using BookingAppDio.Core.Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddDbContext<PassengerDbContext>(options =>
                    options.UseNpgsql(
                          configuration.GetConnectionString("DefaultConnection"),
                         x => x.MigrationsAssembly(typeof(PassengerDbContext).Assembly.GetName().Name)));

builder.Services.AddMediatR(typeof(PassengerRoot).Assembly);
builder.Services.AddCustomMapster(typeof(PassengerRoot).Assembly);
builder.Services.AddCustomMassTransit(configuration, typeof(PassengerRoot).Assembly);

SnowFlakeIdGenerator.Configure(2);

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
