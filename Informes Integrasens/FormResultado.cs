using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Informes_Integrasens
{
    public partial class FormResultado : Form
    {
        private Informe informe;

        public FormResultado(Informe informe)
        {
            InitializeComponent();
            this.informe = informe;
            if (informe.getTipoInforme() == "7a35") { labelTituloInforme.Text = "Informe de 7 a 35 meses"; };
            

            int x = 15;
            int y = 60;      
            int x1 = 65;
            int y1 = 55;
            int resulForm = 0;

            foreach (Pregunta item in informe.getListaPreguntas())
            {
                int ind = item.getNumero() + 1;
                Label label = new Label();
                TextBox text = new TextBox();
                label.Location = new Point(x, y);
                label.Size = new Size(45,15);
                text.Size = new Size(35, 20);
                text.Location = new Point(x1,y1);
                label.Text = "Preg " + ind;
                text.Text = item.getResultadoPregunta().ToString();
                this.Controls.Add(text);
                this.Controls.Add(label);
                resulForm += item.getResultadoPregunta();

                y1 = y1 + 30;                
                y = y + 30;

                if (ind == 6  || ind == 12 || ind == 18)
                {
                    x = x + 85;
                    x1 = x1 + 85;
                    y = 60;
                    y1 = 55;
                }
            }

            textResultado.Text = resulForm.ToString();
        }

        private void buttonGenerarInforme_Click(object sender, EventArgs e)
        {

        }
    }
}
