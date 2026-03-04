
namespace CreacionControles
{
    partial class ControlCliente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbComentarios = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(41, 98);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 5;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(41, 3);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbComentarios
            // 
            this.tbComentarios.Location = new System.Drawing.Point(41, 146);
            this.tbComentarios.Name = "tbComentarios";
            this.tbComentarios.Size = new System.Drawing.Size(100, 20);
            this.tbComentarios.TabIndex = 7;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(41, 47);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 6;
            // 
            // ControlCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbComentarios);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbNombre);
            this.Name = "ControlCliente";
            this.Size = new System.Drawing.Size(182, 169);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbComentarios;
        private System.Windows.Forms.TextBox tbApellidos;
    }
}
