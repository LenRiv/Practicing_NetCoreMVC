using Microsoft.EntityFrameworkCore;
using VistaControlador.Models;




//Agregamos la cadena de conexion de appsettings.json
namespace VistaControlador.Datos
{
    public class AppDbContext : DbContext//Es una de las clases más importantes de Entity-Framework, se una para interactuar con la base de datos elegida,
    {
        //Instanciar en el constructor el modelo, dentro del objeto DbContextOptions(información de configuración-Cadena de Conexión, proveedor de BD...),
        //le decimos el tipo de objeto que estamos implementando<AppDbContex>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //DbSet se implementa para el uso de las entidades de nuestro modelo,
        //En este caso solo es Categoría y que nos devuelva objetos de este tipo.
        //Consultar y guardar instancias(crear objetos a partir de una clase) de Categoria para la consulta de los datos
        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<TipoAplicacion> TipoAplicacion { get; set; }

    }
}