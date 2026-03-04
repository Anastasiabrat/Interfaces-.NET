
namespace Biblioteca2022
{
    partial class FormListado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewListado = new System.Windows.Forms.ListView();
            this.GrpOpciones = new System.Windows.Forms.GroupBox();
            this.RbtbUsuario = new System.Windows.Forms.RadioButton();
            this.RbtbLibro = new System.Windows.Forms.RadioButton();
            this.RbtbDevolucion = new System.Windows.Forms.RadioButton();
            this.RbtbPrestamo = new System.Windows.Forms.RadioButton();
            this.labelBusqueda = new System.Windows.Forms.Label();
            this.tbBusqueda_FormListado = new System.Windows.Forms.TextBox();
            this.GrpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewListado
            // 
            this.listViewListado.HideSelection = false;
            this.listViewListado.Location = new System.Drawing.Point(273, 160);
            this.listViewListado.Margin = new System.Windows.Forms.Padding(2);
            this.listViewListado.Name = "listViewListado";
            this.listViewListado.Size = new System.Drawing.Size(501, 211);
            this.listViewListado.TabIndex = 0;
            this.listViewListado.UseCompatibleStateImageBehavior = false;
            this.listViewListado.View = System.Windows.Forms.View.Details;
            // 
            // GrpOpciones
            // 
            this.GrpOpciones.Controls.Add(this.RbtbUsuario);
            this.GrpOpciones.Controls.Add(this.RbtbLibro);
            this.GrpOpciones.Controls.Add(this.RbtbDevolucion);
            this.GrpOpciones.Controls.Add(this.RbtbPrestamo);
            this.GrpOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpOpciones.Location = new System.Drawing.Point(44, 31);
            this.GrpOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.GrpOpciones.Name = "GrpOpciones";
            this.GrpOpciones.Padding = new System.Windows.Forms.Padding(2);
            this.GrpOpciones.Size = new System.Drawing.Size(150, 193);
            this.GrpOpciones.TabIndex = 6;
            this.GrpOpciones.TabStop = false;
            this.GrpOpciones.Text = "Opciones";
            // 
            // RbtbUsuario
            // 
            this.RbtbUsuario.AutoSize = true;
            this.RbtbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtbUsuario.Location = new System.Drawing.Point(26, 37);
            this.RbtbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.RbtbUsuario.Name = "RbtbUsuario";
            this.RbtbUsuario.Size = new System.Drawing.Size(78, 22);
            this.RbtbUsuario.TabIndex = 0;
            this.RbtbUsuario.TabStop = true;
            this.RbtbUsuario.Text = "Usuario";
            this.RbtbUsuario.UseVisualStyleBackColor = true;
            this.RbtbUsuario.CheckedChanged += new System.EventHandler(this.Rbtb_CheckedChanged);
            // 
            // RbtbLibro
            // 
            this.RbtbLibro.AutoSize = true;
            this.RbtbLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtbLibro.Location = new System.Drawing.Point(26, 71);
            this.RbtbLibro.Margin = new System.Windows.Forms.Padding(2);
            this.RbtbLibro.Name = "RbtbLibro";
            this.RbtbLibro.Size = new System.Drawing.Size(59, 22);
            this.RbtbLibro.TabIndex = 1;
            this.RbtbLibro.TabStop = true;
            this.RbtbLibro.Text = "Libro";
            this.RbtbLibro.UseVisualStyleBackColor = true;
            this.RbtbLibro.CheckedChanged += new System.EventHandler(this.Rbtb_CheckedChanged);
            // 
            // RbtbDevolucion
            // 
            this.RbtbDevolucion.AutoSize = true;
            this.RbtbDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtbDevolucion.Location = new System.Drawing.Point(26, 141);
            this.RbtbDevolucion.Margin = new System.Windows.Forms.Padding(2);
            this.RbtbDevolucion.Name = "RbtbDevolucion";
            this.RbtbDevolucion.Size = new System.Drawing.Size(100, 22);
            this.RbtbDevolucion.TabIndex = 3;
            this.RbtbDevolucion.TabStop = true;
            this.RbtbDevolucion.Text = "Devolucion";
            this.RbtbDevolucion.UseVisualStyleBackColor = true;
            this.RbtbDevolucion.CheckedChanged += new System.EventHandler(this.Rbtb_CheckedChanged);
            // 
            // RbtbPrestamo
            // 
            this.RbtbPrestamo.AutoSize = true;
            this.RbtbPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtbPrestamo.Location = new System.Drawing.Point(26, 105);
            this.RbtbPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.RbtbPrestamo.Name = "RbtbPrestamo";
            this.RbtbPrestamo.Size = new System.Drawing.Size(91, 22);
            this.RbtbPrestamo.TabIndex = 2;
            this.RbtbPrestamo.TabStop = true;
            this.RbtbPrestamo.Text = "Prestamo";
            this.RbtbPrestamo.UseVisualStyleBackColor = true;
            this.RbtbPrestamo.CheckedChanged += new System.EventHandler(this.Rbtb_CheckedChanged);
            // 
            // labelBusqueda
            // 
            this.labelBusqueda.AutoSize = true;
            this.labelBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusqueda.Location = new System.Drawing.Point(326, 53);
            this.labelBusqueda.Name = "labelBusqueda";
            this.labelBusqueda.Size = new System.Drawing.Size(74, 18);
            this.labelBusqueda.TabIndex = 7;
            this.labelBusqueda.Text = "Búsqueda";
            // 
            // tbBusqueda_FormListado
            // 
            this.tbBusqueda_FormListado.Location = new System.Drawing.Point(318, 87);
            this.tbBusqueda_FormListado.Name = "tbBusqueda_FormListado";
            this.tbBusqueda_FormListado.Size = new System.Drawing.Size(445, 20);
            this.tbBusqueda_FormListado.TabIndex = 8;
            this.tbBusqueda_FormListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBusqueda_FormListado_KeyDown);
            // 
            // FormListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 411);
            this.Controls.Add(this.tbBusqueda_FormListado);
            this.Controls.Add(this.labelBusqueda);
            this.Controls.Add(this.GrpOpciones);
            this.Controls.Add(this.listViewListado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormListado";
            this.Text = "FormConsulta";
            this.Load += new System.EventHandler(this.FormListado_Load);
            this.GrpOpciones.ResumeLayout(false);
            this.GrpOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewListado;
        private System.Windows.Forms.GroupBox GrpOpciones;
        private System.Windows.Forms.RadioButton RbtbUsuario;
        private System.Windows.Forms.RadioButton RbtbLibro;
        private System.Windows.Forms.RadioButton RbtbDevolucion;
        private System.Windows.Forms.RadioButton RbtbPrestamo;
        private System.Windows.Forms.Label labelBusqueda;
        private System.Windows.Forms.TextBox tbBusqueda_FormListado;
    }
}