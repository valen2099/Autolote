using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autolote.BL
{
    public class MarcasBL
    {
        Contexto _contexto;
        public List<Productos> listadeProductos { get; set; }

        public MarcasBL()
        {
            _contexto = new Contexto();
            listadeProductos = new List<Productos>();
        }
        public List<Productos> ObtenerProductos()
        {

            listadeProductos = _contexto.Productos
                .Include("Categoria")
                .OrderBy(r => r.Categoria.Descripcion)
                .ThenBy(r => r.Marca)
                .ToList();
            return listadeProductos;
        }

        public void GuardarProducto (Productos producto)
        {
            if(producto.Id == 0)
            {
                _contexto.Productos.Add(producto);

            }
            else
            {
                var productoExistente = _contexto.Productos.Find(producto.Id);

                productoExistente.Marca = producto.Marca;
                productoExistente.Modelo = producto.Modelo;
                productoExistente.Precio = producto.Precio;
                GuardarImagenes(producto);
                    
            }
            _contexto.SaveChanges();

        }
        public void GuardarImagenes(Productos producto)
        {
            var productoExistente = _contexto.Productos.Find(producto.Id);

            if (producto.UrlImagen != null)
            {
                productoExistente.UrlImagen = producto.UrlImagen;
            }
            if (producto.UrlImagen2 != null)
            {
                productoExistente.UrlImagen2 = producto.UrlImagen2;
            }
            if (producto.UrlImagen3 != null)
            {
                productoExistente.UrlImagen3 = producto.UrlImagen3;
            }
            if (producto.UrlImagen4 != null)
            {
                productoExistente.UrlImagen4 = producto.UrlImagen4;
            }
            if (producto.UrlImagen5 != null)
            {
                productoExistente.UrlImagen5 = producto.UrlImagen5;
            }
        }

        public Productos ObtenerProducto(int id)
        {
            var producto = _contexto.Productos
                .Include("Categoria").FirstOrDefault(p => p.Id == id);

            return producto;
        }

        public void EliminarProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);

            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
        }

    }
}
