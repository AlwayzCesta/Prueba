using ApiMid.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Esta línea está registrando la clase MidleService en el contenedor de inyección de dependencias con la interfaz IMidleService.
// Esto significa que cuando un componente solicita IMidleService, el contenedor proporcionará una instancia de MidleService.
// AddScoped significa que se creará una nueva instancia de MidleService para cada solicitud HTTP.
builder.Services.AddScoped<IMidleService , MidleService>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    //Utilizamos swagger para documentar la API
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
