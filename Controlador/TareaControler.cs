using Modelo;
namespace Controlador
{
    public class TareaControler
    {
        private readonly Modelo.AppContext _context;

        public TareaControler()
        {
            _context = new Modelo.AppContext();
        }

        public List<Tarea> ObtenerTareas()
        {
            return new List<Tarea>();
        }
        public void AgregarTarea(Tarea tarea) 
        {
            _context.Add(tarea);
            _context.SaveChanges();
        }
        public void ModificarTarea(Tarea tarea) 
        {
            _context.Update(tarea);
            _context.SaveChanges();
        }
        public void EliminarTarea(Tarea tarea) 
        {
            _context.Remove(tarea);
            _context.SaveChanges();
        }
    }
}
