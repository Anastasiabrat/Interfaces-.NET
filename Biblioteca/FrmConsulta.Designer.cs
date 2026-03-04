
namespace Biblioteca
{
    partial class FrmConsulta
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelAutorEditorial = new System.Windows.Forms.Label();
            this.labeFtoPortada = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnEditorial = new System.Windows.Forms.RadioButton();
            this.radioBtnAutor = new System.Windows.Forms.RadioButton();
            this.listBoxTitulo = new System.Windows.Forms.ListBox();
            this.listBoxAutorEdit = new System.Windows.Forms.ListBox();
            this.pictureBoxPortada = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(33, 202);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(62, 24);
            this.labelTitulo.TabIndex = 16;
            this.labelTitulo.Text = "Título";
            // 
            // labelAutorEditorial
            // 
            this.labelAutorEditorial.AutoSize = true;
            this.labelAutorEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutorEditorial.Location = new System.Drawing.Point(248, 202);
            this.labelAutorEditorial.Name = "labelAutorEditorial";
            this.labelAutorEditorial.Size = new System.Drawing.Size(154, 24);
            this.labelAutorEditorial.TabIndex = 17;
            this.labelAutorEditorial.Text = "Autor / Editorial";
            // 
            // labeFtoPortada
            // 
            this.labeFtoPortada.AutoSize = true;
            this.labeFtoPortada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeFtoPortada.Location = new System.Drawing.Point(478, 202);
            this.labeFtoPortada.Name = "labeFtoPortada";
            this.labeFtoPortada.Size = new System.Drawing.Size(129, 24);
            this.labeFtoPortada.TabIndex = 25;
            this.labeFtoPortada.Text = "Foto Portada";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnEditorial);
            this.groupBox1.Controls.Add(this.radioBtnAutor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 99);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Consulta";
            // 
            // radioBtnEditorial
            // 
            this.radioBtnEditorial.AutoSize = true;
            this.radioBtnEditorial.Location = new System.Drawing.Point(6, 59);
            this.radioBtnEditorial.Name = "radioBtnEditorial";
            this.radioBtnEditorial.Size = new System.Drawing.Size(104, 28);
            this.radioBtnEditorial.TabIndex = 1;
            this.radioBtnEditorial.TabStop = true;
            this.radioBtnEditorial.Text = "Editorial";
            this.radioBtnEditorial.UseVisualStyleBackColor = true;
            this.radioBtnEditorial.CheckedChanged += new System.EventHandler(this.radioBtnAutorEditorial_CheckedChanged);
            // 
            // radioBtnAutor
            // 
            this.radioBtnAutor.AutoSize = true;
            this.radioBtnAutor.Location = new System.Drawing.Point(6, 25);
            this.radioBtnAutor.Name = "radioBtnAutor";
            this.radioBtnAutor.Size = new System.Drawing.Size(78, 28);
            this.radioBtnAutor.TabIndex = 0;
            this.radioBtnAutor.TabStop = true;
            this.radioBtnAutor.Text = "Autor";
            this.radioBtnAutor.UseVisualStyleBackColor = true;
            this.radioBtnAutor.CheckedChanged += new System.EventHandler(this.radioBtnAutorEditorial_CheckedChanged);
            // 
            // listBoxTitulo
            // 
            this.listBoxTitulo.FormattingEnabled = true;
            this.listBoxTitulo.Location = new System.Drawing.Point(31, 229);
            this.listBoxTitulo.Name = "listBoxTitulo";
            this.listBoxTitulo.Size = new System.Drawing.Size(160, 173);
            this.listBoxTitulo.TabIndex = 27;
            this.listBoxTitulo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTitulo_MouseDoubleClick);
            // 
            // listBoxAutorEdit
            // 
            this.listBoxAutorEdit.FormattingEnabled = true;
            this.listBoxAutorEdit.Location = new System.Drawing.Point(252, 229);
            this.listBoxAutorEdit.Name = "listBoxAutorEdit";
            this.listBoxAutorEdit.Size = new System.Drawing.Size(160, 173);
            this.listBoxAutorEdit.TabIndex = 28;
            // 
            // pictureBoxPortada
            // 
            this.pictureBoxPortada.Location = new System.Drawing.Point(482, 229);
            this.pictureBoxPortada.Name = "pictureBoxPortada";
            this.pictureBoxPortada.Size = new System.Drawing.Size(125, 173);
            this.pictureBoxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPortada.TabIndex = 30;
            this.pictureBoxPortada.TabStop = false;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxPortada);
            this.Controls.Add(this.listBoxAutorEdit);
            this.Controls.Add(this.listBoxTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labeFtoPortada);
            this.Controls.Add(this.labelAutorEditorial);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FrmConsulta";
            this.Text = "FrmPadre";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelAutorEditorial;
        private System.Windows.Forms.Label labeFtoPortada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnAutor;
        private System.Windows.Forms.RadioButton radioBtnEditorial;
        private System.Windows.Forms.ListBox listBoxTitulo;
        private System.Windows.Forms.ListBox listBoxAutorEdit;
        private System.Windows.Forms.PictureBox pictureBoxPortada;
    }
}