namespace Informes_Integrasens
{
    partial class FormInformeIntegrasens
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformeIntegrasens));
            this.check7a35Meses = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textApellido2 = new System.Windows.Forms.TextBox();
            this.textApellido1 = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboTerapeuta = new System.Windows.Forms.ComboBox();
            this.textFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // check7a35Meses
            // 
            this.check7a35Meses.AutoSize = true;
            this.check7a35Meses.Location = new System.Drawing.Point(19, 230);
            this.check7a35Meses.Name = "check7a35Meses";
            this.check7a35Meses.Size = new System.Drawing.Size(89, 17);
            this.check7a35Meses.TabIndex = 6;
            this.check7a35Meses.Text = "7 a 35 meses";
            this.check7a35Meses.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Herramienta para generar Informes en Integrasens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el tipo de Informe a generar:";
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(318, 276);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.buttonSiguiente.TabIndex = 9;
            this.buttonSiguiente.Text = "Siguiente";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 276);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellido2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // textApellido2
            // 
            this.textApellido2.Location = new System.Drawing.Point(72, 112);
            this.textApellido2.MaxLength = 75;
            this.textApellido2.Name = "textApellido2";
            this.textApellido2.Size = new System.Drawing.Size(174, 20);
            this.textApellido2.TabIndex = 3;
            // 
            // textApellido1
            // 
            this.textApellido1.Location = new System.Drawing.Point(72, 88);
            this.textApellido1.MaxLength = 75;
            this.textApellido1.Name = "textApellido1";
            this.textApellido1.Size = new System.Drawing.Size(174, 20);
            this.textApellido1.TabIndex = 2;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(66, 62);
            this.textNombre.MaxLength = 75;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(180, 20);
            this.textNombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Elaboración del Informe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Datos del Paciente";
            // 
            // comboTerapeuta
            // 
            this.comboTerapeuta.FormattingEnabled = true;
            this.comboTerapeuta.Location = new System.Drawing.Point(140, 168);
            this.comboTerapeuta.Name = "comboTerapeuta";
            this.comboTerapeuta.Size = new System.Drawing.Size(133, 21);
            this.comboTerapeuta.TabIndex = 5;
            this.comboTerapeuta.Text = "Seleccione Terapeuta";
            // 
            // textFechaNacimiento
            // 
            this.textFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.textFechaNacimiento.Location = new System.Drawing.Point(130, 138);
            this.textFechaNacimiento.Name = "textFechaNacimiento";
            this.textFechaNacimiento.Size = new System.Drawing.Size(102, 20);
            this.textFechaNacimiento.TabIndex = 30;
            // 
            // FormInformeIntegrasens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 319);
            this.Controls.Add(this.textFechaNacimiento);
            this.Controls.Add(this.comboTerapeuta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textApellido1);
            this.Controls.Add(this.textApellido2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check7a35Meses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInformeIntegrasens";
            this.Text = "Informes Integrasens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check7a35Meses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textApellido2;
        private System.Windows.Forms.TextBox textApellido1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboTerapeuta;
        private System.Windows.Forms.DateTimePicker textFechaNacimiento;
    }
}

