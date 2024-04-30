using Api.DependencyInjection;
using Api.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
//c =>
//{
//    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
//    {
//        Name = "Authorization",
//        Type = SecuritySchemeType.ApiKey,
//        Scheme = "Bearer",
//        BearerFormat = "JWT",
//        In = ParameterLocation.Header,
//        Description = "Description"
//    });

//    c.AddSecurityRequirement(new OpenApiSecurityRequirement
//            {
//                {
//                    new OpenApiSecurityScheme
//                    {
//                        Reference = new OpenApiReference
//                        {
//                            Type = ReferenceType.SecurityScheme,
//                            Id = "Bearer"
//                        }
//                    },
//                    new string[] {}
//                }
//            });
//}
);
builder.Services.AddControllers();

builder.Services.AddDependencyInjection(builder.Configuration);

builder.Services.AddSingleton(_ =>
{
    DefaultTypeMap.MatchNamesWithUnderscores = true;
    return new NpgsqlDataSourceBuilder(builder.Configuration.GetSection("ConnectionStrings:Postgres").Value!);
});

builder.Services.AddSingleton<IConnectionProvider, ConnectionProvider>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.UseStatusCodePages();

app.UseHttpsRedirection();

app.Run();