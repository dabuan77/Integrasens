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
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxApell2 = new System.Windows.Forms.TextBox();
            this.textBoxMovil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolBarraPacientes.SuspendLayout();
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
            this.textBoxNombre.Location = new System.Drawing.Point(445, 42);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxApell1
            // 
            this.textBoxApell1.Location = new System.Drawing.Point(623, 42);
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
            this.label2.Location = new System.Drawing.Point(395, 45);
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
            this.toolBarraPacientes.Size = new System.Drawing.Size(1270, 25);
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
            this.toolStripAltaPaciente.Click += new System.EventHandler(this.toolStripAltaPaciente_Click);
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
            this.toolStripBuscar.Click += new System.EventHandler(this.toolStripBuscar_Click);
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
            this.label3.Location = new System.Drawing.Point(173, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nif Representante";
            // 
            // textBoxNifRepre
            // 
            this.textBoxNifRepre.Location = new System.Drawing.Point(272, 42);
            this.textBoxNifRepre.Name = "textBoxNifRepre";
            this.textBoxNifRepre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNifRepre.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Apellido 1";
            // 
            // groupPacientes
            // 
            this.groupPacientes.Location = new System.Drawing.Point(28, 85);
            this.groupPacientes.Name = "groupPacientes";
            this.groupPacientes.Size = new System.Drawing.Size(1203, 415);
            this.groupPacientes.TabIndex = 18;
            this.groupPacientes.TabStop = false;
            this.groupPacientes.Text = "Listado de Pacientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(751, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Apellido 2";
            // 
            // textBoxApell2
            // 
            this.textBoxApell2.Location = new System.Drawing.Point(810, 42);
            this.textBoxApell2.Name = "textBoxApell2";
            this.textBoxApell2.Size = new System.Drawing.Size(100, 20);
            this.textBoxApell2.TabIndex = 16;
            // 
            // textBoxMovil
            // 
            this.textBoxMovil.Location = new System.Drawing.Point(980, 42);
            this.textBoxMovil.Name = "textBoxMovil";
            this.textBoxMovil.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovil.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(942, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Movil";
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 512);
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
            this.toolBarraPacientes.ResumeLayout(false);
            this.toolBarraPacientes.PerformLayout();
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
    }
}