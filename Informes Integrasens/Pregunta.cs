using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informes_Integrasens
{
     public class Pregunta
    {
        private int numero;
        private string textoPregunta;
        private int resultadoPregunta;
        private bool contestadaPregunta;

        
        public Pregunta (int i, string t, int r)
        {
            numero = i;
            textoPregunta = t;
            resultadoPregunta = r;
            contestadaPregunta = false;
        }

        public void setNumero(int n) { numero = n; }
        public int getNumero() { return numero; }

        public void setTextoPregunta(string t) { textoPregunta = t; }
        public string getTextoPregunta() { return textoPregunta; }

        public void setResultadoPregunta(int r) { resultadoPregunta = r; }
        public int getResultadoPregunta() { return resultadoPregunta; }

        public void setContestadaPregunta() { contestadaPregunta = true; }
        public bool getContestadaPregunta() { return contestadaPregunta; }
    }
}
