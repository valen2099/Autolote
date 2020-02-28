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

            listadeProductos = _contexto.Productos.ToList();
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
            }
            _contexto.SaveChanges();

        }

        public Productos ObtenerProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);

            return producto;
        }
    }
}
