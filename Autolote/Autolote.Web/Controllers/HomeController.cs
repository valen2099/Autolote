using Autolote.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autolote.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var marcasBL = new MarcasBL();
            var listadeMarcas = marcasBL.ObtenerProductos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];
            return View(listadeMarcas);
        }
       
    }
}