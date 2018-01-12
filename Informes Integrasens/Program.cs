using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Informes_Integrasens
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        private static string[] _preguntas7a35;



        [STAThread]
        static void Main()
        {
            List<string> preguntas = new List<string>();
            string fichero = Path.Combine(Application.StartupPath, ConfigurationManager.AppSettings["ficheroInformeConfigPreg"]);

            string nodeInf7a35 = ConfigurationManager.AppSettings["nodeInf7a35meses"];
            string nodePre7a35 = ConfigurationManager.AppSettings["nodePreg7a35meses"];
            string nodeText7a35 = ConfigurationManager.AppSettings["nodeText7a35meses"];

            XmlDocument doc = new XmlDocument();
            doc.Load(fichero);

            XmlNodeList i7a35 = doc.GetElementsByTagName(nodeInf7a35);
            XmlNodeList preg = ((XmlElement)i7a35[0]).GetElementsByTagName(nodePre7a35);

            foreach (XmlElement item in preg)
            {
                XmlNodeList textPreg = item.GetElementsByTagName(nodeText7a35);
                preguntas.Add(textPreg[0].InnerText);
            }

            Program.Preguntas7a35 = preguntas.ToArray();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicio());
        }


        public static string [] Preguntas7a35
        {
            get { return _preguntas7a35; }
            set { _preguntas7a35 = value; }
        }
    }
}
