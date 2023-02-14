using Microsoft.AspNetCore.Mvc;
using VistaControlador.Datos;
using VistaControlador.Models;


namespace VistaControlador.Controllers
{
    public class CategoriaController : Controller
    {

        private readonly AppDbContext _db;

        public CategoriaController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Categoria> lista = _db.Categoria;

            return View(lista);

        }

        // Get
        public IActionResult Crear()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Categoria categoria)
        {

            _db.Categoria.Add(categoria);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }




    }
}
