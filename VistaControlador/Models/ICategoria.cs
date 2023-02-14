namespace VistaControlador.Models
{
    public interface ICategoria
    {
        int Id { get; set; }
        string NombreCategoria { get; set; }
        int MostrarOrden { get; set; }
    }
}
