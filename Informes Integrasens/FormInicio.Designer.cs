namespace Informes_Integrasens
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.barraHerramintas = new System.Windows.Forms.ToolStrip();
            this.toolStripPacientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripInformes = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripAgenda = new System.Windows.Forms.ToolStripLabel();
            this.barraHerramintas.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraHerramintas
            // 
            this.barraHerramintas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPacientes,
            this.toolStripLabel1,
            this.toolStripInformes,
            this.toolStripLabel2,
            this.toolStripButton1,
            this.toolStripAgenda});
            this.barraHerramintas.Location = new System.Drawing.Point(0, 0);
            this.barraHerramintas.Name = "barraHerramintas";
            this.barraHerramintas.Size = new System.Drawing.Size(861, 25);
            this.barraHerramintas.TabIndex = 0;
            this.barraHerramintas.Text = "toolStrip1";
            // 
            // toolStripPacientes
            // 
            this.toolStripPacientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPacientes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPacientes.Image")));
            this.toolStripPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPacientes.Name = "toolStripPacientes";
            this.toolStripPacientes.Size = new System.Drawing.Size(23, 22);
            this.toolStripPacientes.Text = "Pacientes";
            this.toolStripPacientes.ToolTipText = "Pacientes";
            this.toolStripPacientes.Click += new System.EventHandler(this.toolStripPacientes_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "Pacientes";
            // 
            // toolStripInformes
            // 
            this.toolStripInformes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripInformes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripInformes.Image")));
            this.toolStripInformes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInformes.Name = "toolStripInformes";
            this.toolStripInformes.Size = new System.Drawing.Size(23, 22);
            this.toolStripInformes.Text = "Informes";
            this.toolStripInformes.Click += new System.EventHandler(this.toolStripInformes_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel2.Text = "Informes";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Agenda";
            // 
            // toolStripAgenda
            // 
            this.toolStripAgenda.Name = "toolStripAgenda";
            this.toolStripAgenda.Size = new System.Drawing.Size(48, 22);
            this.toolStripAgenda.Text = "Agenda";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(861, 437);
            this.Controls.Add(this.barraHerramintas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicio";
            this.Text = "Integrasens";
            this.barraHerramintas.ResumeLayout(false);
            this.barraHerramintas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraHerramintas;
        private System.Windows.Forms.ToolStripButton toolStripPacientes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripInformes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripAgenda;
    }
}