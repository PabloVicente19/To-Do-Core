using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class Tarea
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion{ get; set; }
        public bool Completada { get; set; }
        public DateTime FechaDeCreacion { get; set; } = DateTime.Now.Date;
    }
}
