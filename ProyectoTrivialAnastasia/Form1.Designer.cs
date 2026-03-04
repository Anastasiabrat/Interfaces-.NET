
namespace ProyectoTrivialAnastasia
{
    partial class BoxPorcentaje
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TituloCajaUnica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuPartida = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.opcNombreCapitales = new System.Windows.Forms.ToolStripMenuItem();
            this.opcNombrePaises = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.multiplesOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribirRespuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtUnico = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Titulo4Cajas = new System.Windows.Forms.Label();
            this.TxtMessageCorrect = new System.Windows.Forms.TextBox();
            this.Txt4de4 = new System.Windows.Forms.TextBox();
            this.Txt3de4 = new System.Windows.Forms.TextBox();
            this.Txt2de4 = new System.Windows.Forms.TextBox();
            this.Txt1de4 = new System.Windows.Forms.TextBox();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtPorcentaje = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TituloCajaUnica});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TituloCajaUnica
            // 
            this.TituloCajaUnica.Name = "TituloCajaUnica";
            this.TituloCajaUnica.Size = new System.Drawing.Size(40, 20);
            this.TituloCajaUnica.Text = "País";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPartida,
            this.MenuOpciones});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MenuPartida
            // 
            this.MenuPartida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4});
            this.MenuPartida.Name = "MenuPartida";
            this.MenuPartida.Size = new System.Drawing.Size(56, 20);
            this.MenuPartida.Text = "Partida";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.ponerNombres);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(105, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(105, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem4.Text = "Salir";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // MenuOpciones
            // 
            this.MenuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcNombreCapitales,
            this.opcNombrePaises,
            this.toolStripMenuItem3,
            this.multiplesOpcionesToolStripMenuItem,
            this.escribirRespuestaToolStripMenuItem});
            this.MenuOpciones.Name = "MenuOpciones";
            this.MenuOpciones.Size = new System.Drawing.Size(69, 20);
            this.MenuOpciones.Text = "Opciones";
            // 
            // opcNombreCapitales
            // 
            this.opcNombreCapitales.Name = "opcNombreCapitales";
            this.opcNombreCapitales.Size = new System.Drawing.Size(180, 22);
            this.opcNombreCapitales.Text = "Nombre Capitales";
            this.opcNombreCapitales.Click += new System.EventHandler(this.opcNombreCapitales_Click);
            // 
            // opcNombrePaises
            // 
            this.opcNombrePaises.Name = "opcNombrePaises";
            this.opcNombrePaises.Size = new System.Drawing.Size(180, 22);
            this.opcNombrePaises.Text = "Nombre Paises";
            this.opcNombrePaises.Click += new System.EventHandler(this.opcNombrePaises_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // multiplesOpcionesToolStripMenuItem
            // 
            this.multiplesOpcionesToolStripMenuItem.Name = "multiplesOpcionesToolStripMenuItem";
            this.multiplesOpcionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multiplesOpcionesToolStripMenuItem.Text = "Multiples Opciones";
            this.multiplesOpcionesToolStripMenuItem.Click += new System.EventHandler(this.opcMultiOpc);
            // 
            // escribirRespuestaToolStripMenuItem
            // 
            this.escribirRespuestaToolStripMenuItem.Name = "escribirRespuestaToolStripMenuItem";
            this.escribirRespuestaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escribirRespuestaToolStripMenuItem.Text = "Escribir Respuesta";
            this.escribirRespuestaToolStripMenuItem.Click += new System.EventHandler(this.opcEscRespuesta);
            // 
            // TxtUnico
            // 
            this.TxtUnico.Location = new System.Drawing.Point(12, 51);
            this.TxtUnico.Name = "TxtUnico";
            this.TxtUnico.Size = new System.Drawing.Size(151, 20);
            this.TxtUnico.TabIndex = 2;
            this.TxtUnico.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Titulo4Cajas
            // 
            this.Titulo4Cajas.AutoSize = true;
            this.Titulo4Cajas.Location = new System.Drawing.Point(12, 83);
            this.Titulo4Cajas.Name = "Titulo4Cajas";
            this.Titulo4Cajas.Size = new System.Drawing.Size(42, 13);
            this.Titulo4Cajas.TabIndex = 5;
            this.Titulo4Cajas.Text = "Capital:";
            // 
            // TxtMessageCorrect
            // 
            this.TxtMessageCorrect.BackColor = System.Drawing.Color.MediumBlue;
            this.TxtMessageCorrect.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.TxtMessageCorrect.Location = new System.Drawing.Point(87, 77);
            this.TxtMessageCorrect.Name = "TxtMessageCorrect";
            this.TxtMessageCorrect.Size = new System.Drawing.Size(76, 20);
            this.TxtMessageCorrect.TabIndex = 6;
            this.TxtMessageCorrect.TabStop = false;
            // 
            // Txt4de4
            // 
            this.Txt4de4.Location = new System.Drawing.Point(12, 181);
            this.Txt4de4.Name = "Txt4de4";
            this.Txt4de4.Size = new System.Drawing.Size(151, 20);
            this.Txt4de4.TabIndex = 8;
            this.Txt4de4.TabStop = false;
            this.Txt4de4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mostrarMensaje);
            // 
            // Txt3de4
            // 
            this.Txt3de4.Location = new System.Drawing.Point(12, 155);
            this.Txt3de4.Name = "Txt3de4";
            this.Txt3de4.Size = new System.Drawing.Size(151, 20);
            this.Txt3de4.TabIndex = 9;
            this.Txt3de4.TabStop = false;
            this.Txt3de4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mostrarMensaje);
            // 
            // Txt2de4
            // 
            this.Txt2de4.Location = new System.Drawing.Point(12, 129);
            this.Txt2de4.Name = "Txt2de4";
            this.Txt2de4.Size = new System.Drawing.Size(151, 20);
            this.Txt2de4.TabIndex = 10;
            this.Txt2de4.TabStop = false;
            this.Txt2de4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mostrarMensaje);
            // 
            // Txt1de4
            // 
            this.Txt1de4.Location = new System.Drawing.Point(12, 103);
            this.Txt1de4.Name = "Txt1de4";
            this.Txt1de4.Size = new System.Drawing.Size(151, 20);
            this.Txt1de4.TabIndex = 11;
            this.Txt1de4.TabStop = false;
            this.Txt1de4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mostrarMensaje);
            this.Txt1de4.TextChanged += new System.EventHandler(this.Txt1de4_TextChanged);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Location = new System.Drawing.Point(15, 207);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.BtnSiguiente.TabIndex = 12;
            this.BtnSiguiente.TabStop = false;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(15, 236);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.BackColor = System.Drawing.Color.Yellow;
            this.TxtPorcentaje.Location = new System.Drawing.Point(120, 220);
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Size = new System.Drawing.Size(43, 20);
            this.TxtPorcentaje.TabIndex = 14;
            this.TxtPorcentaje.TabStop = false;
            // 
            // BoxPorcentaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtPorcentaje);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.Txt1de4);
            this.Controls.Add(this.Txt2de4);
            this.Controls.Add(this.Txt3de4);
            this.Controls.Add(this.Txt4de4);
            this.Controls.Add(this.TxtMessageCorrect);
            this.Controls.Add(this.Titulo4Cajas);
            this.Controls.Add(this.TxtUnico);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BoxPorcentaje";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ponerNombres);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TituloCajaUnica;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MenuPartida;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TextBox TxtUnico;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label Titulo4Cajas;
        private System.Windows.Forms.TextBox TxtMessageCorrect;
        private System.Windows.Forms.TextBox Txt4de4;
        private System.Windows.Forms.TextBox Txt3de4;
        private System.Windows.Forms.TextBox Txt2de4;
        private System.Windows.Forms.TextBox Txt1de4;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtPorcentaje;
        private System.Windows.Forms.ToolStripMenuItem opcNombreCapitales;
        private System.Windows.Forms.ToolStripMenuItem opcNombrePaises;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem multiplesOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribirRespuestaToolStripMenuItem;
    }
}

