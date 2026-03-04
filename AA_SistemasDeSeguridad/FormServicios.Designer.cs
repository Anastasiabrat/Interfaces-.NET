
namespace AA_SistemasDeSeguridad
{
    partial class FormServicios
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxMinutos = new System.Windows.Forms.TextBox();
            this.labelMinutos = new System.Windows.Forms.Label();
            this.buttonAgregarSensor = new System.Windows.Forms.Button();
            this.textBoxDniCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.btnVaciarCampos = new System.Windows.Forms.Button();
            this.labelAltaExitoso = new System.Windows.Forms.Label();
            this.buttonDarAlta = new System.Windows.Forms.Button();
            this.textBoxCodigoSensor = new System.Windows.Forms.TextBox();
            this.labelCodSensores = new System.Windows.Forms.Label();
            this.textBoxCodSistAsoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodServicio = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.Label();
            this.tabPageListado = new System.Windows.Forms.TabPage();
            this.buttonListado = new System.Windows.Forms.Button();
            this.dataGridViewListadoServicios = new System.Windows.Forms.DataGridView();
            this.tabPageBusqueda = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxBusquedaCodSensor = new System.Windows.Forms.TextBox();
            this.btnBusquedaDNI = new System.Windows.Forms.Button();
            this.dataGridViewBusquedaServ = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageAlta.SuspendLayout();
            this.tabPageListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoServicios)).BeginInit();
            this.tabPageBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAlta);
            this.tabControl1.Controls.Add(this.tabPageListado);
            this.tabControl1.Controls.Add(this.tabPageBusqueda);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageAlta
            // 
            this.tabPageAlta.Controls.Add(this.dateTimePicker1);
            this.tabPageAlta.Controls.Add(this.textBoxMinutos);
            this.tabPageAlta.Controls.Add(this.labelMinutos);
            this.tabPageAlta.Controls.Add(this.buttonAgregarSensor);
            this.tabPageAlta.Controls.Add(this.textBoxDniCliente);
            this.tabPageAlta.Controls.Add(this.label6);
            this.tabPageAlta.Controls.Add(this.comboBoxTipo);
            this.tabPageAlta.Controls.Add(this.btnVaciarCampos);
            this.tabPageAlta.Controls.Add(this.labelAltaExitoso);
            this.tabPageAlta.Controls.Add(this.buttonDarAlta);
            this.tabPageAlta.Controls.Add(this.textBoxCodigoSensor);
            this.tabPageAlta.Controls.Add(this.labelCodSensores);
            this.tabPageAlta.Controls.Add(this.textBoxCodSistAsoc);
            this.tabPageAlta.Controls.Add(this.label4);
            this.tabPageAlta.Controls.Add(this.label3);
            this.tabPageAlta.Controls.Add(this.label2);
            this.tabPageAlta.Controls.Add(this.textBoxCodServicio);
            this.tabPageAlta.Controls.Add(this.textBoxCodigo);
            this.tabPageAlta.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlta.Name = "tabPageAlta";
            this.tabPageAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlta.Size = new System.Drawing.Size(780, 412);
            this.tabPageAlta.TabIndex = 0;
            this.tabPageAlta.Text = "Alta";
            this.tabPageAlta.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // textBoxMinutos
            // 
            this.textBoxMinutos.Location = new System.Drawing.Point(158, 240);
            this.textBoxMinutos.Name = "textBoxMinutos";
            this.textBoxMinutos.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinutos.TabIndex = 23;
            // 
            // labelMinutos
            // 
            this.labelMinutos.AutoSize = true;
            this.labelMinutos.Location = new System.Drawing.Point(29, 247);
            this.labelMinutos.Name = "labelMinutos";
            this.labelMinutos.Size = new System.Drawing.Size(44, 13);
            this.labelMinutos.TabIndex = 22;
            this.labelMinutos.Text = "Minutos";
            // 
            // buttonAgregarSensor
            // 
            this.buttonAgregarSensor.Location = new System.Drawing.Point(158, 316);
            this.buttonAgregarSensor.Name = "buttonAgregarSensor";
            this.buttonAgregarSensor.Size = new System.Drawing.Size(100, 23);
            this.buttonAgregarSensor.TabIndex = 21;
            this.buttonAgregarSensor.Text = "Agregar Sensor";
            this.buttonAgregarSensor.UseVisualStyleBackColor = true;
            this.buttonAgregarSensor.Click += new System.EventHandler(this.buttonAgregarSensor_Click);
            // 
            // textBoxDniCliente
            // 
            this.textBoxDniCliente.Location = new System.Drawing.Point(158, 69);
            this.textBoxDniCliente.Name = "textBoxDniCliente";
            this.textBoxDniCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxDniCliente.TabIndex = 20;
            this.textBoxDniCliente.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "DNI Cliente*";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "VENTA",
            "REPARACION"});
            this.comboBoxTipo.Location = new System.Drawing.Point(158, 110);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 17;
            this.comboBoxTipo.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // btnVaciarCampos
            // 
            this.btnVaciarCampos.Location = new System.Drawing.Point(532, 322);
            this.btnVaciarCampos.Name = "btnVaciarCampos";
            this.btnVaciarCampos.Size = new System.Drawing.Size(83, 58);
            this.btnVaciarCampos.TabIndex = 16;
            this.btnVaciarCampos.Text = "VACIAR CAMPOS";
            this.btnVaciarCampos.UseVisualStyleBackColor = true;
            this.btnVaciarCampos.Click += new System.EventHandler(this.btnVaciarCampos_Click);
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
            // textBoxCodigoSensor
            // 
            this.textBoxCodigoSensor.Location = new System.Drawing.Point(158, 281);
            this.textBoxCodigoSensor.Name = "textBoxCodigoSensor";
            this.textBoxCodigoSensor.Size = new System.Drawing.Size(78, 20);
            this.textBoxCodigoSensor.TabIndex = 9;
            // 
            // labelCodSensores
            // 
            this.labelCodSensores.AutoSize = true;
            this.labelCodSensores.Location = new System.Drawing.Point(29, 288);
            this.labelCodSensores.Name = "labelCodSensores";
            this.labelCodSensores.Size = new System.Drawing.Size(105, 13);
            this.labelCodSensores.TabIndex = 8;
            this.labelCodSensores.Text = "Codigo SENSORES:";
            // 
            // textBoxCodSistAsoc
            // 
            this.textBoxCodSistAsoc.Location = new System.Drawing.Point(223, 200);
            this.textBoxCodSistAsoc.Name = "textBoxCodSistAsoc";
            this.textBoxCodSistAsoc.Size = new System.Drawing.Size(153, 20);
            this.textBoxCodSistAsoc.TabIndex = 7;
            this.textBoxCodSistAsoc.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo sistema de seguridad asociado*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo*";
            // 
            // textBoxCodServicio
            // 
            this.textBoxCodServicio.Location = new System.Drawing.Point(158, 31);
            this.textBoxCodServicio.Name = "textBoxCodServicio";
            this.textBoxCodServicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodServicio.TabIndex = 1;
            this.textBoxCodServicio.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.AutoSize = true;
            this.textBoxCodigo.Location = new System.Drawing.Point(29, 38);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(44, 13);
            this.textBoxCodigo.TabIndex = 0;
            this.textBoxCodigo.Text = "Codigo*";
            // 
            // tabPageListado
            // 
            this.tabPageListado.Controls.Add(this.buttonListado);
            this.tabPageListado.Controls.Add(this.dataGridViewListadoServicios);
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
            this.buttonListado.Text = "CARGAR SERVICIOS";
            this.buttonListado.UseVisualStyleBackColor = true;
            this.buttonListado.Click += new System.EventHandler(this.buttonListado_Click);
            // 
            // dataGridViewListadoServicios
            // 
            this.dataGridViewListadoServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoServicios.Location = new System.Drawing.Point(24, 73);
            this.dataGridViewListadoServicios.Name = "dataGridViewListadoServicios";
            this.dataGridViewListadoServicios.Size = new System.Drawing.Size(726, 333);
            this.dataGridViewListadoServicios.TabIndex = 0;
            // 
            // tabPageBusqueda
            // 
            this.tabPageBusqueda.Controls.Add(this.label8);
            this.tabPageBusqueda.Controls.Add(this.txtBoxBusquedaCodSensor);
            this.tabPageBusqueda.Controls.Add(this.btnBusquedaDNI);
            this.tabPageBusqueda.Controls.Add(this.dataGridViewBusquedaServ);
            this.tabPageBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabPageBusqueda.Name = "tabPageBusqueda";
            this.tabPageBusqueda.Size = new System.Drawing.Size(780, 412);
            this.tabPageBusqueda.TabIndex = 2;
            this.tabPageBusqueda.Text = "Busqueda por codigo de sensor";
            this.tabPageBusqueda.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Introduzca el DNI del Cliente a buscar:";
            // 
            // txtBoxBusquedaCodSensor
            // 
            this.txtBoxBusquedaCodSensor.Location = new System.Drawing.Point(29, 38);
            this.txtBoxBusquedaCodSensor.Name = "txtBoxBusquedaCodSensor";
            this.txtBoxBusquedaCodSensor.Size = new System.Drawing.Size(138, 20);
            this.txtBoxBusquedaCodSensor.TabIndex = 3;
            // 
            // btnBusquedaDNI
            // 
            this.btnBusquedaDNI.Location = new System.Drawing.Point(242, 15);
            this.btnBusquedaDNI.Name = "btnBusquedaDNI";
            this.btnBusquedaDNI.Size = new System.Drawing.Size(97, 43);
            this.btnBusquedaDNI.TabIndex = 2;
            this.btnBusquedaDNI.Text = "BUSCAR";
            this.btnBusquedaDNI.UseVisualStyleBackColor = true;
            this.btnBusquedaDNI.Click += new System.EventHandler(this.btnBusquedaDNI_Click);
            // 
            // dataGridViewBusquedaServ
            // 
            this.dataGridViewBusquedaServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusquedaServ.Location = new System.Drawing.Point(29, 76);
            this.dataGridViewBusquedaServ.Name = "dataGridViewBusquedaServ";
            this.dataGridViewBusquedaServ.Size = new System.Drawing.Size(726, 333);
            this.dataGridViewBusquedaServ.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormServicios";
            this.Text = "FormServicios";
            this.Load += new System.EventHandler(this.FormServicios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAlta.ResumeLayout(false);
            this.tabPageAlta.PerformLayout();
            this.tabPageListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoServicios)).EndInit();
            this.tabPageBusqueda.ResumeLayout(false);
            this.tabPageBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAlta;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button btnVaciarCampos;
        private System.Windows.Forms.Label labelAltaExitoso;
        private System.Windows.Forms.Button buttonDarAlta;
        private System.Windows.Forms.TextBox textBoxCodigoSensor;
        private System.Windows.Forms.Label labelCodSensores;
        private System.Windows.Forms.TextBox textBoxCodSistAsoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodServicio;
        private System.Windows.Forms.Label textBoxCodigo;
        private System.Windows.Forms.TabPage tabPageListado;
        private System.Windows.Forms.Button buttonListado;
        private System.Windows.Forms.DataGridView dataGridViewListadoServicios;
        private System.Windows.Forms.TabPage tabPageBusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxBusquedaCodSensor;
        private System.Windows.Forms.Button btnBusquedaDNI;
        private System.Windows.Forms.DataGridView dataGridViewBusquedaServ;
        private System.Windows.Forms.TextBox textBoxDniCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAgregarSensor;
        private System.Windows.Forms.TextBox textBoxMinutos;
        private System.Windows.Forms.Label labelMinutos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}