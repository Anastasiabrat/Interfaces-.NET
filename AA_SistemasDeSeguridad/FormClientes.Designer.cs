
namespace AA_SistemasDeSeguridad
{
    partial class FormClientes
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAlta = new System.Windows.Forms.TabPage();
            this.btnVaciarCampos = new System.Windows.Forms.Button();
            this.labelAltaExitoso = new System.Windows.Forms.Label();
            this.buttonDarAlta = new System.Windows.Forms.Button();
            this.textBoxTel2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTel1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPoblacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageListado = new System.Windows.Forms.TabPage();
            this.buttonListado = new System.Windows.Forms.Button();
            this.dataGridViewListado = new System.Windows.Forms.DataGridView();
            this.tabPageBusqueda = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxBusquedaDNI = new System.Windows.Forms.TextBox();
            this.btnBusquedaDNI = new System.Windows.Forms.Button();
            this.dataGridViewBusq = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageAlta.SuspendLayout();
            this.tabPageListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListado)).BeginInit();
            this.tabPageBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAlta);
            this.tabControl1.Controls.Add(this.tabPageListado);
            this.tabControl1.Controls.Add(this.tabPageBusqueda);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAlta
            // 
            this.tabPageAlta.Controls.Add(this.btnVaciarCampos);
            this.tabPageAlta.Controls.Add(this.labelAltaExitoso);
            this.tabPageAlta.Controls.Add(this.buttonDarAlta);
            this.tabPageAlta.Controls.Add(this.textBoxTel2);
            this.tabPageAlta.Controls.Add(this.label6);
            this.tabPageAlta.Controls.Add(this.textBoxTel1);
            this.tabPageAlta.Controls.Add(this.label7);
            this.tabPageAlta.Controls.Add(this.textBoxPoblacion);
            this.tabPageAlta.Controls.Add(this.label5);
            this.tabPageAlta.Controls.Add(this.textBoxDireccion);
            this.tabPageAlta.Controls.Add(this.label4);
            this.tabPageAlta.Controls.Add(this.textBoxDNI);
            this.tabPageAlta.Controls.Add(this.label3);
            this.tabPageAlta.Controls.Add(this.textBoxApellidos);
            this.tabPageAlta.Controls.Add(this.label2);
            this.tabPageAlta.Controls.Add(this.textBoxNombre);
            this.tabPageAlta.Controls.Add(this.label1);
            this.tabPageAlta.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlta.Name = "tabPageAlta";
            this.tabPageAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlta.Size = new System.Drawing.Size(780, 412);
            this.tabPageAlta.TabIndex = 0;
            this.tabPageAlta.Text = "Alta";
            this.tabPageAlta.UseVisualStyleBackColor = true;
            // 
            // btnVaciarCampos
            // 
            this.btnVaciarCampos.Location = new System.Drawing.Point(532, 322);
            this.btnVaciarCampos.Name = "btnVaciarCampos";
            this.btnVaciarCampos.Size = new System.Drawing.Size(83, 58);
            this.btnVaciarCampos.TabIndex = 16;
            this.btnVaciarCampos.Text = "VACIAR CAMPOS";
            this.btnVaciarCampos.UseVisualStyleBackColor = true;
            this.btnVaciarCampos.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAltaExitoso
            // 
            this.labelAltaExitoso.AutoSize = true;
            this.labelAltaExitoso.Location = new System.Drawing.Point(560, 186);
            this.labelAltaExitoso.Name = "labelAltaExitoso";
            this.labelAltaExitoso.Size = new System.Drawing.Size(0, 13);
            this.labelAltaExitoso.TabIndex = 15;
            // 
            // buttonDarAlta
            // 
            this.buttonDarAlta.Location = new System.Drawing.Point(368, 325);
            this.buttonDarAlta.Name = "buttonDarAlta";
            this.buttonDarAlta.Size = new System.Drawing.Size(127, 53);
            this.buttonDarAlta.TabIndex = 14;
            this.buttonDarAlta.Text = "DAR DE ALTA";
            this.buttonDarAlta.UseVisualStyleBackColor = true;
            this.buttonDarAlta.Click += new System.EventHandler(this.buttonDarAlta_Click);
            // 
            // textBoxTel2
            // 
            this.textBoxTel2.Location = new System.Drawing.Point(158, 325);
            this.textBoxTel2.Name = "textBoxTel2";
            this.textBoxTel2.Size = new System.Drawing.Size(100, 20);
            this.textBoxTel2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefono 2";
            // 
            // textBoxTel1
            // 
            this.textBoxTel1.Location = new System.Drawing.Point(158, 282);
            this.textBoxTel1.Name = "textBoxTel1";
            this.textBoxTel1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTel1.TabIndex = 11;
            this.textBoxTel1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefono 1*";
            // 
            // textBoxPoblacion
            // 
            this.textBoxPoblacion.Location = new System.Drawing.Point(158, 241);
            this.textBoxPoblacion.Name = "textBoxPoblacion";
            this.textBoxPoblacion.Size = new System.Drawing.Size(153, 20);
            this.textBoxPoblacion.TabIndex = 9;
            this.textBoxPoblacion.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Poblacion*";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(158, 196);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(153, 20);
            this.textBoxDireccion.TabIndex = 7;
            this.textBoxDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion*";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(158, 154);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 5;
            this.textBoxDNI.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI*";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(158, 111);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidos.TabIndex = 3;
            this.textBoxApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos*";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(158, 68);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre*";
            // 
            // tabPageListado
            // 
            this.tabPageListado.Controls.Add(this.buttonListado);
            this.tabPageListado.Controls.Add(this.dataGridViewListado);
            this.tabPageListado.Location = new System.Drawing.Point(4, 22);
            this.tabPageListado.Name = "tabPageListado";
            this.tabPageListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListado.Size = new System.Drawing.Size(780, 412);
            this.tabPageListado.TabIndex = 1;
            this.tabPageListado.Text = "Listado";
            this.tabPageListado.UseVisualStyleBackColor = true;
            // 
            // buttonListado
            // 
            this.buttonListado.Location = new System.Drawing.Point(48, 15);
            this.buttonListado.Name = "buttonListado";
            this.buttonListado.Size = new System.Drawing.Size(146, 43);
            this.buttonListado.TabIndex = 1;
            this.buttonListado.Text = "CARGAR CLIENTES";
            this.buttonListado.UseVisualStyleBackColor = true;
            this.buttonListado.Click += new System.EventHandler(this.buttonListado_Click);
            // 
            // dataGridViewListado
            // 
            this.dataGridViewListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListado.Location = new System.Drawing.Point(24, 73);
            this.dataGridViewListado.Name = "dataGridViewListado";
            this.dataGridViewListado.Size = new System.Drawing.Size(726, 333);
            this.dataGridViewListado.TabIndex = 0;
            // 
            // tabPageBusqueda
            // 
            this.tabPageBusqueda.Controls.Add(this.label8);
            this.tabPageBusqueda.Controls.Add(this.txtBoxBusquedaDNI);
            this.tabPageBusqueda.Controls.Add(this.btnBusquedaDNI);
            this.tabPageBusqueda.Controls.Add(this.dataGridViewBusq);
            this.tabPageBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabPageBusqueda.Name = "tabPageBusqueda";
            this.tabPageBusqueda.Size = new System.Drawing.Size(780, 412);
            this.tabPageBusqueda.TabIndex = 2;
            this.tabPageBusqueda.Text = "Busqueda por DNI";
            this.tabPageBusqueda.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Introduzca un DNI a buscar:";
            // 
            // txtBoxBusquedaDNI
            // 
            this.txtBoxBusquedaDNI.Location = new System.Drawing.Point(29, 38);
            this.txtBoxBusquedaDNI.Name = "txtBoxBusquedaDNI";
            this.txtBoxBusquedaDNI.Size = new System.Drawing.Size(138, 20);
            this.txtBoxBusquedaDNI.TabIndex = 3;
            // 
            // btnBusquedaDNI
            // 
            this.btnBusquedaDNI.Location = new System.Drawing.Point(212, 15);
            this.btnBusquedaDNI.Name = "btnBusquedaDNI";
            this.btnBusquedaDNI.Size = new System.Drawing.Size(97, 43);
            this.btnBusquedaDNI.TabIndex = 2;
            this.btnBusquedaDNI.Text = "BUSCAR";
            this.btnBusquedaDNI.UseVisualStyleBackColor = true;
            this.btnBusquedaDNI.Click += new System.EventHandler(this.btnBusquedaDNI_Click);
            // 
            // dataGridViewBusq
            // 
            this.dataGridViewBusq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusq.Location = new System.Drawing.Point(29, 76);
            this.dataGridViewBusq.Name = "dataGridViewBusq";
            this.dataGridViewBusq.Size = new System.Drawing.Size(726, 333);
            this.dataGridViewBusq.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAlta.ResumeLayout(false);
            this.tabPageAlta.PerformLayout();
            this.tabPageListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListado)).EndInit();
            this.tabPageBusqueda.ResumeLayout(false);
            this.tabPageBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAlta;
        private System.Windows.Forms.TabPage tabPageListado;
        private System.Windows.Forms.TabPage tabPageBusqueda;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPoblacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDarAlta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelAltaExitoso;
        private System.Windows.Forms.DataGridView dataGridViewListado;
        private System.Windows.Forms.Button buttonListado;
        private System.Windows.Forms.Button btnVaciarCampos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxBusquedaDNI;
        private System.Windows.Forms.Button btnBusquedaDNI;
        private System.Windows.Forms.DataGridView dataGridViewBusq;
    }
}