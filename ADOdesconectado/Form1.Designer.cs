
namespace ADOdesconectado
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
            this.BtnTraerDatos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnRecorrer = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.BtnEnlazarDatos = new System.Windows.Forms.Button();
            this.BtnAccederElement = new System.Windows.Forms.Button();
            this.BtnModificarRegistro = new System.Windows.Forms.Button();
            this.BtnInsertarRegistro = new System.Windows.Forms.Button();
            this.BtnBorrarRegistro = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnModificar2 = new System.Windows.Forms.Button();
            this.BtnSeleccionarPorClave = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGridView = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnPersonalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTraerDatos
            // 
            this.BtnTraerDatos.Location = new System.Drawing.Point(511, 34);
            this.BtnTraerDatos.Name = "BtnTraerDatos";
            this.BtnTraerDatos.Size = new System.Drawing.Size(108, 37);
            this.BtnTraerDatos.TabIndex = 0;
            this.BtnTraerDatos.Text = "Traer Datos";
            this.BtnTraerDatos.UseVisualStyleBackColor = true;
            this.BtnTraerDatos.Click += new System.EventHandler(this.BtnTraerDatos_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(198, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 132);
            this.listBox1.TabIndex = 1;
            // 
            // BtnRecorrer
            // 
            this.BtnRecorrer.Location = new System.Drawing.Point(511, 93);
            this.BtnRecorrer.Name = "BtnRecorrer";
            this.BtnRecorrer.Size = new System.Drawing.Size(123, 36);
            this.BtnRecorrer.TabIndex = 2;
            this.BtnRecorrer.Text = "Recorrer Tabla";
            this.BtnRecorrer.UseVisualStyleBackColor = true;
            this.BtnRecorrer.Click += new System.EventHandler(this.BtnRecorrer_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(198, 255);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(264, 132);
            this.listBox2.TabIndex = 3;
            // 
            // BtnEnlazarDatos
            // 
            this.BtnEnlazarDatos.Location = new System.Drawing.Point(511, 144);
            this.BtnEnlazarDatos.Name = "BtnEnlazarDatos";
            this.BtnEnlazarDatos.Size = new System.Drawing.Size(104, 37);
            this.BtnEnlazarDatos.TabIndex = 4;
            this.BtnEnlazarDatos.Text = "EnlazarDatos";
            this.BtnEnlazarDatos.UseVisualStyleBackColor = true;
            this.BtnEnlazarDatos.Click += new System.EventHandler(this.BtnEnlazarDatos_Click);
            // 
            // BtnAccederElement
            // 
            this.BtnAccederElement.Location = new System.Drawing.Point(511, 197);
            this.BtnAccederElement.Name = "BtnAccederElement";
            this.BtnAccederElement.Size = new System.Drawing.Size(158, 43);
            this.BtnAccederElement.TabIndex = 5;
            this.BtnAccederElement.Text = "Aceder al elemento seleccionado";
            this.BtnAccederElement.UseVisualStyleBackColor = true;
            this.BtnAccederElement.Click += new System.EventHandler(this.BtnAccederElement_Click);
            // 
            // BtnModificarRegistro
            // 
            this.BtnModificarRegistro.Location = new System.Drawing.Point(511, 255);
            this.BtnModificarRegistro.Name = "BtnModificarRegistro";
            this.BtnModificarRegistro.Size = new System.Drawing.Size(158, 36);
            this.BtnModificarRegistro.TabIndex = 6;
            this.BtnModificarRegistro.Text = "Modificar un registro";
            this.BtnModificarRegistro.UseVisualStyleBackColor = true;
            this.BtnModificarRegistro.Click += new System.EventHandler(this.BtnModificarRegistro_Click);
            // 
            // BtnInsertarRegistro
            // 
            this.BtnInsertarRegistro.Location = new System.Drawing.Point(511, 312);
            this.BtnInsertarRegistro.Name = "BtnInsertarRegistro";
            this.BtnInsertarRegistro.Size = new System.Drawing.Size(158, 36);
            this.BtnInsertarRegistro.TabIndex = 7;
            this.BtnInsertarRegistro.Text = "Insertar un registro";
            this.BtnInsertarRegistro.UseVisualStyleBackColor = true;
            this.BtnInsertarRegistro.Click += new System.EventHandler(this.BtnInsertarRegistro_Click);
            // 
            // BtnBorrarRegistro
            // 
            this.BtnBorrarRegistro.Location = new System.Drawing.Point(511, 366);
            this.BtnBorrarRegistro.Name = "BtnBorrarRegistro";
            this.BtnBorrarRegistro.Size = new System.Drawing.Size(158, 36);
            this.BtnBorrarRegistro.TabIndex = 8;
            this.BtnBorrarRegistro.Text = "Borrar un registro";
            this.BtnBorrarRegistro.UseVisualStyleBackColor = true;
            this.BtnBorrarRegistro.Click += new System.EventHandler(this.BtnBorrarRegistro_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(511, 413);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(235, 36);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "Abrir, Guardar y Cerrar Conexion";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnModificar2
            // 
            this.BtnModificar2.Location = new System.Drawing.Point(784, 34);
            this.BtnModificar2.Name = "BtnModificar2";
            this.BtnModificar2.Size = new System.Drawing.Size(104, 37);
            this.BtnModificar2.TabIndex = 10;
            this.BtnModificar2.Text = "Modificar";
            this.BtnModificar2.UseVisualStyleBackColor = true;
            this.BtnModificar2.Click += new System.EventHandler(this.BtnModificar2_Click);
            // 
            // BtnSeleccionarPorClave
            // 
            this.BtnSeleccionarPorClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSeleccionarPorClave.Location = new System.Drawing.Point(784, 93);
            this.BtnSeleccionarPorClave.Name = "BtnSeleccionarPorClave";
            this.BtnSeleccionarPorClave.Size = new System.Drawing.Size(104, 37);
            this.BtnSeleccionarPorClave.TabIndex = 11;
            this.BtnSeleccionarPorClave.Text = "Seleccionar por clave";
            this.BtnSeleccionarPorClave.UseVisualStyleBackColor = true;
            this.BtnSeleccionarPorClave.Click += new System.EventHandler(this.BtnSeleccionarPorClave_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSelect.Location = new System.Drawing.Point(784, 144);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(104, 37);
            this.BtnSelect.TabIndex = 12;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(801, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(318, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnGridView
            // 
            this.BtnGridView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGridView.Location = new System.Drawing.Point(784, 200);
            this.BtnGridView.Name = "BtnGridView";
            this.BtnGridView.Size = new System.Drawing.Size(104, 37);
            this.BtnGridView.TabIndex = 14;
            this.BtnGridView.Text = "Grid View";
            this.BtnGridView.UseVisualStyleBackColor = true;
            this.BtnGridView.Click += new System.EventHandler(this.BtnGridView_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnFiltrar.Location = new System.Drawing.Point(784, 256);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(104, 37);
            this.BtnFiltrar.TabIndex = 15;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnPersonalizar
            // 
            this.BtnPersonalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPersonalizar.Location = new System.Drawing.Point(939, 256);
            this.BtnPersonalizar.Name = "BtnPersonalizar";
            this.BtnPersonalizar.Size = new System.Drawing.Size(104, 37);
            this.BtnPersonalizar.TabIndex = 16;
            this.BtnPersonalizar.Text = "Personalizar";
            this.BtnPersonalizar.UseVisualStyleBackColor = true;
            this.BtnPersonalizar.Click += new System.EventHandler(this.BtnPersonalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 515);
            this.Controls.Add(this.BtnPersonalizar);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.BtnGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnSeleccionarPorClave);
            this.Controls.Add(this.BtnModificar2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnBorrarRegistro);
            this.Controls.Add(this.BtnInsertarRegistro);
            this.Controls.Add(this.BtnModificarRegistro);
            this.Controls.Add(this.BtnAccederElement);
            this.Controls.Add(this.BtnEnlazarDatos);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.BtnRecorrer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnTraerDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTraerDatos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnRecorrer;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button BtnEnlazarDatos;
        private System.Windows.Forms.Button BtnAccederElement;
        private System.Windows.Forms.Button BtnModificarRegistro;
        private System.Windows.Forms.Button BtnInsertarRegistro;
        private System.Windows.Forms.Button BtnBorrarRegistro;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnModificar2;
        private System.Windows.Forms.Button BtnSeleccionarPorClave;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGridView;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnPersonalizar;
    }
}

