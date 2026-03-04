
namespace ControladorEventosPeliculas
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
            this.listViewPeliculas = new System.Windows.Forms.ListView();
            this.Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Actores = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Director = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewPeliculas
            // 
            this.listViewPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titulo,
            this.Actores,
            this.Director});
            this.listViewPeliculas.HideSelection = false;
            this.listViewPeliculas.Location = new System.Drawing.Point(12, 170);
            this.listViewPeliculas.Name = "listViewPeliculas";
            this.listViewPeliculas.Size = new System.Drawing.Size(745, 227);
            this.listViewPeliculas.TabIndex = 0;
            this.listViewPeliculas.UseCompatibleStateImageBehavior = false;
            this.listViewPeliculas.View = System.Windows.Forms.View.Details;
            // 
            // Titulo
            // 
            this.Titulo.Text = "Titulo";
            this.Titulo.Width = 172;
            // 
            // Actores
            // 
            this.Actores.Text = "Actores";
            this.Actores.Width = 355;
            // 
            // Director
            // 
            this.Director.Text = "Director";
            this.Director.Width = 231;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewPeliculas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPeliculas;
        private System.Windows.Forms.ColumnHeader Titulo;
        private System.Windows.Forms.ColumnHeader Actores;
        private System.Windows.Forms.ColumnHeader Director;
    }
}

