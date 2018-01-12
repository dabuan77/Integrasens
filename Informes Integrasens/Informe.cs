using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes_Integrasens
{
    public class Informe
    {
        private string nombre;
        private string apelligo1;
        private string apelligo2;
        private string fechaNacimiento;
        private string responsableInforme;
        private string fechaElaboracion;
        private List<Pregunta> listaPreguntas = new List<Pregunta>();
        private int indicePreg;
        private string tipoInforme;
        private DateTime fechaHoy = DateTime.Now;
        private string[] lisPreg;
        private int i;
        private Pregunta preg;
        private int numPregContestadas = 0;

        public Informe(string n, string a1, string a2, string fn, string tp, string m)
        {
            nombre = n;
            apelligo1 = a1;
            apelligo2 = a2;
            fechaNacimiento = fn;
            fechaElaboracion = fechaHoy.ToString("d");
            tipoInforme = tp;
            indicePreg = 0;
            responsableInforme = m;

            if (tipoInforme == "7a35")
            {
                lisPreg = Program.Preguntas7a35;
                i = 0;
                foreach (string item in lisPreg)
                {
                    preg = new Pregunta(i, item, 0);
                    listaPreguntas.Add(preg);
                    i += 1;
                }
            }
        }

        public void setNombre(string n) { nombre = n; }
        public string getNombre() { return nombre; }

        public void setApellido1(string n) { apelligo1 = n; }
        public string getApellido1() { return apelligo1; }

        public void setApellido2(string n) { apelligo2 = n; }
        public string getApellido2() { return apelligo2; }

        public void setFechaNacimiento(string n) { fechaNacimiento = n; }
        public string getFechaNacimiento() { return fechaNacimiento; }

        public void setResponsableInforme(string r) { responsableInforme = r; }
        public string getResponsableInformea() { return responsableInforme; }

        public void setFechaElaboracion(string n) { fechaElaboracion = n; }
        public string getFechaElaboracion() { return fechaElaboracion; }

        public void setTipoInforme(string n) { tipoInforme = n; }
        public string getTipoInforme() { return tipoInforme; }

        public void setListaPreguntas(Pregunta p) { listaPreguntas.Add(p); }
        public List<Pregunta> getListaPreguntas() { return listaPreguntas; }

        //public void setIndicePreg(int n) { indicePreg = n; }
        public int getIndicePreg() { return indicePreg; }

        public int getNumPregContestadas() { return numPregContestadas; }

        public void incrementaIndicePreg()
        {
            indicePreg += 1;
            numPregContestadas += 1;
        }

        public void decrementaIndicePreg()
        {
            indicePreg -= 1;
        }

        public Pregunta damePregunta()
        {
            return listaPreguntas[indicePreg]; 
        }

        public int totalNumPreguntas()
        {
            return i;
        }

        public void InicializarResultadoPreg()
        {
            foreach (Pregunta item in listaPreguntas)
            {
                item.setResultadoPregunta(0);
            }

            setTipoInforme("");
        }
    }
}
