
namespace AA_SistemasDeSeguridad
{
    partial class FormSistemas
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
            this.txtBoxPrecioSist = new System.Windows.Forms.TextBox();
            this.btnGuardarSistema = new System.Windows.Forms.Button();
            this.labelContadorSensores = new System.Windows.Forms.Label();
            this.btnAgregarColeccSensores = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoSensor = new System.Windows.Forms.ComboBox();
            this.textBoxCodInstalSensor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAlcanceSensor = new System.Windows.Forms.TextBox();
            this.labelVariable = new System.Windows.Forms.Label();
            this.textBoxPrecioSens = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCodSensor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelAltaExitoso = new System.Windows.Forms.Label();
            this.btnVaciarCampos = new System.Windows.Forms.Button();
            this.btnVaciarCamposSensor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCodSist = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.Label();
            this.tabPageListado = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListadoSens = new System.Windows.Forms.DataGridView();
            this.btnCargarSistemas = new System.Windows.Forms.Button();
            this.dataGridViewListadoSistemas = new System.Windows.Forms.DataGridView();
            this.tabPageBusqueda = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewBusquedaSens = new System.Windows.Forms.DataGridView();
            this.dataGridViewBusquedaSistemas = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxBusquedaCodSist = new System.Windows.Forms.TextBox();
            this.btnBusquedaSistemas = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageAlta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoSens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoSistemas)).BeginInit();
            this.tabPageBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaSens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaSistemas)).BeginInit();
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
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageAlta
            // 
            this.tabPageAlta.Controls.Add(this.txtBoxPrecioSist);
            this.tabPageAlta.Controls.Add(this.btnGuardarSistema);
            this.tabPageAlta.Controls.Add(this.labelContadorSensores);
            this.tabPageAlta.Controls.Add(this.btnAgregarColeccSensores);
            this.tabPageAlta.Controls.Add(this.groupBox1);
            this.tabPageAlta.Controls.Add(this.btnVaciarCampos);
            this.tabPageAlta.Controls.Add(this.btnVaciarCamposSensor);
            this.tabPageAlta.Controls.Add(this.label2);
            this.tabPageAlta.Controls.Add(this.txtBoxCodSist);
            this.tabPageAlta.Controls.Add(this.textBoxCodigo);
            this.tabPageAlta.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlta.Name = "tabPageAlta";
            this.tabPageAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlta.Size = new System.Drawing.Size(780, 412);
            this.tabPageAlta.TabIndex = 0;
            this.tabPageAlta.Text = "Alta";
            this.tabPageAlta.UseVisualStyleBackColor = true;
            // 
            // txtBoxPrecioSist
            // 
            this.txtBoxPrecioSist.Location = new System.Drawing.Point(149, 58);
            this.txtBoxPrecioSist.Name = "txtBoxPrecioSist";
            this.txtBoxPrecioSist.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrecioSist.TabIndex = 33;
            this.txtBoxPrecioSist.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCodSist_Validating);
            // 
            // btnGuardarSistema
            // 
            this.btnGuardarSistema.Location = new System.Drawing.Point(537, 167);
            this.btnGuardarSistema.Name = "btnGuardarSistema";
            this.btnGuardarSistema.Size = new System.Drawing.Size(147, 81);
            this.btnGuardarSistema.TabIndex = 32;
            this.btnGuardarSistema.Text = "GUARDAR SISTEMA";
            this.btnGuardarSistema.UseVisualStyleBackColor = true;
            this.btnGuardarSistema.Click += new System.EventHandler(this.btnGuardarSistema_Click);
            // 
            // labelContadorSensores
            // 
            this.labelContadorSensores.AutoSize = true;
            this.labelContadorSensores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContadorSensores.Location = new System.Drawing.Point(524, 116);
            this.labelContadorSensores.Name = "labelContadorSensores";
            this.labelContadorSensores.Size = new System.Drawing.Size(160, 18);
            this.labelContadorSensores.TabIndex = 31;
            this.labelContadorSensores.Text = "Contador de sensores:";
            // 
            // btnAgregarColeccSensores
            // 
            this.btnAgregarColeccSensores.Location = new System.Drawing.Point(167, 346);
            this.btnAgregarColeccSensores.Name = "btnAgregarColeccSensores";
            this.btnAgregarColeccSensores.Size = new System.Drawing.Size(105, 48);
            this.btnAgregarColeccSensores.TabIndex = 30;
            this.btnAgregarColeccSensores.Text = "AGREGAR SENSOR A LA COLECCIÓN";
            this.btnAgregarColeccSensores.UseVisualStyleBackColor = true;
            this.btnAgregarColeccSensores.Click += new System.EventHandler(this.btnAgregarColeccSensores_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTipoSensor);
            this.groupBox1.Controls.Add(this.textBoxCodInstalSensor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxAlcanceSensor);
            this.groupBox1.Controls.Add(this.labelVariable);
            this.groupBox1.Controls.Add(this.textBoxPrecioSens);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxCodSensor);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.labelAltaExitoso);
            this.groupBox1.Location = new System.Drawing.Point(149, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 226);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SENSOR";
            // 
            // comboBoxTipoSensor
            // 
            this.comboBoxTipoSensor.FormattingEnabled = true;
            this.comboBoxTipoSensor.Items.AddRange(new object[] {
            "INFRARROJO",
            "VOLUMETRICO",
            "TACTIL"});
            this.comboBoxTipoSensor.Location = new System.Drawing.Point(116, 61);
            this.comboBoxTipoSensor.Name = "comboBoxTipoSensor";
            this.comboBoxTipoSensor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoSensor.TabIndex = 39;
            this.comboBoxTipoSensor.SelectedValueChanged += new System.EventHandler(this.comboBoxTipoSensor_SelectedValueChanged);
            this.comboBoxTipoSensor.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCodSist_Validating);
            // 
            // textBoxCodInstalSensor
            // 
            this.textBoxCodInstalSensor.Location = new System.Drawing.Point(116, 192);
            this.textBoxCodInstalSensor.Name = "textBoxCodInstalSensor";
            this.textBoxCodInstalSensor.Size = new System.Drawing.Size(153, 20);
            this.textBoxCodInstalSensor.TabIndex = 38;
            this.textBoxCodInstalSensor.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCodSist_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Codigo Instalacion*";
            // 
            // textBoxAlcanceSensor
            // 
            this.textBoxAlcanceSensor.Location = new System.Drawing.Point(116, 147);
            this.textBoxAlcanceSensor.Name = "textBoxAlcanceSensor";
            this.textBoxAlcanceSensor.Size = new System.Drawing.Size(153, 20);
            this.textBoxAlcanceSensor.TabIndex = 36;
            this.textBoxAlcanceSensor.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCodSist_Validating);
            // 
            // labelVariable
            // 
            this.labelVariable.AutoSize = true;
            this.labelVariable.Location = new System.Drawing.Point(15, 154);
            this.labelVariable.Name = "labelVariable";
            this.labelVariable.Size = new System.Drawing.Size(50, 13);
            this.labelVariable.TabIndex = 35;
            this.labelVariable.Text = "Alcance*";
            // 
            // textBoxPrecioSens
            // 
            this.textBoxPrecioSens.Location = new System.Drawing.Point(116, 105);
            this.textBoxPrecioSens.Name = "textBoxPrecioSens";
            this.textBoxPrecioSens.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioSens.TabIndex = 34;
            this.textBoxPrecioSens.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCodSist_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Precio*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tipo*";
            // 
            // textBoxCodSensor
            // 
            this.textBoxCodSensor.Location = new System.Drawing.Point(116, 19);
            this.textBoxCodSensor.Name = "textBoxCodSensor";
            this.textBoxCodSensor.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodSensor.TabIndex = 31;
            this.textBoxCodSensor.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCodSist_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Codigo*";
            // 
            // labelAltaExitoso
            // 
            this.labelAltaExitoso.AutoSize = true;
            this.labelAltaExitoso.Location = new System.Drawing.Point(154, 160);
            this.labelAltaExitoso.Name = "labelAltaExitoso";
            this.labelAltaExitoso.Size = new System.Drawing.Size(0, 13);
            this.labelAltaExitoso.TabIndex = 29;
            // 
            // btnVaciarCampos
            // 
            this.btnVaciarCampos.Location = new System.Drawing.Point(552, 274);
            this.btnVaciarCampos.Name = "btnVaciarCampos";
            this.btnVaciarCampos.Size = new System.Drawing.Size(106, 58);
            this.btnVaciarCampos.TabIndex = 16;
            this.btnVaciarCampos.Text = "VACIAR TODOS LOS CAMPOS";
            this.btnVaciarCampos.UseVisualStyleBackColor = true;
            this.btnVaciarCampos.Click += new System.EventHandler(this.btnVaciarCampos_Click);
            // 
            // btnVaciarCamposSensor
            // 
            this.btnVaciarCamposSensor.Location = new System.Drawing.Point(312, 346);
            this.btnVaciarCamposSensor.Name = "btnVaciarCamposSensor";
            this.btnVaciarCamposSensor.Size = new System.Drawing.Size(119, 37);
            this.btnVaciarCamposSensor.TabIndex = 14;
            this.btnVaciarCamposSensor.Text = "Vaciar campos";
            this.btnVaciarCamposSensor.UseVisualStyleBackColor = true;
            this.btnVaciarCamposSensor.Click += new System.EventHandler(this.btnVaciarCamposSensor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio*";
            // 
            // txtBoxCodSist
            // 
            this.txtBoxCodSist.Location = new System.Drawing.Point(150, 21);
            this.txtBoxCodSist.Name = "txtBoxCodSist";
            this.txtBoxCodSist.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodSist.TabIndex = 1;
            this.txtBoxCodSist.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCodSist_Validating);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.AutoSize = true;
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(20, 22);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(124, 16);
            this.textBoxCodigo.TabIndex = 0;
            this.textBoxCodigo.Text = "Codigo Sistema*";
            // 
            // tabPageListado
            // 
            this.tabPageListado.Controls.Add(this.label1);
            this.tabPageListado.Controls.Add(this.dataGridViewListadoSens);
            this.tabPageListado.Controls.Add(this.btnCargarSistemas);
            this.tabPageListado.Controls.Add(this.dataGridViewListadoSistemas);
            this.tabPageListado.Location = new System.Drawing.Point(4, 22);
            this.tabPageListado.Name = "tabPageListado";
            this.tabPageListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListado.Size = new System.Drawing.Size(780, 412);
            this.tabPageListado.TabIndex = 1;
            this.tabPageListado.Text = "Listado";
            this.tabPageListado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pulsa sobre cualquiera de los sistemas para ver informacion sobre sus sensores";
            // 
            // dataGridViewListadoSens
            // 
            this.dataGridViewListadoSens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoSens.Location = new System.Drawing.Point(334, 174);
            this.dataGridViewListadoSens.Name = "dataGridViewListadoSens";
            this.dataGridViewListadoSens.Size = new System.Drawing.Size(386, 191);
            this.dataGridViewListadoSens.TabIndex = 2;
            // 
            // btnCargarSistemas
            // 
            this.btnCargarSistemas.Location = new System.Drawing.Point(48, 15);
            this.btnCargarSistemas.Name = "btnCargarSistemas";
            this.btnCargarSistemas.Size = new System.Drawing.Size(146, 43);
            this.btnCargarSistemas.TabIndex = 1;
            this.btnCargarSistemas.Text = "CARGAR SISTEMAS";
            this.btnCargarSistemas.UseVisualStyleBackColor = true;
            this.btnCargarSistemas.Click += new System.EventHandler(this.btnCargarSistemas_Click);
            // 
            // dataGridViewListadoSistemas
            // 
            this.dataGridViewListadoSistemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoSistemas.Location = new System.Drawing.Point(48, 64);
            this.dataGridViewListadoSistemas.Name = "dataGridViewListadoSistemas";
            this.dataGridViewListadoSistemas.Size = new System.Drawing.Size(228, 333);
            this.dataGridViewListadoSistemas.TabIndex = 0;
            this.dataGridViewListadoSistemas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListadoSistemas_CellClick);
            // 
            // tabPageBusqueda
            // 
            this.tabPageBusqueda.Controls.Add(this.label3);
            this.tabPageBusqueda.Controls.Add(this.dataGridViewBusquedaSens);
            this.tabPageBusqueda.Controls.Add(this.dataGridViewBusquedaSistemas);
            this.tabPageBusqueda.Controls.Add(this.label8);
            this.tabPageBusqueda.Controls.Add(this.txtBoxBusquedaCodSist);
            this.tabPageBusqueda.Controls.Add(this.btnBusquedaSistemas);
            this.tabPageBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabPageBusqueda.Name = "tabPageBusqueda";
            this.tabPageBusqueda.Size = new System.Drawing.Size(780, 412);
            this.tabPageBusqueda.TabIndex = 2;
            this.tabPageBusqueda.Text = "Busqueda por codigo de sensor";
            this.tabPageBusqueda.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pulsa sobre cualquiera de los sistemas para ver informacion sobre sus sensores";
            // 
            // dataGridViewBusquedaSens
            // 
            this.dataGridViewBusquedaSens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusquedaSens.Location = new System.Drawing.Point(294, 201);
            this.dataGridViewBusquedaSens.Name = "dataGridViewBusquedaSens";
            this.dataGridViewBusquedaSens.Size = new System.Drawing.Size(360, 164);
            this.dataGridViewBusquedaSens.TabIndex = 6;
            // 
            // dataGridViewBusquedaSistemas
            // 
            this.dataGridViewBusquedaSistemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusquedaSistemas.Location = new System.Drawing.Point(29, 92);
            this.dataGridViewBusquedaSistemas.Name = "dataGridViewBusquedaSistemas";
            this.dataGridViewBusquedaSistemas.Size = new System.Drawing.Size(202, 306);
            this.dataGridViewBusquedaSistemas.TabIndex = 5;
            this.dataGridViewBusquedaSistemas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListadoSistemas_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Introduzca el codigo del sistema a buscar:";
            // 
            // txtBoxBusquedaCodSist
            // 
            this.txtBoxBusquedaCodSist.Location = new System.Drawing.Point(29, 38);
            this.txtBoxBusquedaCodSist.Name = "txtBoxBusquedaCodSist";
            this.txtBoxBusquedaCodSist.Size = new System.Drawing.Size(138, 20);
            this.txtBoxBusquedaCodSist.TabIndex = 3;
            // 
            // btnBusquedaSistemas
            // 
            this.btnBusquedaSistemas.Location = new System.Drawing.Point(242, 15);
            this.btnBusquedaSistemas.Name = "btnBusquedaSistemas";
            this.btnBusquedaSistemas.Size = new System.Drawing.Size(97, 43);
            this.btnBusquedaSistemas.TabIndex = 2;
            this.btnBusquedaSistemas.Text = "BUSCAR";
            this.btnBusquedaSistemas.UseVisualStyleBackColor = true;
            this.btnBusquedaSistemas.Click += new System.EventHandler(this.btnBusquedaSistemas_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSistemas";
            this.Text = "FormSistemas";
            this.Load += new System.EventHandler(this.FormSistemas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAlta.ResumeLayout(false);
            this.tabPageAlta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageListado.ResumeLayout(false);
            this.tabPageListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoSens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoSistemas)).EndInit();
            this.tabPageBusqueda.ResumeLayout(false);
            this.tabPageBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaSens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaSistemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAlta;
        private System.Windows.Forms.Button btnVaciarCampos;
        private System.Windows.Forms.Button btnVaciarCamposSensor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCodSist;
        private System.Windows.Forms.Label textBoxCodigo;
        private System.Windows.Forms.TabPage tabPageListado;
        private System.Windows.Forms.Button btnCargarSistemas;
        private System.Windows.Forms.DataGridView dataGridViewListadoSistemas;
        private System.Windows.Forms.TabPage tabPageBusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxBusquedaCodSist;
        private System.Windows.Forms.Button btnBusquedaSistemas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTipoSensor;
        private System.Windows.Forms.TextBox textBoxCodInstalSensor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAlcanceSensor;
        private System.Windows.Forms.Label labelVariable;
        private System.Windows.Forms.TextBox textBoxPrecioSens;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCodSensor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelAltaExitoso;
        private System.Windows.Forms.Button btnGuardarSistema;
        private System.Windows.Forms.Label labelContadorSensores;
        private System.Windows.Forms.Button btnAgregarColeccSensores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListadoSens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewBusquedaSens;
        private System.Windows.Forms.DataGridView dataGridViewBusquedaSistemas;
        private System.Windows.Forms.TextBox txtBoxPrecioSist;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}