
namespace Biblioteca2022
{
    partial class FormBorrado
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
            this.GrpOpciones = new System.Windows.Forms.GroupBox();
            this.RbtnUsuario = new System.Windows.Forms.RadioButton();
            this.RbtnLibro = new System.Windows.Forms.RadioButton();
            this.LblTxt = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.GrpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpOpciones
            // 
            this.GrpOpciones.Controls.Add(this.RbtnUsuario);
            this.GrpOpciones.Controls.Add(this.RbtnLibro);
            this.GrpOpciones.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpOpciones.Location = new System.Drawing.Point(39, 107);
            this.GrpOpciones.Name = "GrpOpciones";
            this.GrpOpciones.Size = new System.Drawing.Size(200, 142);
            this.GrpOpciones.TabIndex = 6;
            this.GrpOpciones.TabStop = false;
            this.GrpOpciones.Text = "Opciones";
            // 
            // RbtnUsuario
            // 
            this.RbtnUsuario.AutoSize = true;
            this.RbtnUsuario.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnUsuario.Location = new System.Drawing.Point(35, 46);
            this.RbtnUsuario.Name = "RbtnUsuario";
            this.RbtnUsuario.Size = new System.Drawing.Size(92, 25);
            this.RbtnUsuario.TabIndex = 0;
            this.RbtnUsuario.TabStop = true;
            this.RbtnUsuario.Text = "Usuario";
            this.RbtnUsuario.UseVisualStyleBackColor = true;
            this.RbtnUsuario.CheckedChanged += new System.EventHandler(this.Rbtb_CheckedChanged);
            // 
            // RbtnLibro
            // 
            this.RbtnLibro.AutoSize = true;
            this.RbtnLibro.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnLibro.Location = new System.Drawing.Point(35, 87);
            this.RbtnLibro.Name = "RbtnLibro";
            this.RbtnLibro.Size = new System.Drawing.Size(75, 25);
            this.RbtnLibro.TabIndex = 1;
            this.RbtnLibro.TabStop = true;
            this.RbtnLibro.Text = "Libro";
            this.RbtnLibro.UseVisualStyleBackColor = true;
            this.RbtnLibro.CheckedChanged += new System.EventHandler(this.Rbtb_CheckedChanged);
            // 
            // LblTxt
            // 
            this.LblTxt.AutoSize = true;
            this.LblTxt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTxt.Location = new System.Drawing.Point(305, 60);
            this.LblTxt.Name = "LblTxt";
            this.LblTxt.Size = new System.Drawing.Size(48, 22);
            this.LblTxt.TabIndex = 32;
            this.LblTxt.Text = "label";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(304, 175);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(57, 21);
            this.Lbl2.TabIndex = 31;
            this.Lbl2.Text = "label1";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(304, 214);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(57, 21);
            this.Lbl3.TabIndex = 30;
            this.Lbl3.Text = "label1";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(304, 127);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(57, 21);
            this.Lbl1.TabIndex = 29;
            this.Lbl1.Text = "label1";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(433, 290);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(113, 40);
            this.btnRestablecer.TabIndex = 28;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(586, 290);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(117, 40);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(454, 174);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(208, 22);
            this.Txt2.TabIndex = 26;
            // 
            // Txt3
            // 
            this.Txt3.Location = new System.Drawing.Point(454, 213);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(208, 22);
            this.Txt3.TabIndex = 25;
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(454, 130);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(208, 22);
            this.Txt1.TabIndex = 24;
            this.Txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt1_KeyDown);
            // 
            // FormBorrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTxt);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.GrpOpciones);
            this.Name = "FormBorrado";
            this.Text = "FormLibro";
            this.GrpOpciones.ResumeLayout(false);
            this.GrpOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpOpciones;
        private System.Windows.Forms.RadioButton RbtnUsuario;
        private System.Windows.Forms.RadioButton RbtnLibro;
        private System.Windows.Forms.Label LblTxt;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt1;
    }
}