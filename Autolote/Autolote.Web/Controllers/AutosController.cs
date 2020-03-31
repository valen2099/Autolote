using Autolote.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autolote.Web.Controllers
{
    public class AutosController : Controller
    {
        // GET: Autos
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult Camion()
        {
            var marcasBL = new MarcasBL();
            var listadeMarcas = marcasBL.ObtenerProductos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];
            return View(listadeMarcas);
        }
        public ActionResult Camioneta()
        {
            var marcasBL = new MarcasBL();
            var listadeMarcas = marcasBL.ObtenerProductos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];
            return View(listadeMarcas);
        }
        public ActionResult Cuatrimoto()
        {
            var marcasBL = new MarcasBL();
            var listadeMarcas = marcasBL.ObtenerProductos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];
            return View(listadeMarcas);
        }
        public ActionResult Lancha()
        {
            var marcasBL = new MarcasBL();
            var listadeMarcas = marcasBL.ObtenerProductos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];
            return View(listadeMarcas);
        }
        public ActionResult Microbus()
        {
            var marcasBL = new MarcasBL();
            var listadeMarcas = marcasBL.ObtenerProductos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];
            return View(listadeMarcas);
        }
        public ActionResult Moto()
        {
            var marcasBL = new MarcasBL();
            var listadeMarcas = marcasBL.ObtenerProductos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];
            return View(listadeMarcas);
        }
        public ActionResult Pickup()
        {
            var marcasBL = new MarcasBL();
            var listadeMarcas = marcasBL.ObtenerProductos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];
            return View(listadeMarcas);
        }
        public ActionResult Turismo()
        {
            var marcasBL = new MarcasBL();
            var listadeMarcas = marcasBL.ObtenerProductos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];
            return View(listadeMarcas);
        }
    }
}