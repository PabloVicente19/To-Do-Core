using Microsoft.EntityFrameworkCore;
using Modelo;
namespace Controlador
{
    public class TareaControler
    {
        private static TareaControler _instancia;
        private static readonly object _Lock = new Object();

        private TareaControler()
        {
        }
        public static TareaControler Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_instancia == null)
                    {
                        _instancia = new TareaControler();
                    }
                    return _instancia;
                }
            }
        }

        public List<Tarea> ObtenerTareas()
        {
            using (var contexto = new Modelo.AppContext())
            {
                return contexto.Tarea.ToList();
            }
        }
        public Tarea BuscarTarea(int Id)
        {
            using (var contexto = new Modelo.AppContext())
            {
                return contexto.Tarea.First(tarea => tarea.Id == Id);
            }
        }
        public void AgregarTarea(Tarea tarea)
        {
            using (var contexto = new Modelo.AppContext())
            {

                contexto.Tarea.Add(tarea);
                contexto.SaveChanges();
            }
        }
        public void ModificarTarea(Tarea tarea)
        {
            using (var contexto = new Modelo.AppContext())
            {

                contexto.Tarea.Update(tarea);
                contexto.SaveChanges();
            }
        }
        public void EliminarTarea(Tarea tarea)
        {
            using (var contexto = new Modelo.AppContext())
            {
                var tareaSeleccionada = BuscarTarea(tarea.Id);
                if (tareaSeleccionada != null)
                {
                    contexto.Tarea.Remove(tareaSeleccionada);
                    contexto.SaveChanges();
                }
            }
        }
    }
}

