
namespace AA_OrdinariaDistancia
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxEditores = new System.Windows.Forms.ComboBox();
            this.checkBoxFiltrarEditores = new System.Windows.Forms.CheckBox();
            this.textBoxFiltrarTexto = new System.Windows.Forms.TextBox();
            this.checkBoxFiltrarTexto = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConsultar = new System.Windows.Forms.ToolStripButton();
            this.buttonPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 206);
            this.dataGridView1.TabIndex = 9;
            // 
            // comboBoxEditores
            // 
            this.comboBoxEditores.FormattingEnabled = true;
            this.comboBoxEditores.Location = new System.Drawing.Point(439, 77);
            this.comboBoxEditores.Name = "comboBoxEditores";
            this.comboBoxEditores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEditores.TabIndex = 8;
            // 
            // checkBoxFiltrarEditores
            // 
            this.checkBoxFiltrarEditores.AutoSize = true;
            this.checkBoxFiltrarEditores.Location = new System.Drawing.Point(344, 81);
            this.checkBoxFiltrarEditores.Name = "checkBoxFiltrarEditores";
            this.checkBoxFiltrarEditores.Size = new System.Drawing.Size(64, 17);
            this.checkBoxFiltrarEditores.TabIndex = 7;
            this.checkBoxFiltrarEditores.Text = "Editores";
            this.checkBoxFiltrarEditores.UseVisualStyleBackColor = true;
            this.checkBoxFiltrarEditores.CheckedChanged += new System.EventHandler(this.checkBoxFiltrarEditores_CheckedChanged);
            // 
            // textBoxFiltrarTexto
            // 
            this.textBoxFiltrarTexto.Location = new System.Drawing.Point(123, 78);
            this.textBoxFiltrarTexto.Name = "textBoxFiltrarTexto";
            this.textBoxFiltrarTexto.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltrarTexto.TabIndex = 6;
            // 
            // checkBoxFiltrarTexto
            // 
            this.checkBoxFiltrarTexto.AutoSize = true;
            this.checkBoxFiltrarTexto.Location = new System.Drawing.Point(21, 82);
            this.checkBoxFiltrarTexto.Name = "checkBoxFiltrarTexto";
            this.checkBoxFiltrarTexto.Size = new System.Drawing.Size(53, 17);
            this.checkBoxFiltrarTexto.TabIndex = 5;
            this.checkBoxFiltrarTexto.Text = "Texto";
            this.checkBoxFiltrarTexto.UseVisualStyleBackColor = true;
            this.checkBoxFiltrarTexto.CheckedChanged += new System.EventHandler(this.checkBoxFiltrarTexto_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConsultar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonConsultar
            // 
            this.toolStripButtonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConsultar.Image")));
            this.toolStripButtonConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConsultar.Name = "toolStripButtonConsultar";
            this.toolStripButtonConsultar.Size = new System.Drawing.Size(62, 35);
            this.toolStripButtonConsultar.Text = "Consultar";
            this.toolStripButtonConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonConsultar.Click += new System.EventHandler(this.toolStripButtonConsultar_Click);
            // 
            // buttonPDF
            // 
            this.buttonPDF.Location = new System.Drawing.Point(544, 215);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(75, 69);
            this.buttonPDF.TabIndex = 11;
            this.buttonPDF.Text = "hacer PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPDF);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxEditores);
            this.Controls.Add(this.checkBoxFiltrarEditores);
            this.Controls.Add(this.textBoxFiltrarTexto);
            this.Controls.Add(this.checkBoxFiltrarTexto);
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxEditores;
        private System.Windows.Forms.CheckBox checkBoxFiltrarEditores;
        private System.Windows.Forms.TextBox textBoxFiltrarTexto;
        private System.Windows.Forms.CheckBox checkBoxFiltrarTexto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonConsultar;
        private System.Windows.Forms.Button buttonPDF;
    }
}