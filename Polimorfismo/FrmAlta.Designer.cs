
namespace Polimorfismo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCD = new System.Windows.Forms.RadioButton();
            this.radioButtonRevista = new System.Windows.Forms.RadioButton();
            this.radioButtonLibro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.TxtBox3 = new System.Windows.Forms.TextBox();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.TxtBox4 = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCD);
            this.groupBox1.Controls.Add(this.radioButtonRevista);
            this.groupBox1.Controls.Add(this.radioButtonLibro);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // radioButtonCD
            // 
            this.radioButtonCD.AutoSize = true;
            this.radioButtonCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCD.Location = new System.Drawing.Point(16, 102);
            this.radioButtonCD.Name = "radioButtonCD";
            this.radioButtonCD.Size = new System.Drawing.Size(47, 20);
            this.radioButtonCD.TabIndex = 2;
            this.radioButtonCD.TabStop = true;
            this.radioButtonCD.Text = "CD";
            this.radioButtonCD.UseVisualStyleBackColor = true;
            this.radioButtonCD.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonRevista
            // 
            this.radioButtonRevista.AutoSize = true;
            this.radioButtonRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRevista.Location = new System.Drawing.Point(16, 63);
            this.radioButtonRevista.Name = "radioButtonRevista";
            this.radioButtonRevista.Size = new System.Drawing.Size(79, 20);
            this.radioButtonRevista.TabIndex = 1;
            this.radioButtonRevista.TabStop = true;
            this.radioButtonRevista.Text = "Revista";
            this.radioButtonRevista.UseVisualStyleBackColor = true;
            this.radioButtonRevista.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonLibro
            // 
            this.radioButtonLibro.AutoSize = true;
            this.radioButtonLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLibro.Location = new System.Drawing.Point(16, 26);
            this.radioButtonLibro.Name = "radioButtonLibro";
            this.radioButtonLibro.Size = new System.Drawing.Size(61, 20);
            this.radioButtonLibro.TabIndex = 0;
            this.radioButtonLibro.TabStop = true;
            this.radioButtonLibro.Text = "Libro";
            this.radioButtonLibro.UseVisualStyleBackColor = true;
            this.radioButtonLibro.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Resumen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Editorial";
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(444, 44);
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(233, 20);
            this.TxtBox1.TabIndex = 5;
            // 
            // TxtBox3
            // 
            this.TxtBox3.Location = new System.Drawing.Point(444, 136);
            this.TxtBox3.Name = "TxtBox3";
            this.TxtBox3.Size = new System.Drawing.Size(233, 20);
            this.TxtBox3.TabIndex = 7;
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(444, 92);
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(233, 20);
            this.TxtBox2.TabIndex = 8;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(444, 298);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(100, 23);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(575, 298);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(102, 23);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // TxtBox4
            // 
            this.TxtBox4.Location = new System.Drawing.Point(444, 180);
            this.TxtBox4.Name = "TxtBox4";
            this.TxtBox4.Size = new System.Drawing.Size(233, 20);
            this.TxtBox4.TabIndex = 11;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(299, 226);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(51, 16);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(444, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.TxtBox4);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.TxtBox3);
            this.Controls.Add(this.TxtBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAlta";
            this.Text = "Alta de elementos multimedia";
            this.Load += new System.EventHandler(this.FrmAlta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCD;
        private System.Windows.Forms.RadioButton radioButtonRevista;
        private System.Windows.Forms.RadioButton radioButtonLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBox1;
        private System.Windows.Forms.TextBox TxtBox3;
        private System.Windows.Forms.TextBox TxtBox2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox TxtBox4;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}