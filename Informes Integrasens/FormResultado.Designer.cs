namespace Informes_Integrasens
{
    partial class FormResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultado));
            this.buttonGenerarInforme = new System.Windows.Forms.Button();
            this.buttonTerminar = new System.Windows.Forms.Button();
            this.labelTituloInforme = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGenerarInforme
            // 
            this.buttonGenerarInforme.Location = new System.Drawing.Point(257, 301);
            this.buttonGenerarInforme.Name = "buttonGenerarInforme";
            this.buttonGenerarInforme.Size = new System.Drawing.Size(96, 23);
            this.buttonGenerarInforme.TabIndex = 0;
            this.buttonGenerarInforme.Text = "Generar Informe";
            this.buttonGenerarInforme.UseVisualStyleBackColor = true;
            this.buttonGenerarInforme.Click += new System.EventHandler(this.buttonGenerarInforme_Click);
            // 
            // buttonTerminar
            // 
            this.buttonTerminar.Location = new System.Drawing.Point(158, 301);
            this.buttonTerminar.Name = "buttonTerminar";
            this.buttonTerminar.Size = new System.Drawing.Size(75, 23);
            this.buttonTerminar.TabIndex = 1;
            this.buttonTerminar.Text = "Terminar";
            this.buttonTerminar.UseVisualStyleBackColor = true;
            // 
            // labelTituloInforme
            // 
            this.labelTituloInforme.AutoSize = true;
            this.labelTituloInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloInforme.Location = new System.Drawing.Point(12, 19);
            this.labelTituloInforme.Name = "labelTituloInforme";
            this.labelTituloInforme.Size = new System.Drawing.Size(106, 13);
            this.labelTituloInforme.TabIndex = 2;
            this.labelTituloInforme.Text = "Titulo del Informe";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(274, 256);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(36, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total";
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(316, 253);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(37, 20);
            this.textResultado.TabIndex = 8;
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 336);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTituloInforme);
            this.Controls.Add(this.buttonTerminar);
            this.Controls.Add(this.buttonGenerarInforme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResultado";
            this.Text = "Resultado del Informe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerarInforme;
        private System.Windows.Forms.Button buttonTerminar;
        private System.Windows.Forms.Label labelTituloInforme;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textResultado;
    }
}