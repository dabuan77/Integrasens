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
    public partial class FormPreguntas : Form
    {
        private int resultado;
        public Informe informe;

        public FormPreguntas(Informe informe)
        {
            InitializeComponent();
            this.informe = informe;
            rellanarFormularioPreg();
        }

        private void radioCasiSiempre_CheckedChanged(object sender, EventArgs e)
        {
            resultado = 5;
        }

        private void radioFrecuentemente_CheckedChanged(object sender, EventArgs e)
        {
            resultado = 4;
        }

        private void radioMitadTiempo_CheckedChanged(object sender, EventArgs e)
        {
            resultado = 3;
        }

        private void radioOcasionalmente_CheckedChanged(object sender, EventArgs e)
        {
            resultado = 2;
        }

        private void radioCasiNunca_CheckedChanged(object sender, EventArgs e)
        {
            resultado = 1;
        }

        private void radioNoAplicable_CheckedChanged(object sender, EventArgs e)
        {
            resultado = 0;
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (!radioCasiNunca.Checked &&
                !radioCasiSiempre.Checked &&
                !radioFrecuentemente.Checked &&
                !radioMitadTiempo.Checked &&
                !radioNoAplicable.Checked &&
                !radioOcasionalmente.Checked)
            {
                MessageBox.Show("Debe seleccionar una opción para proseguir");
            }
            else
            {
                informe.damePregunta().setResultadoPregunta(resultado);
                informe.damePregunta().setContestadaPregunta();
                informe.incrementaIndicePreg();

                if (informe.getIndicePreg() < informe.totalNumPreguntas())
                {
                    rellanarFormularioPreg();
                    this.Refresh();
                }
                else
                {
                    FormResultado formResultado = new FormResultado(informe);
                    formResultado.Show();
                    this.Hide();
                }
            }
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            informe.decrementaIndicePreg();
            rellanarFormularioPreg();
            this.Refresh();
        }
                 
        private void rellanarFormularioPreg()
        {
            int a = informe.damePregunta().getNumero() + 1 ;
            labelPregunta.Text = informe.damePregunta().getTextoPregunta();
            labelNumPreg.Text = "Pregunta " + a + " de " + informe.totalNumPreguntas().ToString();

            this.groupBox1.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                radiobutton.AutoCheck = false;
                radiobutton.Checked = false;
                radiobutton.AutoCheck = true;
            });

            if (informe.damePregunta().getResultadoPregunta() == 5)
            {
                this.radioCasiSiempre.AutoCheck = false;
                this.radioCasiSiempre.Checked = true;
                this.radioCasiSiempre.AutoCheck = true;
            }
            else if (informe.damePregunta().getResultadoPregunta() == 4)
            {
                this.radioFrecuentemente.AutoCheck = true;
                this.radioFrecuentemente.Checked = true;
                this.radioFrecuentemente.AutoCheck = true;
            }
            else if (informe.damePregunta().getResultadoPregunta() == 3)
            {
                this.radioMitadTiempo.AutoCheck = true;
                this.radioMitadTiempo.Checked = true;
                this.radioMitadTiempo.AutoCheck = true;
            }
            else if (informe.damePregunta().getResultadoPregunta() == 2)
            {
                this.radioOcasionalmente.AutoCheck = true;
                this.radioOcasionalmente.Checked = true;
                this.radioOcasionalmente.AutoCheck = true;
            }
            else if (informe.damePregunta().getResultadoPregunta() == 1)
            {
                this.radioCasiNunca.AutoCheck = true;
                this.radioCasiNunca.Checked = true;
                this.radioCasiNunca.AutoCheck = true;
            }
            else if (informe.damePregunta().getContestadaPregunta())
            {
                this.radioNoAplicable.AutoCheck = true;
                this.radioNoAplicable.Checked = true;
                this.radioNoAplicable.AutoCheck = true;
            }


            buttonAnterior.Enabled = true;

            if (informe.damePregunta().getNumero() == 0)
            {
                buttonAnterior.Enabled = false;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            informe.InicializarResultadoPreg();
        }
    }
}
