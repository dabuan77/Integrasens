namespace Informes_Integrasens
{
    partial class FormPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacientes));
            this.textBoxNif = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApell1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolBarraPacientes = new System.Windows.Forms.ToolStrip();
            this.toolStripAltaPaciente = new System.Windows.Forms.ToolStripButton();
            this.toolStripAñadirPaciente = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNifRepre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupPacientes = new System.Windows.Forms.GroupBox();
            this.dataGridPacientes = new System.Windows.Forms.DataGridView();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.integrasensDataSet = new Informes_Integrasens.IntegrasensDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxApell2 = new System.Windows.Forms.TextBox();
            this.textBoxMovil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pacientesTableAdapter = new Informes_Integrasens.IntegrasensDataSetTableAdapters.PacientesTableAdapter();
            this.dataGridViewTxtNif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTxtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTxtApellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTxtApellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTxtFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTxtProvinvia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTxtPoblacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTxtMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTxtMovil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTxtIdPac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolBarraPacientes.SuspendLayout();
            this.groupPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrasensDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNif
            // 
            this.textBoxNif.Location = new System.Drawing.Point(51, 42);
            this.textBoxNif.Name = "textBoxNif";
            this.textBoxNif.Size = new System.Drawing.Size(100, 20);
            this.textBoxNif.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(421, 42);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxApell1
            // 
            this.textBoxApell1.Location = new System.Drawing.Point(592, 42);
            this.textBoxApell1.Name = "textBoxApell1";
            this.textBoxApell1.Size = new System.Drawing.Size(100, 20);
            this.textBoxApell1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // toolBarraPacientes
            // 
            this.toolBarraPacientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAltaPaciente,
            this.toolStripAñadirPaciente,
            this.toolStripBuscar,
            this.toolStripLabel1});
            this.toolBarraPacientes.Location = new System.Drawing.Point(0, 0);
            this.toolBarraPacientes.Name = "toolBarraPacientes";
            this.toolBarraPacientes.Size = new System.Drawing.Size(1074, 25);
            this.toolBarraPacientes.TabIndex = 10;
            this.toolBarraPacientes.Text = "toolStrip1";
            // 
            // toolStripAltaPaciente
            // 
            this.toolStripAltaPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAltaPaciente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAltaPaciente.Image")));
            this.toolStripAltaPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAltaPaciente.Name = "toolStripAltaPaciente";
            this.toolStripAltaPaciente.Size = new System.Drawing.Size(23, 22);
            this.toolStripAltaPaciente.Text = "toolStripButton1";
            this.toolStripAltaPaciente.Click += new System.EventHandler(this.ToolStripAltaPaciente_Click);
            // 
            // toolStripAñadirPaciente
            // 
            this.toolStripAñadirPaciente.Name = "toolStripAñadirPaciente";
            this.toolStripAñadirPaciente.Size = new System.Drawing.Size(90, 22);
            this.toolStripAñadirPaciente.Text = "Añadir Paciente";
            this.toolStripAñadirPaciente.ToolTipText = "Añadir Paciente";
            // 
            // toolStripBuscar
            // 
            this.toolStripBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBuscar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBuscar.Image")));
            this.toolStripBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBuscar.Name = "toolStripBuscar";
            this.toolStripBuscar.Size = new System.Drawing.Size(23, 22);
            this.toolStripBuscar.Text = "Buscar";
            this.toolStripBuscar.Click += new System.EventHandler(this.ToolStripBuscar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nif Representante";
            // 
            // textBoxNifRepre
            // 
            this.textBoxNifRepre.Location = new System.Drawing.Point(259, 42);
            this.textBoxNifRepre.Name = "textBoxNifRepre";
            this.textBoxNifRepre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNifRepre.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Apellido 1";
            // 
            // groupPacientes
            // 
            this.groupPacientes.Controls.Add(this.dataGridPacientes);
            this.groupPacientes.Location = new System.Drawing.Point(28, 85);
            this.groupPacientes.Name = "groupPacientes";
            this.groupPacientes.Size = new System.Drawing.Size(1009, 415);
            this.groupPacientes.TabIndex = 18;
            this.groupPacientes.TabStop = false;
            this.groupPacientes.Text = "Listado de Pacientes";
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.AllowUserToAddRows = false;
            this.dataGridPacientes.AllowUserToDeleteRows = false;
            this.dataGridPacientes.AutoGenerateColumns = false;
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTxtNif,
            this.Column2,
            this.dataGridViewTxtNombre,
            this.dataGridViewTxtApellido1,
            this.dataGridViewTxtApellido2,
            this.dataGridViewTxtFechaNacimiento,
            this.DataGridViewTxtProvinvia,
            this.DataGridViewTxtPoblacion,
            this.dataGridViewTxtMail,
            this.dataGridViewTxtMovil,
            this.dataGridViewTxtIdPac});
            this.dataGridPacientes.DataSource = this.pacientesBindingSource;
            this.dataGridPacientes.Location = new System.Drawing.Point(45, 37);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.ReadOnly = true;
            this.dataGridPacientes.RowHeadersVisible = false;
            this.dataGridPacientes.Size = new System.Drawing.Size(912, 350);
            this.dataGridPacientes.TabIndex = 0;
            this.dataGridPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacientes_CellContentClick);
            this.dataGridPacientes.DoubleClick += new System.EventHandler(this.DataGridPacientes_DoubleClick);
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.integrasensDataSet;
            // 
            // integrasensDataSet
            // 
            this.integrasensDataSet.DataSetName = "IntegrasensDataSet";
            this.integrasensDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(707, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Apellido 2";
            // 
            // textBoxApell2
            // 
            this.textBoxApell2.Location = new System.Drawing.Point(766, 42);
            this.textBoxApell2.Name = "textBoxApell2";
            this.textBoxApell2.Size = new System.Drawing.Size(100, 20);
            this.textBoxApell2.TabIndex = 16;
            // 
            // textBoxMovil
            // 
            this.textBoxMovil.Location = new System.Drawing.Point(930, 42);
            this.textBoxMovil.Name = "textBoxMovil";
            this.textBoxMovil.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovil.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(892, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Movil";
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTxtNif
            // 
            this.dataGridViewTxtNif.DataPropertyName = "Nif";
            this.dataGridViewTxtNif.HeaderText = "Nif";
            this.dataGridViewTxtNif.Name = "dataGridViewTxtNif";
            this.dataGridViewTxtNif.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Id_Paciente";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // dataGridViewTxtNombre
            // 
            this.dataGridViewTxtNombre.DataPropertyName = "Nombre";
            this.dataGridViewTxtNombre.HeaderText = "Nombre";
            this.dataGridViewTxtNombre.Name = "dataGridViewTxtNombre";
            this.dataGridViewTxtNombre.ReadOnly = true;
            // 
            // dataGridViewTxtApellido1
            // 
            this.dataGridViewTxtApellido1.DataPropertyName = "Apellido1";
            this.dataGridViewTxtApellido1.HeaderText = "Apellido 1";
            this.dataGridViewTxtApellido1.Name = "dataGridViewTxtApellido1";
            this.dataGridViewTxtApellido1.ReadOnly = true;
            // 
            // dataGridViewTxtApellido2
            // 
            this.dataGridViewTxtApellido2.DataPropertyName = "Apellido2";
            this.dataGridViewTxtApellido2.HeaderText = "Apellido 2";
            this.dataGridViewTxtApellido2.Name = "dataGridViewTxtApellido2";
            this.dataGridViewTxtApellido2.ReadOnly = true;
            // 
            // dataGridViewTxtFechaNacimiento
            // 
            this.dataGridViewTxtFechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTxtFechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.dataGridViewTxtFechaNacimiento.Name = "dataGridViewTxtFechaNacimiento";
            this.dataGridViewTxtFechaNacimiento.ReadOnly = true;
            this.dataGridViewTxtFechaNacimiento.Width = 108;
            // 
            // DataGridViewTxtProvinvia
            // 
            this.DataGridViewTxtProvinvia.DataPropertyName = "Provincia";
            this.DataGridViewTxtProvinvia.HeaderText = "Provincia";
            this.DataGridViewTxtProvinvia.Name = "DataGridViewTxtProvinvia";
            this.DataGridViewTxtProvinvia.ReadOnly = true;
            // 
            // DataGridViewTxtPoblacion
            // 
            this.DataGridViewTxtPoblacion.DataPropertyName = "Poblacion";
            this.DataGridViewTxtPoblacion.HeaderText = "Poblacion";
            this.DataGridViewTxtPoblacion.Name = "DataGridViewTxtPoblacion";
            this.DataGridViewTxtPoblacion.ReadOnly = true;
            // 
            // dataGridViewTxtMail
            // 
            this.dataGridViewTxtMail.DataPropertyName = "Mail";
            this.dataGridViewTxtMail.HeaderText = "Mail";
            this.dataGridViewTxtMail.Name = "dataGridViewTxtMail";
            this.dataGridViewTxtMail.ReadOnly = true;
            // 
            // dataGridViewTxtMovil
            // 
            this.dataGridViewTxtMovil.DataPropertyName = "Movil";
            this.dataGridViewTxtMovil.HeaderText = "Movil";
            this.dataGridViewTxtMovil.Name = "dataGridViewTxtMovil";
            this.dataGridViewTxtMovil.ReadOnly = true;
            // 
            // dataGridViewTxtIdPac
            // 
            this.dataGridViewTxtIdPac.DataPropertyName = "Id_Paciente";
            this.dataGridViewTxtIdPac.HeaderText = "Id_Paciente";
            this.dataGridViewTxtIdPac.Name = "dataGridViewTxtIdPac";
            this.dataGridViewTxtIdPac.ReadOnly = true;
            this.dataGridViewTxtIdPac.Visible = false;
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 512);
            this.Controls.Add(this.textBoxMovil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupPacientes);
            this.Controls.Add(this.textBoxApell2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNifRepre);
            this.Controls.Add(this.toolBarraPacientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxApell1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxNif);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPacientes";
            this.Load += new System.EventHandler(this.FormPacientes_Load);
            this.toolBarraPacientes.ResumeLayout(false);
            this.toolBarraPacientes.PerformLayout();
            this.groupPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrasensDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.TextBox textBoxNif;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApell1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolBarraPacientes;
        private System.Windows.Forms.ToolStripButton toolStripAltaPaciente;
        private System.Windows.Forms.ToolStripLabel toolStripAñadirPaciente;
        private System.Windows.Forms.ToolStripButton toolStripBuscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNifRepre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifrepresentanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePadreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMadreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movilDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxApell2;
        private System.Windows.Forms.TextBox textBoxMovil;
        private System.Windows.Forms.Label label4;
     
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView dataGridPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private IntegrasensDataSet integrasensDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private IntegrasensDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patologiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTxtNif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTxtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTxtApellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTxtApellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTxtFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTxtProvinvia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTxtPoblacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTxtMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTxtMovil;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTxtIdPac;
    }
}