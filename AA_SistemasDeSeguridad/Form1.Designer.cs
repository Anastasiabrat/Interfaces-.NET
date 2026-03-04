
namespace AA_SistemasDeSeguridad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSistemas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSensores = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonServicios = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClientes,
            this.toolStripButtonSistemas,
            this.toolStripButtonSensores,
            this.toolStripButtonServicios});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonClientes
            // 
            this.toolStripButtonClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClientes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClientes.Image")));
            this.toolStripButtonClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClientes.Name = "toolStripButtonClientes";
            this.toolStripButtonClientes.Size = new System.Drawing.Size(61, 22);
            this.toolStripButtonClientes.Text = "CLIENTES";
            this.toolStripButtonClientes.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonSistemas
            // 
            this.toolStripButtonSistemas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSistemas.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSistemas.Image")));
            this.toolStripButtonSistemas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSistemas.Name = "toolStripButtonSistemas";
            this.toolStripButtonSistemas.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonSistemas.Text = "SISTEMAS";
            this.toolStripButtonSistemas.Click += new System.EventHandler(this.toolStripButtonSistemas_Click);
            // 
            // toolStripButtonSensores
            // 
            this.toolStripButtonSensores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSensores.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSensores.Image")));
            this.toolStripButtonSensores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSensores.Name = "toolStripButtonSensores";
            this.toolStripButtonSensores.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonSensores.Text = "SENSORES";
            this.toolStripButtonSensores.Click += new System.EventHandler(this.toolStripButtonSensores_Click);
            // 
            // toolStripButtonServicios
            // 
            this.toolStripButtonServicios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonServicios.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonServicios.Image")));
            this.toolStripButtonServicios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonServicios.Name = "toolStripButtonServicios";
            this.toolStripButtonServicios.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonServicios.Text = "SERVICIOS";
            this.toolStripButtonServicios.Click += new System.EventHandler(this.toolStripButtonServicios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClientes;
        private System.Windows.Forms.ToolStripButton toolStripButtonSistemas;
        private System.Windows.Forms.ToolStripButton toolStripButtonSensores;
        private System.Windows.Forms.ToolStripButton toolStripButtonServicios;
    }
}

