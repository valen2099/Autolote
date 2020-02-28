
using Autolote.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autolote.Web.Controllers
{
    public class MarcasController : Controller
    {
        // GET: Marcas
        public ActionResult Index()
        {

            var marcasBL = new MarcasBL();
            var listadeMarcas = marcasBL.ObtenerProductos(); 

            return View(listadeMarcas);
        }
    }
}