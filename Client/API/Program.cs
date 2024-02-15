



using API.EF;
using API.Model;
using API.Service;
using System.ComponentModel.Design;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbContextCat>(opt => 
opt.UseInMemoryDatabase("Commande"));


var app = builder.Build();
app.Logger.LogInformation("The app started");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



//ClientService clientService = new ClientService();
//app.MapGet("/All",  () => clientService.All());


app.MapGet("/all", async (DbContextCat db) => await db.Clients.ToListAsync());

app.MapGet("/client/Credit", async (DbContextCat db) => await db.Clients.Where(t => t.EstCredit).ToListAsync());


app.MapGet("/client/{id}", async (int id, DbContextCat db) =>
    await  db.Clients.FindAsync(id)
        is Client dto ? Results.Ok(dto) : Results.NotFound());

app.MapPost("/add", async (Client model, DbContextCat db) =>
{
    db.Clients.Add(model);
    await db.SaveChangesAsync();
    return Results.Created($"/client/{model.Id}", model);
});


app.MapPut("/chnagesolde/{id}", async (int id, decimal nouveauSolde, DbContextCat db) =>
{
    var cmd = await db.Clients.FindAsync(id);

    if (cmd is null) return Results.NotFound();

    cmd.Solde = nouveauSolde;

    await db.SaveChangesAsync();

    return Results.NoContent();
});




app.MapDelete("/delete/{id}", async (int id, DbContextCat db) =>
{
    if (await db.Clients.FindAsync(id) is Client cmd)
    {
        db.Clients.Remove(cmd);
        await db.SaveChangesAsync();
        return Results.Ok(cmd);
    }

    return Results.NotFound();
});


//var summaries = new[]
//{
//    "Freezing", "Bracing", "Chilly", "Cool", 
//    "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//};

//app.MapGet("/weatherforecast", () =>
//{
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//        new WeatherForecast
//        (
//            DateTime.Now.AddDays(index),
//            Random.Shared.Next(-20, 55),
//            summaries[Random.Shared.Next(summaries.Length)]
//        ))
//        .ToArray();
//    return forecast;
//})
//.WithName("GetWeatherForecast");

app.Run();

//internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
//{
//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}