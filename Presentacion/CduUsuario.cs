using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace Presentacion
{
    public partial class CduUsuario : UserControl
    {
        public Tarea Tarea { get; private set; }
        private TareaControler _tareaController;
        public CduUsuario()
        {
            InitializeComponent();
        }

        private Label lblTareaTitulo;
        private Label lblTareaDescripcion;
        private TextBox txtTareaDescripcion;
        private Button btnModificarTarea;
        private Button btnEliminarTarea;
        private TextBox txtTareaTitulo;
        private void InitializeComponent()
        {
            lblTareaTitulo = new Label();
            txtTareaTitulo = new TextBox();
            lblTareaDescripcion = new Label();
            txtTareaDescripcion = new TextBox();
            btnModificarTarea = new Button();
            btnEliminarTarea = new Button();
            SuspendLayout();
            // 
            // lblTareaTitulo
            // 
            lblTareaTitulo.AutoSize = true;
            lblTareaTitulo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblTareaTitulo.ForeColor = Color.WhiteSmoke;
            lblTareaTitulo.Location = new Point(10, 13);
            lblTareaTitulo.Name = "lblTareaTitulo";
            lblTareaTitulo.Size = new Size(42, 17);
            lblTareaTitulo.TabIndex = 0;
            lblTareaTitulo.Text = "Titulo";
            // 
            // txtTareaTitulo
            // 
            txtTareaTitulo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtTareaTitulo.Location = new Point(10, 33);
            txtTareaTitulo.Name = "txtTareaTitulo";
            txtTareaTitulo.Size = new Size(245, 25);
            txtTareaTitulo.TabIndex = 1;
            // 
            // lblTareaDescripcion
            // 
            lblTareaDescripcion.AutoSize = true;
            lblTareaDescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblTareaDescripcion.ForeColor = Color.WhiteSmoke;
            lblTareaDescripcion.Location = new Point(10, 70);
            lblTareaDescripcion.Name = "lblTareaDescripcion";
            lblTareaDescripcion.Size = new Size(77, 17);
            lblTareaDescripcion.TabIndex = 2;
            lblTareaDescripcion.Text = "Descripcion";
            // 
            // txtTareaDescripcion
            // 
            txtTareaDescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtTareaDescripcion.Location = new Point(10, 90);
            txtTareaDescripcion.Multiline = true;
            txtTareaDescripcion.Name = "txtTareaDescripcion";
            txtTareaDescripcion.Size = new Size(245, 102);
            txtTareaDescripcion.TabIndex = 3;
            // 
            // btnModificarTarea
            // 
            btnModificarTarea.BackColor = Color.Gold;
            btnModificarTarea.FlatStyle = FlatStyle.Popup;
            btnModificarTarea.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarTarea.Location = new Point(10, 198);
            btnModificarTarea.Name = "btnModificarTarea";
            btnModificarTarea.Size = new Size(100, 30);
            btnModificarTarea.TabIndex = 4;
            btnModificarTarea.Text = "Modificar";
            btnModificarTarea.UseVisualStyleBackColor = false;
            btnModificarTarea.Click += btnModificarTarea_Click;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.BackColor = Color.IndianRed;
            btnEliminarTarea.FlatStyle = FlatStyle.Popup;
            btnEliminarTarea.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarTarea.Location = new Point(156, 198);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(100, 30);
            btnEliminarTarea.TabIndex = 5;
            btnEliminarTarea.Text = "Eliminar";
            btnEliminarTarea.UseVisualStyleBackColor = false;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // CduUsuario
            // 
            BackColor = Color.FromArgb(74, 74, 74);
            Controls.Add(btnEliminarTarea);
            Controls.Add(btnModificarTarea);
            Controls.Add(txtTareaDescripcion);
            Controls.Add(lblTareaDescripcion);
            Controls.Add(txtTareaTitulo);
            Controls.Add(lblTareaTitulo);
            Name = "CduUsuario";
            Size = new Size(270, 231);
            Load += CduUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        public CduUsuario(Tarea tarea)
        {
            InitializeComponent();
            Tarea = tarea;
            _tareaController = TareaControler.Instance;
        }


        private void CduUsuario_Load(object sender, EventArgs e)
        {
            CargarTarea(Tarea);
        }
        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show($"¿Desea eliminar la siguiente tarea: {Tarea.Titulo}{Environment.NewLine} {Tarea.Descripcion}?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                _tareaController.EliminarTarea(Tarea);
                this.Visible = false;
                this.Dispose();
            }
        }
        private void btnModificarTarea_Click(object sender, EventArgs e)
        {
            ModificarTarea(Tarea);
        }

        private void CargarTarea(Tarea tarea)
        {
            txtTareaTitulo.Text = tarea.Titulo;
            txtTareaDescripcion.Text = tarea.Descripcion;
        }
        private void ModificarTarea(Tarea tarea)
        {
            tarea.Titulo = txtTareaTitulo.Text;
            tarea.Descripcion = txtTareaDescripcion.Text;

            _tareaController.ModificarTarea(tarea);
            CargarTarea(tarea);
        }


    }
}
