using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// DI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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

app.MapGet("/schedules", ([FromServices] IRawScheduleDataService rawScheduleDataService) => {
    return rawScheduleDataService.GetRawScheduleNoticeOfLeases();
});

app.MapGet("/results", ([FromServices] IParsedScheduleDataService parsedScheduleDataService) => { 
    return parsedScheduleDataService.GetParsedScheduleNoticOfLeases();
});

app.Run();