// i servizi builder vanno SEMPRE prima di builder.Build(), sennò non vanno

using analytics_backend.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


// per collegarsi a sql
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);



// aggiunto CORS (Cross-Origin Resource Sharing)
// di base, i browser impediscono a un sito di prelevare dati da domini diversi da quello di origine
// implementando questo codice, permetto al browser di leggere i dati anche se le origini sono diverse 
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policyBuilder =>
    {
        policyBuilder
        .AllowAnyHeader()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:4200"); // indirizzo di angular
    });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// .Use* vanno SEMPRE prima di .MapControllers
app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//tutto quello che scrivo qua sotto non verrà mai eseguito