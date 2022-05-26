using SanPatrick.Api.Extensions;
using SanPatrick.Application;
using SanPatrick.Identity;
using SanPatrick.Persistence;
using SanPatrick.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddApplicationServiceExtensions();
builder.Services.AddPersistenceServiceExtensions(builder.Configuration);
builder.Services.AddSharedServicesExtensions();
builder.Services.AddIdentityServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("SanPatrickPolicy", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.UseErrorHandlerMiddleware();
app.UseCors("SanPatrickPolicy");

app.MapControllers();

app.Run();
