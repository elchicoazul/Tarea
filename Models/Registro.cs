using System.ComponentModel.DataAnnotations;

namespace Tarea.Models
{
    public class Registro
    {
        [Required]
        [Display(Name="Nombres")]
        public string Nombre { get; set; }

        [Required]
    
        [Display(Name="precios")]
        public int precio { get; set; }

        [Required]
        public string Descripcion { get; set; }
    }
}