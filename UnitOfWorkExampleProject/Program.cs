using CMS.DependencyInjection;

var Configuration = new ConfigurationBuilder()
 .SetBasePath(Directory.GetCurrentDirectory())
 .AddJsonFile("sharedsettings.json", optional: false, reloadOnChange: true)
 .Build();

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
//DapperMapping.AddDapperMappings();
builder.Services.AddControllers();
//builder.Services.AddAutoMapper();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServices();
builder.Services.AddInfrastructure(Configuration);
builder.Services.AddCors();
builder.Services.AddHttpContextAccessor();

#region CORS

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});

#endregion

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
