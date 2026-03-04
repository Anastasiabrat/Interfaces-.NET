
namespace AA_SistemasDeSeguridad
{
    partial class FormSensores
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
            this.textBoxTempAlcance = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.btnVaciarCampos = new System.Windows.Forms.Button();
            this.labelAltaExitoso = new System.Windows.Forms.Label();
            this.buttonDarAlta = new System.Windows.Forms.Button();
            this.textBoxCodigoInstalacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTempAlcance = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.tabPageListado = new System.Windows.Forms.TabPage();
            this.buttonListado = new System.Windows.Forms.Button();
            this.dataGridViewSensoresList = new System.Windows.Forms.DataGridView();
            this.tabPageBusqueda = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxBusquedaCodigo = new System.Windows.Forms.TextBox();
            this.btnBusquedaDNI = new System.Windows.Forms.Button();
            this.dataGridViewSensoresBusq = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageAlta.SuspendLayout();
            this.tabPageListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensoresList)).BeginInit();
            this.tabPageBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensoresBusq)).BeginInit();
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
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageAlta
            // 
            this.tabPageAlta.Controls.Add(this.textBoxTempAlcance);
            this.tabPageAlta.Controls.Add(this.comboBoxTipo);
            this.tabPageAlta.Controls.Add(this.btnVaciarCampos);
            this.tabPageAlta.Controls.Add(this.labelAltaExitoso);
            this.tabPageAlta.Controls.Add(this.buttonDarAlta);
            this.tabPageAlta.Controls.Add(this.textBoxCodigoInstalacion);
            this.tabPageAlta.Controls.Add(this.label5);
            this.tabPageAlta.Controls.Add(this.labelTempAlcance);
            this.tabPageAlta.Controls.Add(this.textBoxPrecio);
            this.tabPageAlta.Controls.Add(this.label3);
            this.tabPageAlta.Controls.Add(this.label2);
            this.tabPageAlta.Controls.Add(this.textBoxCodigo);
            this.tabPageAlta.Controls.Add(this.labelCodigo);
            this.tabPageAlta.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlta.Name = "tabPageAlta";
            this.tabPageAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlta.Size = new System.Drawing.Size(780, 412);
            this.tabPageAlta.TabIndex = 0;
            this.tabPageAlta.Text = "Alta";
            this.tabPageAlta.UseVisualStyleBackColor = true;
            // 
            // textBoxTempAlcance
            // 
            this.textBoxTempAlcance.Location = new System.Drawing.Point(32, 223);
            this.textBoxTempAlcance.Name = "textBoxTempAlcance";
            this.textBoxTempAlcance.Size = new System.Drawing.Size(112, 20);
            this.textBoxTempAlcance.TabIndex = 19;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "INFRARROJO",
            "VOLUMETRICO",
            "TACTIL"});
            this.comboBoxTipo.Location = new System.Drawing.Point(158, 110);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 17;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            this.comboBoxTipo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // btnVaciarCampos
            // 
            this.btnVaciarCampos.Location = new System.Drawing.Point(532, 322);
            this.btnVaciarCampos.Name = "btnVaciarCampos";
            this.btnVaciarCampos.Size = new System.Drawing.Size(83, 58);
            this.btnVaciarCampos.TabIndex = 16;
            this.btnVaciarCampos.Text = "VACIAR CAMPOS";
            this.btnVaciarCampos.UseVisualStyleBackColor = true;
            this.btnVaciarCampos.Click += new System.EventHandler(this.buttonLimpiar_Click);
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
            // textBoxCodigoInstalacion
            // 
            this.textBoxCodigoInstalacion.Location = new System.Drawing.Point(158, 276);
            this.textBoxCodigoInstalacion.Name = "textBoxCodigoInstalacion";
            this.textBoxCodigoInstalacion.Size = new System.Drawing.Size(153, 20);
            this.textBoxCodigoInstalacion.TabIndex = 9;
            this.textBoxCodigoInstalacion.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo Instalacion*";
            // 
            // labelTempAlcance
            // 
            this.labelTempAlcance.AutoSize = true;
            this.labelTempAlcance.Location = new System.Drawing.Point(29, 207);
            this.labelTempAlcance.Name = "labelTempAlcance";
            this.labelTempAlcance.Size = new System.Drawing.Size(117, 13);
            this.labelTempAlcance.TabIndex = 6;
            this.labelTempAlcance.Text = "Temperatura / Alcance";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(158, 154);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 5;
            this.textBoxPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio*";
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
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(158, 68);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(29, 75);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(44, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo*";
            // 
            // tabPageListado
            // 
            this.tabPageListado.Controls.Add(this.buttonListado);
            this.tabPageListado.Controls.Add(this.dataGridViewSensoresList);
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
            this.buttonListado.Text = "CARGAR SENSORES";
            this.buttonListado.UseVisualStyleBackColor = true;
            this.buttonListado.Click += new System.EventHandler(this.buttonListado_Click);
            // 
            // dataGridViewSensoresList
            // 
            this.dataGridViewSensoresList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSensoresList.Location = new System.Drawing.Point(24, 73);
            this.dataGridViewSensoresList.Name = "dataGridViewSensoresList";
            this.dataGridViewSensoresList.Size = new System.Drawing.Size(726, 333);
            this.dataGridViewSensoresList.TabIndex = 0;
            // 
            // tabPageBusqueda
            // 
            this.tabPageBusqueda.Controls.Add(this.label8);
            this.tabPageBusqueda.Controls.Add(this.txtBoxBusquedaCodigo);
            this.tabPageBusqueda.Controls.Add(this.btnBusquedaDNI);
            this.tabPageBusqueda.Controls.Add(this.dataGridViewSensoresBusq);
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
            this.label8.Size = new System.Drawing.Size(201, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Introduzca el codigo del sensor a buscar:";
            // 
            // txtBoxBusquedaCodigo
            // 
            this.txtBoxBusquedaCodigo.Location = new System.Drawing.Point(29, 38);
            this.txtBoxBusquedaCodigo.Name = "txtBoxBusquedaCodigo";
            this.txtBoxBusquedaCodigo.Size = new System.Drawing.Size(138, 20);
            this.txtBoxBusquedaCodigo.TabIndex = 3;
            // 
            // btnBusquedaDNI
            // 
            this.btnBusquedaDNI.Location = new System.Drawing.Point(242, 15);
            this.btnBusquedaDNI.Name = "btnBusquedaDNI";
            this.btnBusquedaDNI.Size = new System.Drawing.Size(97, 43);
            this.btnBusquedaDNI.TabIndex = 2;
            this.btnBusquedaDNI.Text = "BUSCAR";
            this.btnBusquedaDNI.UseVisualStyleBackColor = true;
            this.btnBusquedaDNI.Click += new System.EventHandler(this.btnBusquedaCodigo_Click);
            // 
            // dataGridViewSensoresBusq
            // 
            this.dataGridViewSensoresBusq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSensoresBusq.Location = new System.Drawing.Point(29, 76);
            this.dataGridViewSensoresBusq.Name = "dataGridViewSensoresBusq";
            this.dataGridViewSensoresBusq.Size = new System.Drawing.Size(726, 333);
            this.dataGridViewSensoresBusq.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSensores";
            this.Text = "FormSensores";
            this.Load += new System.EventHandler(this.FormSensores_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAlta.ResumeLayout(false);
            this.tabPageAlta.PerformLayout();
            this.tabPageListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensoresList)).EndInit();
            this.tabPageBusqueda.ResumeLayout(false);
            this.tabPageBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensoresBusq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAlta;
        private System.Windows.Forms.Button btnVaciarCampos;
        private System.Windows.Forms.Label labelAltaExitoso;
        private System.Windows.Forms.Button buttonDarAlta;
        private System.Windows.Forms.TextBox textBoxCodigoInstalacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTempAlcance;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TabPage tabPageListado;
        private System.Windows.Forms.Button buttonListado;
        private System.Windows.Forms.DataGridView dataGridViewSensoresList;
        private System.Windows.Forms.TabPage tabPageBusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxBusquedaCodigo;
        private System.Windows.Forms.Button btnBusquedaDNI;
        private System.Windows.Forms.DataGridView dataGridViewSensoresBusq;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxTempAlcance;
    }
}