using Autolote.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autolote.WebAdmin.Controllers
{
    [Authorize]
    public class MarcasController : Controller
    {
        MarcasBL _marcasBL;
        CategoriasBL _categoriasBL;


        public MarcasController()
        {
            _marcasBL = new MarcasBL();
            _categoriasBL = new CategoriasBL();
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
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId = 
                new SelectList(categorias, "Id", "Descripcion");

            return View (NuevaMarca);
        }


        [HttpPost]
        public ActionResult Crear(Productos producto, HttpPostedFileBase imagen, HttpPostedFileBase imagen2, HttpPostedFileBase imagen3, HttpPostedFileBase imagen4, HttpPostedFileBase imagen5)
        {
            if (ModelState.IsValid)
            {
                if (producto.CategoriaId == 0)
                {
                    ModelState.AddModelError("CategoriaId", "Seleccione una categoria");
                    return View(producto);
                }
                Imagenes(producto, imagen, imagen2, imagen3, imagen4, imagen5);
                _marcasBL.GuardarProducto(producto);
                return RedirectToAction("Index");
            }
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId =
                new SelectList(categorias, "Id", "Descripcion");

            return View(producto);
            
        }

        public ActionResult Editar(int id)
        {
            var producto = _marcasBL.ObtenerProducto(id);
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId =
                new SelectList(categorias, "Id", "Descripcion", producto.CategoriaId);

            return View(producto);
        }

        [HttpPost]

        public ActionResult Editar(Productos producto, HttpPostedFileBase imagen, HttpPostedFileBase imagen2, HttpPostedFileBase imagen3, HttpPostedFileBase imagen4, HttpPostedFileBase imagen5)
        {
            if (ModelState.IsValid)
            {
                if (producto.CategoriaId == 0)
                {
                    ModelState.AddModelError("CategoriaId", "Seleccione una categoria");
                    return View(producto);
                }
                Imagenes(producto, imagen, imagen2, imagen3, imagen4, imagen5);

                _marcasBL.GuardarProducto(producto);


                return RedirectToAction("Index");
            }
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId =
                new SelectList(categorias, "Id", "Descripcion");

            return View(producto);
        }

        public ActionResult Detalle(int id)
        {
            var producto = _marcasBL.ObtenerProducto(id);

            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _marcasBL.ObtenerProducto(id);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Eliminar(Productos producto)
        {
            _marcasBL.EliminarProducto(producto.Id);

            return RedirectToAction("Index");
        }

        private string GuardarImagen(HttpPostedFileBase imagen)
        {
            string path = Server.MapPath("~/Imagenes/" + imagen.FileName);
            imagen.SaveAs(path);

            return "/Imagenes/" + imagen.FileName;
        }

        public void Imagenes(Productos produc, HttpPostedFileBase i1, HttpPostedFileBase i2, HttpPostedFileBase i3, HttpPostedFileBase i4, HttpPostedFileBase i5)
        {
            if (i1 != null)
            {
                produc.UrlImagen = GuardarImagen(i1);
            }
            if (i2 != null)
            {
                produc.UrlImagen2 = GuardarImagen(i2);
            }
            if (i3 != null)
            {
                produc.UrlImagen3 = GuardarImagen(i3);
            }
            if (i4 != null)
            {
                produc.UrlImagen4 = GuardarImagen(i4);
            }
            if (i5 != null)
            {
                produc.UrlImagen5 = GuardarImagen(i5);
            }
        }
    }
}