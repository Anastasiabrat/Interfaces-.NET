
namespace CreacionControles
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
            this.tsBtnClientes = new System.Windows.Forms.ToolStripButton();
            this.tsBtnReservas = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnClientes,
            this.tsBtnReservas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnClientes
            // 
            this.tsBtnClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnClientes.Image")));
            this.tsBtnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClientes.Name = "tsBtnClientes";
            this.tsBtnClientes.Size = new System.Drawing.Size(53, 22);
            this.tsBtnClientes.Text = "Clientes";
            this.tsBtnClientes.Click += new System.EventHandler(this.tsBtnClientes_Click);
            // 
            // tsBtnReservas
            // 
            this.tsBtnReservas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnReservas.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnReservas.Image")));
            this.tsBtnReservas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnReservas.Name = "tsBtnReservas";
            this.tsBtnReservas.Size = new System.Drawing.Size(56, 22);
            this.tsBtnReservas.Text = "Reservas";
            this.tsBtnReservas.Click += new System.EventHandler(this.tsBtnReservas_Click);
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
        private System.Windows.Forms.ToolStripButton tsBtnClientes;
        private System.Windows.Forms.ToolStripButton tsBtnReservas;
    }
}

