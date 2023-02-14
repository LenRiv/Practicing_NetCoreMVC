using Microsoft.AspNetCore.Mvc;
using VistaControlador.Datos;
using VistaControlador.Models;


namespace VistaControlador.Controllers
{
    public class TipoAplicacionController : Controller
    {

        private readonly AppDbContext _db;

        public TipoAplicacionController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<TipoAplicacion> lista = _db.TipoAplicacion;

            return View(lista);

        }

        // Get
        public IActionResult Crear()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(TipoAplicacion tipoAplicacion)
        {

            _db.TipoAplicacion.Add(tipoAplicacion);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }




    }
}
