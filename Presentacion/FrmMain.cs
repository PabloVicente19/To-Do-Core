using Controlador;
using Modelo;
using System.Threading;

namespace Presentacion
{
    public partial class FrmMain : Form
    {
        private TareaControler _tareaController;
        private List<Tarea>? _listaDeTareas;
        public FrmMain()
        {
            InitializeComponent();
            _tareaController = TareaControler.Instance;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                _listaDeTareas = _tareaController.ObtenerTareas();
                GenerarTarjetasDeTarea(_listaDeTareas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        private void btnGenerarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampoDeTexto(txtTareaTitulo.Text)) return;

                AgregarTarea();
                GenerarTarjetasDeTarea(_listaDeTareas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        #region Funcionalidades
        private bool ValidarCampoDeTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("¡Debe Completar el titulo de la tarea","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else{ 
                return true;
            }
        }
        private void GenerarTarjetasDeTarea(List<Tarea> tareas)
        {
            flpTareas.Controls.Clear();
            foreach (Tarea tarea in tareas)
            {
                CduUsuario cdu = new CduUsuario(tarea);
                flpTareas.Controls.Add(cdu);
            }
        }
        private Tarea CrearTarea()
        {
            Tarea tarea = new Tarea();
            tarea.Titulo = txtTareaTitulo.Text;
            tarea.Descripcion = txtTareaDescripcion.Text;
            tarea.Completada = rbTareaCompletada.Checked ? true : false;
            return tarea;
        }
        private void AgregarTarea()
        {
            Tarea tarea = CrearTarea();
            _tareaController.AgregarTarea(tarea);
            _listaDeTareas.Add(tarea);
            GenerarTarjetasDeTarea(_listaDeTareas);
        }
        #endregion
    }
}
