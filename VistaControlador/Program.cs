using Microsoft.EntityFrameworkCore;
using VistaControlador.Datos;     //Importar de nuestro DbContext

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//Inyection de dependencias para enlazar la clase ApplicationDbContext con la cadena cadena de conexion y 
//el conector de SQL Server con
//el nombre de nuestro DbContext, le indicamos que use(Use) la bBD SqlServer
builder.Services.AddDbContext<AppDbContext>(options =>
                              options.UseSqlServer(
                                  builder.Configuration.GetConnectionString("DefaultConnection"))); //Capturamos la cadena de conexión de appsettings.json

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();//Obliga al uso de una dirección segura
app.UseStaticFiles();//Hojas de estilos, archivos JavaScript...

app.UseRouting();

app.UseAuthorization();//Autorizaciones antes del mapeo-Es importante esta configuración

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
