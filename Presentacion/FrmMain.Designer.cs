namespace Presentacion
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelFormTareaContenedor = new Panel();
            btnGenerarTarea = new Button();
            rbTareaCompletada = new RadioButton();
            rbTareaIncompleta = new RadioButton();
            txtTareaDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtTareaTitulo = new TextBox();
            lblTitulo = new Label();
            flpTareas = new FlowLayoutPanel();
            panelFormTareaContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panelFormTareaContenedor
            // 
            panelFormTareaContenedor.BackColor = Color.Transparent;
            panelFormTareaContenedor.BorderStyle = BorderStyle.FixedSingle;
            panelFormTareaContenedor.Controls.Add(btnGenerarTarea);
            panelFormTareaContenedor.Controls.Add(rbTareaCompletada);
            panelFormTareaContenedor.Controls.Add(rbTareaIncompleta);
            panelFormTareaContenedor.Controls.Add(txtTareaDescripcion);
            panelFormTareaContenedor.Controls.Add(lblDescripcion);
            panelFormTareaContenedor.Controls.Add(txtTareaTitulo);
            panelFormTareaContenedor.Controls.Add(lblTitulo);
            panelFormTareaContenedor.Dock = DockStyle.Left;
            panelFormTareaContenedor.Location = new Point(0, 0);
            panelFormTareaContenedor.Name = "panelFormTareaContenedor";
            panelFormTareaContenedor.Size = new Size(300, 561);
            panelFormTareaContenedor.TabIndex = 0;
            // 
            // btnGenerarTarea
            // 
            btnGenerarTarea.BackColor = Color.LightSkyBlue;
            btnGenerarTarea.FlatStyle = FlatStyle.Popup;
            btnGenerarTarea.Location = new Point(21, 256);
            btnGenerarTarea.Name = "btnGenerarTarea";
            btnGenerarTarea.Size = new Size(237, 32);
            btnGenerarTarea.TabIndex = 6;
            btnGenerarTarea.Text = "Generar Tarea";
            btnGenerarTarea.UseVisualStyleBackColor = false;
            btnGenerarTarea.Click += btnGenerarTarea_Click;
            // 
            // rbTareaCompletada
            // 
            rbTareaCompletada.AutoSize = true;
            rbTareaCompletada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rbTareaCompletada.ForeColor = Color.WhiteSmoke;
            rbTareaCompletada.Location = new Point(159, 212);
            rbTareaCompletada.Name = "rbTareaCompletada";
            rbTareaCompletada.Size = new Size(99, 21);
            rbTareaCompletada.TabIndex = 5;
            rbTareaCompletada.Text = "Completada";
            rbTareaCompletada.UseVisualStyleBackColor = true;
            // 
            // rbTareaIncompleta
            // 
            rbTareaIncompleta.AutoSize = true;
            rbTareaIncompleta.Checked = true;
            rbTareaIncompleta.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rbTareaIncompleta.ForeColor = Color.WhiteSmoke;
            rbTareaIncompleta.Location = new Point(21, 212);
            rbTareaIncompleta.Name = "rbTareaIncompleta";
            rbTareaIncompleta.Size = new Size(94, 21);
            rbTareaIncompleta.TabIndex = 4;
            rbTareaIncompleta.TabStop = true;
            rbTareaIncompleta.Text = "Incompleta";
            rbTareaIncompleta.UseVisualStyleBackColor = true;
            // 
            // txtTareaDescripcion
            // 
            txtTareaDescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtTareaDescripcion.Location = new Point(12, 94);
            txtTareaDescripcion.Multiline = true;
            txtTareaDescripcion.Name = "txtTareaDescripcion";
            txtTareaDescripcion.Size = new Size(262, 99);
            txtTareaDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.WhiteSmoke;
            lblDescripcion.Location = new Point(12, 76);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 17);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción";
            // 
            // txtTareaTitulo
            // 
            txtTareaTitulo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtTareaTitulo.Location = new Point(12, 41);
            txtTareaTitulo.Name = "txtTareaTitulo";
            txtTareaTitulo.Size = new Size(262, 25);
            txtTareaTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(12, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(42, 17);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // flpTareas
            // 
            flpTareas.AutoScroll = true;
            flpTareas.AutoSize = true;
            flpTareas.BackColor = Color.Transparent;
            flpTareas.BorderStyle = BorderStyle.Fixed3D;
            flpTareas.Dock = DockStyle.Fill;
            flpTareas.Location = new Point(300, 0);
            flpTareas.Name = "flpTareas";
            flpTareas.Size = new Size(884, 561);
            flpTareas.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1184, 561);
            Controls.Add(flpTareas);
            Controls.Add(panelFormTareaContenedor);
            Name = "FrmMain";
            Text = "Form1";
            Load += FrmMain_Load;
            panelFormTareaContenedor.ResumeLayout(false);
            panelFormTareaContenedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFormTareaContenedor;
        private FlowLayoutPanel flpTareas;
        private RadioButton rbTareaCompletada;
        private RadioButton rbTareaIncompleta;
        private TextBox txtTareaDescripcion;
        private Label lblDescripcion;
        private TextBox txtTareaTitulo;
        private Label lblTitulo;
        private Button btnGenerarTarea;
    }
}
