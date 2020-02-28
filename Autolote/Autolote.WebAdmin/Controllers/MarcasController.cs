using Autolote.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autolote.WebAdmin.Controllers
{
    public class MarcasController : Controller
    {


        MarcasBL _marcasBL;


        public MarcasController()
        {
            _marcasBL = new MarcasBL();
        }

        // GET: Marcas
        public ActionResult Index()
        {

            var listadeMarcas = _marcasBL.ObtenerProductos();
                        
            return View(listadeMarcas);
        }

        [HttpGet]
        public ActionResult Crear()
        {
            var NuevaMarca = new Productos();

            return View (NuevaMarca);
        }


        [HttpPost]
        public ActionResult Crear(Productos producto)
        {

            _marcasBL.GuardarProducto(producto);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var producto = _marcasBL.ObtenerProducto(id);
            return View(producto);
        }

        [HttpPost]

        public ActionResult Editar(Productos producto)
        {
            _marcasBL.GuardarProducto(producto);
            return RedirectToAction("index");
        }
    }
}