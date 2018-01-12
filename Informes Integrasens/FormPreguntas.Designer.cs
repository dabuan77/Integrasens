namespace Informes_Integrasens
{
    partial class FormPreguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreguntas));
            this.labelNumPreg = new System.Windows.Forms.Label();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.radioCasiSiempre = new System.Windows.Forms.RadioButton();
            this.radioFrecuentemente = new System.Windows.Forms.RadioButton();
            this.radioMitadTiempo = new System.Windows.Forms.RadioButton();
            this.radioNoAplicable = new System.Windows.Forms.RadioButton();
            this.radioCasiNunca = new System.Windows.Forms.RadioButton();
            this.radioOcasionalmente = new System.Windows.Forms.RadioButton();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumPreg
            // 
            this.labelNumPreg.AutoSize = true;
            this.labelNumPreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPreg.Location = new System.Drawing.Point(24, 24);
            this.labelNumPreg.Name = "labelNumPreg";
            this.labelNumPreg.Size = new System.Drawing.Size(96, 13);
            this.labelNumPreg.TabIndex = 0;
            this.labelNumPreg.Text = "Indice pregunta";
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Location = new System.Drawing.Point(27, 62);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(105, 13);
            this.labelPregunta.TabIndex = 1;
            this.labelPregunta.Text = "Texto de la pregunta";
            // 
            // radioCasiSiempre
            // 
            this.radioCasiSiempre.AutoSize = true;
            this.radioCasiSiempre.Location = new System.Drawing.Point(26, 30);
            this.radioCasiSiempre.Name = "radioCasiSiempre";
            this.radioCasiSiempre.Size = new System.Drawing.Size(84, 17);
            this.radioCasiSiempre.TabIndex = 1;
            this.radioCasiSiempre.TabStop = true;
            this.radioCasiSiempre.Text = "Casi siempre";
            this.radioCasiSiempre.UseVisualStyleBackColor = true;
            this.radioCasiSiempre.CheckedChanged += new System.EventHandler(this.radioCasiSiempre_CheckedChanged);
            // 
            // radioFrecuentemente
            // 
            this.radioFrecuentemente.AutoSize = true;
            this.radioFrecuentemente.Location = new System.Drawing.Point(26, 53);
            this.radioFrecuentemente.Name = "radioFrecuentemente";
            this.radioFrecuentemente.Size = new System.Drawing.Size(102, 17);
            this.radioFrecuentemente.TabIndex = 3;
            this.radioFrecuentemente.TabStop = true;
            this.radioFrecuentemente.Text = "Frecuentemente";
            this.radioFrecuentemente.UseVisualStyleBackColor = true;
            this.radioFrecuentemente.CheckedChanged += new System.EventHandler(this.radioFrecuentemente_CheckedChanged);
            // 
            // radioMitadTiempo
            // 
            this.radioMitadTiempo.AutoSize = true;
            this.radioMitadTiempo.Location = new System.Drawing.Point(26, 76);
            this.radioMitadTiempo.Name = "radioMitadTiempo";
            this.radioMitadTiempo.Size = new System.Drawing.Size(116, 17);
            this.radioMitadTiempo.TabIndex = 5;
            this.radioMitadTiempo.TabStop = true;
            this.radioMitadTiempo.Text = "La mitad del tiempo";
            this.radioMitadTiempo.UseVisualStyleBackColor = true;
            this.radioMitadTiempo.CheckedChanged += new System.EventHandler(this.radioMitadTiempo_CheckedChanged);
            // 
            // radioNoAplicable
            // 
            this.radioNoAplicable.AutoSize = true;
            this.radioNoAplicable.Location = new System.Drawing.Point(183, 76);
            this.radioNoAplicable.Name = "radioNoAplicable";
            this.radioNoAplicable.Size = new System.Drawing.Size(84, 17);
            this.radioNoAplicable.TabIndex = 6;
            this.radioNoAplicable.TabStop = true;
            this.radioNoAplicable.Text = "No aplicable";
            this.radioNoAplicable.UseVisualStyleBackColor = true;
            this.radioNoAplicable.CheckedChanged += new System.EventHandler(this.radioNoAplicable_CheckedChanged);
            // 
            // radioCasiNunca
            // 
            this.radioCasiNunca.AutoSize = true;
            this.radioCasiNunca.Location = new System.Drawing.Point(183, 53);
            this.radioCasiNunca.Name = "radioCasiNunca";
            this.radioCasiNunca.Size = new System.Drawing.Size(78, 17);
            this.radioCasiNunca.TabIndex = 4;
            this.radioCasiNunca.TabStop = true;
            this.radioCasiNunca.Text = "Casi nunca";
            this.radioCasiNunca.UseVisualStyleBackColor = true;
            this.radioCasiNunca.CheckedChanged += new System.EventHandler(this.radioCasiNunca_CheckedChanged);
            // 
            // radioOcasionalmente
            // 
            this.radioOcasionalmente.AutoSize = true;
            this.radioOcasionalmente.Location = new System.Drawing.Point(183, 30);
            this.radioOcasionalmente.Name = "radioOcasionalmente";
            this.radioOcasionalmente.Size = new System.Drawing.Size(101, 17);
            this.radioOcasionalmente.TabIndex = 2;
            this.radioOcasionalmente.TabStop = true;
            this.radioOcasionalmente.Text = "Ocasionalmente";
            this.radioOcasionalmente.UseVisualStyleBackColor = true;
            this.radioOcasionalmente.CheckedChanged += new System.EventHandler(this.radioOcasionalmente_CheckedChanged);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(272, 220);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.buttonSiguiente.TabIndex = 7;
            this.buttonSiguiente.Text = "Siguiente";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(79, 220);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCasiSiempre);
            this.groupBox1.Controls.Add(this.radioFrecuentemente);
            this.groupBox1.Controls.Add(this.radioMitadTiempo);
            this.groupBox1.Controls.Add(this.radioNoAplicable);
            this.groupBox1.Controls.Add(this.radioOcasionalmente);
            this.groupBox1.Controls.Add(this.radioCasiNunca);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 120);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(175, 220);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(75, 23);
            this.buttonAnterior.TabIndex = 8;
            this.buttonAnterior.Text = "Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // Form7a35Preg1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 255);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.labelPregunta);
            this.Controls.Add(this.labelNumPreg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7a35Preg1";
            this.Text = "Formulario de 7 a 35";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumPreg;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.RadioButton radioCasiSiempre;
        private System.Windows.Forms.RadioButton radioFrecuentemente;
        private System.Windows.Forms.RadioButton radioMitadTiempo;
        private System.Windows.Forms.RadioButton radioNoAplicable;
        private System.Windows.Forms.RadioButton radioCasiNunca;
        private System.Windows.Forms.RadioButton radioOcasionalmente;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAnterior;
    }
}