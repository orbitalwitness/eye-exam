using EyeExamApi.Implementations;
using EyeExamApi.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// DI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthentication("basic")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthHandler>("basic", null);
builder.Services.AddAuthorization();
builder.Services.AddSwaggerGen(o =>
{
    o.SwaggerDoc("v1", new OpenApiInfo { Title = "BasicAuth", Version = "v1" });
    o.AddSecurityDefinition("basic", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "basic",
        In = ParameterLocation.Header,
        Description = "Basic Authorization header."
    });
    o.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "basic"
                    }
                },
                new string[] {}
        }
    });
});

builder.Services.AddScoped<IRawScheduleDataService, RawScheduleDataService>();
builder.Services.AddScoped<IParsedScheduleDataService, ParsedScheduleDataService>();

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

app.MapGet("/schedules", [Authorize] ([FromServices] IRawScheduleDataService rawScheduleDataService) => {
    return rawScheduleDataService.GetRawScheduleNoticeOfLeases();
});

app.MapGet("/results", [Authorize] ([FromServices] IParsedScheduleDataService parsedScheduleDataService) => { 
    return parsedScheduleDataService.GetParsedScheduleNoticeOfLeases();
});

app.Run();
