using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autolote.BL
{
    public class Productos
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ingrese la Marca")]
        [MinLength(2, ErrorMessage ="Ingrese minimo 2 caracteres")] 
        public string Marca { get; set; }

        [Required(ErrorMessage = "Ingrese la Marca")]
        [MinLength(2, ErrorMessage = "Ingrese minimo 2 caracteres")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Ingrese la Año")]
        public int Año { get; set; }

        [Required(ErrorMessage = "Ingrese la Año")]
        [Range(0, 1000000, ErrorMessage = "Ingrese un precio entre 0 y 1000000")]
        public double Precio { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }
    }
}
