
namespace Biblioteca2022
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TbtnAlta = new System.Windows.Forms.ToolStripButton();
            this.TbtnLibros = new System.Windows.Forms.ToolStripButton();
            this.TbtnPrestDev = new System.Windows.Forms.ToolStripButton();
            this.TbPgListado = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TbtnAlta,
            this.TbtnLibros,
            this.TbtnPrestDev,
            this.TbPgListado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // TbtnAlta
            // 
            this.TbtnAlta.Image = ((System.Drawing.Image)(resources.GetObject("TbtnAlta.Image")));
            this.TbtnAlta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbtnAlta.Name = "TbtnAlta";
            this.TbtnAlta.Size = new System.Drawing.Size(40, 44);
            this.TbtnAlta.Text = "Alta";
            this.TbtnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TbtnLibros
            // 
            this.TbtnLibros.Image = ((System.Drawing.Image)(resources.GetObject("TbtnLibros.Image")));
            this.TbtnLibros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbtnLibros.Name = "TbtnLibros";
            this.TbtnLibros.Size = new System.Drawing.Size(100, 44);
            this.TbtnLibros.Text = "Modificacion";
            this.TbtnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TbtnPrestDev
            // 
            this.TbtnPrestDev.Image = ((System.Drawing.Image)(resources.GetObject("TbtnPrestDev.Image")));
            this.TbtnPrestDev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbtnPrestDev.Name = "TbtnPrestDev";
            this.TbtnPrestDev.Size = new System.Drawing.Size(67, 44);
            this.TbtnPrestDev.Text = "Borrado";
            this.TbtnPrestDev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TbPgListado
            // 
            this.TbPgListado.Image = ((System.Drawing.Image)(resources.GetObject("TbPgListado.Image")));
            this.TbPgListado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbPgListado.Name = "TbPgListado";
            this.TbPgListado.Size = new System.Drawing.Size(61, 44);
            this.TbPgListado.Text = "Listado";
            this.TbPgListado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "Biblioteca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TbtnAlta;
        private System.Windows.Forms.ToolStripButton TbtnLibros;
        private System.Windows.Forms.ToolStripButton TbtnPrestDev;
        private System.Windows.Forms.ToolStripButton TbPgListado;
    }
}

