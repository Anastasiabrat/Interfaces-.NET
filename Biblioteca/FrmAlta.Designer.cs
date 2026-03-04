
namespace Biblioteca
{
    partial class FrmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlta));
            this.TxtBoxTitulo = new System.Windows.Forms.TextBox();
            this.TxtBoxEditorial = new System.Windows.Forms.TextBox();
            this.TxtBoxAutor = new System.Windows.Forms.TextBox();
            this.checkBoxNuevo = new System.Windows.Forms.CheckBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBoxPortada = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelEditorial = new System.Windows.Forms.Label();
            this.labelNuevo = new System.Windows.Forms.Label();
            this.BtnCargarFoto = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.labelFtoPortada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBoxTitulo
            // 
            this.TxtBoxTitulo.Location = new System.Drawing.Point(186, 107);
            this.TxtBoxTitulo.Name = "TxtBoxTitulo";
            this.TxtBoxTitulo.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxTitulo.TabIndex = 0;
            // 
            // TxtBoxEditorial
            // 
            this.TxtBoxEditorial.Location = new System.Drawing.Point(186, 208);
            this.TxtBoxEditorial.Name = "TxtBoxEditorial";
            this.TxtBoxEditorial.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxEditorial.TabIndex = 2;
            // 
            // TxtBoxAutor
            // 
            this.TxtBoxAutor.Location = new System.Drawing.Point(186, 160);
            this.TxtBoxAutor.Name = "TxtBoxAutor";
            this.TxtBoxAutor.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxAutor.TabIndex = 3;
            // 
            // checkBoxNuevo
            // 
            this.checkBoxNuevo.AutoSize = true;
            this.checkBoxNuevo.Location = new System.Drawing.Point(186, 266);
            this.checkBoxNuevo.Name = "checkBoxNuevo";
            this.checkBoxNuevo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNuevo.TabIndex = 4;
            this.checkBoxNuevo.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(61, 108);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(62, 24);
            this.labelTitulo.TabIndex = 15;
            this.labelTitulo.Text = "Título";
            // 
            // pictureBoxPortada
            // 
            this.pictureBoxPortada.Location = new System.Drawing.Point(354, 139);
            this.pictureBoxPortada.Name = "pictureBoxPortada";
            this.pictureBoxPortada.Size = new System.Drawing.Size(108, 141);
            this.pictureBoxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPortada.TabIndex = 6;
            this.pictureBoxPortada.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(37, 315);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(110, 38);
            this.BtnGuardar.TabIndex = 16;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(61, 159);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(60, 24);
            this.labelAutor.TabIndex = 19;
            this.labelAutor.Text = "Autor";
            // 
            // labelEditorial
            // 
            this.labelEditorial.AutoSize = true;
            this.labelEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditorial.Location = new System.Drawing.Point(61, 207);
            this.labelEditorial.Name = "labelEditorial";
            this.labelEditorial.Size = new System.Drawing.Size(86, 24);
            this.labelEditorial.TabIndex = 20;
            this.labelEditorial.Text = "Editorial";
            // 
            // labelNuevo
            // 
            this.labelNuevo.AutoSize = true;
            this.labelNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevo.Location = new System.Drawing.Point(61, 257);
            this.labelNuevo.Name = "labelNuevo";
            this.labelNuevo.Size = new System.Drawing.Size(71, 24);
            this.labelNuevo.TabIndex = 21;
            this.labelNuevo.Text = "Nuevo";
            // 
            // BtnCargarFoto
            // 
            this.BtnCargarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarFoto.Location = new System.Drawing.Point(351, 315);
            this.BtnCargarFoto.Name = "BtnCargarFoto";
            this.BtnCargarFoto.Size = new System.Drawing.Size(125, 38);
            this.BtnCargarFoto.TabIndex = 22;
            this.BtnCargarFoto.Text = "Cargar foto";
            this.BtnCargarFoto.UseVisualStyleBackColor = true;
            this.BtnCargarFoto.Click += new System.EventHandler(this.BtnCargarFoto_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(196, 315);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(110, 38);
            this.BtnLimpiar.TabIndex = 23;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // labelFtoPortada
            // 
            this.labelFtoPortada.AutoSize = true;
            this.labelFtoPortada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFtoPortada.Location = new System.Drawing.Point(347, 87);
            this.labelFtoPortada.Name = "labelFtoPortada";
            this.labelFtoPortada.Size = new System.Drawing.Size(129, 24);
            this.labelFtoPortada.TabIndex = 24;
            this.labelFtoPortada.Text = "Foto Portada";
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFtoPortada);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCargarFoto);
            this.Controls.Add(this.labelNuevo);
            this.Controls.Add(this.labelEditorial);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.pictureBoxPortada);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.checkBoxNuevo);
            this.Controls.Add(this.TxtBoxAutor);
            this.Controls.Add(this.TxtBoxEditorial);
            this.Controls.Add(this.TxtBoxTitulo);
            this.DoubleBuffered = true;
            this.Name = "FrmAlta";
            this.Text = "FrmAlta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxTitulo;
        private System.Windows.Forms.TextBox TxtBoxEditorial;
        private System.Windows.Forms.TextBox TxtBoxAutor;
        private System.Windows.Forms.CheckBox checkBoxNuevo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBoxPortada;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelEditorial;
        private System.Windows.Forms.Label labelNuevo;
        private System.Windows.Forms.Button BtnCargarFoto;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label labelFtoPortada;
    }
}