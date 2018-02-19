using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes_Integrasens
{
    public class Paciente
    {
        private int idPaciente;
        private string nif;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private DateTime fechaNacimiento;
        private string sexo;
        private int numHermanos;
        private string aficiones;
        private int movil;
        private string mail;
        private string nifPadre;
        private string nombrePadre;
        private string mailPadre;
        private int movilPadre;
        private int telefonoPadre;
        private string profesionPadre;
        private string nifmadre;
        private string nombreMadre;
        private string mailMadre;
        private int movilMadre;
        private int telefonoMadre;
        private string profesionMadre;
        private string provincia;
        private string poblacion;
        private int codigoPostal;
        private string tipoVia;
        private string nombreVia;
        private string numeroVia;
        private string piso;
        private string letra;
        private string portal;
        private string patologia;
        private string alergias;
        private string enfermedad;
        private string cuentaCargo;
        private string conocePor;
        private string motivoConsulta;
        private bool indLopd;
        private bool indPublicidad;
        private bool indAlarma;
        private DateTime fechaAlta;
        private DateTime fechaBaja;
        private DateTime fechaModificacion;
        private string usuario;

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int NumHermanos { get => numHermanos; set => numHermanos = value; }
        public string Aficiones { get => aficiones; set => aficiones = value; }
        public int Movil { get => movil; set => movil = value; }
        public string Mail { get => mail; set => mail = value; }
        public string NifPadre { get => nifPadre; set => nifPadre = value; }
        public string NombrePadre { get => nombrePadre; set => nombrePadre = value; }
        public string MailPadre { get => mailPadre; set => mailPadre = value; }
        public int MovilPadre { get => movilPadre; set => movilPadre = value; }
        public int TelefonoPadre { get => telefonoPadre; set => telefonoPadre = value; }
        public string ProfesionPadre { get => profesionPadre; set => profesionPadre = value; }
        public string Nifmadre { get => nifmadre; set => nifmadre = value; }
        public string NombreMadre { get => nombreMadre; set => nombreMadre = value; }
        public string MailMadre { get => mailMadre; set => mailMadre = value; }
        public int MovilMadre { get => movilMadre; set => movilMadre = value; }
        public int TelefonoMadre { get => telefonoMadre; set => telefonoMadre = value; }
        public string ProfesionMadre { get => profesionMadre; set => profesionMadre = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public int CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string TipoVia { get => tipoVia; set => tipoVia = value; }
        public string NombreVia { get => nombreVia; set => nombreVia = value; }
        public string NumeroVia { get => numeroVia; set => numeroVia = value; }
        public string Piso { get => piso; set => piso = value; }
        public string Letra { get => letra; set => letra = value; }
        public string Portal { get => portal; set => portal = value; }
        public string Alergias { get => alergias; set => alergias = value; }
        public string Enfermedad { get => enfermedad; set => enfermedad = value; }
        public string CuentaCargo { get => cuentaCargo; set => cuentaCargo = value; }
        public string ConocePor { get => conocePor; set => conocePor = value; }
        public string MotivoConsulta { get => motivoConsulta; set => motivoConsulta = value; }
        public bool IndLopd { get => indLopd; set => indLopd = value; }
        public bool IndPublicidad { get => indPublicidad; set => indPublicidad = value; }
        public bool IndAlarma { get => indAlarma; set => indAlarma = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public DateTime FechaModificacion { get => fechaModificacion; set => fechaModificacion = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public Paciente()
        {
        }


        public Paciente(int idPac)
        {
           IdPaciente = idPac;

            try
            {

                using (OleDbConnection connexion2 = new OleDbConnection(Properties.Settings.Default.IntegrasensConnectionString))

                {
                    string query = "SELECT Id_Paciente, Nif, Nombre, Apellido1, Apellido2, FechaNacimiento, Sexo, Num_Hermanos, Aficiones, Movil, Mail, Nif_Padre, Nombre_Padre, Mail_Padre, Movil_Padre, Telefono_Padre, Profesion_Padre, Nif_Madre, Nombre_Madre, Mail_Madre, Movil_Madre, Telefono_Madre, Profesion_Madre, Provincia, Poblacion, Codigo_Postal, Tipo_via, Nombre_via, Numero, Piso, Letra, Portal, Medicacion, Alergias, Enfermedad, Cuenta_Cargo, Conoce_por, Motivo_Consulta, Ind_LOPD, Ind_Publicidad, Ind_Alarma, Fecha_Alta, Fecha_Baja, Fecha_Modificacion, Usuario, Nombre_Fichero_Lopd, Telefono FROM Pacientes where Id_Paciente = " + idPac;
                    OleDbDataAdapter daPacientes = new OleDbDataAdapter(query, connexion2);
                    DataTable dt = new DataTable();
                    daPacientes.Fill(dt);

                    DataRow row = dt.Rows[0];

                    Nif = row["Nif"].ToString();
                    Nombre = row["Nombre"].ToString();
                    Apellido1 = row["Apellido1"].ToString();
                    Apellido2 = row["Apellido2"].ToString();
                    FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"]);
                    Sexo = row["Sexo"].ToString();
                    NumHermanos = Convert.ToInt32(row["Num_Hermanos"]);
                    Aficiones = row["Aficiones"].ToString();
                    Movil = Convert.ToInt32(row["Movil"]);
                    Mail = row["Mail"].ToString();
                    NifPadre = row["Nif_Padre"].ToString();
                    NombrePadre = row["Nombre_Padre"].ToString();
                    MailPadre = row["Mail_Padre"].ToString();
                    MovilPadre = Convert.ToInt32(row["Movil_Padre"]);
                    TelefonoPadre = Convert.ToInt32(row["Telefono_Padre"]);
                    ProfesionPadre = row["Profesion_Padre"].ToString();
                    Nifmadre = row["Nif_madre"].ToString();
                    NombreMadre = row["Nombre_Madre"].ToString();
                    MailMadre = row["Mail_Madre"].ToString();
                    MovilMadre = Convert.ToInt32(row["Movil_Madre"]);
                    TelefonoMadre = Convert.ToInt32(row["Telefono_Madre"]);
                    ProfesionMadre = row["Profesion_Madre"].ToString();
                    Provincia = row["Provincia"].ToString();
                    Poblacion = row["Poblacion"].ToString();
                    CodigoPostal = Convert.ToInt32(row["Codigo_Postal"]);
                    TipoVia = row["Tipo_Via"].ToString();
                    NombreVia = row["Nombre_Via"].ToString();
                    NumeroVia = row["Numero"].ToString();
                    Piso = row["Piso"].ToString();
                    Letra = row["Letra"].ToString();
                    Portal = row["Portal"].ToString();
                    Alergias = row["Alergias"].ToString();
                    Enfermedad = row["Enfermedad"].ToString();
                    CuentaCargo = row["Cuenta_Cargo"].ToString();
                    ConocePor = row["Conoce_por"].ToString();
                    MotivoConsulta = row["Motivo_Consulta"].ToString();
                    IndLopd = Convert.ToBoolean(row["Ind_Lopd"]);
                    IndPublicidad = Convert.ToBoolean(row["Ind_Publicidad"]);
                    IndAlarma = Convert.ToBoolean(row["Ind_Alarma"]);
                    FechaAlta = Convert.ToDateTime(row["Fecha_Alta"]);
                    FechaBaja = Convert.ToDateTime(row["Fecha_Baja"]);
                    FechaModificacion = Convert.ToDateTime(row["Fecha_Modificacion"]);
                    Usuario = row["Usuario"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al acceder a la tabla de Pacientes para generar clase Paciente. Error:" + ex.Message);
                return;
            }
        }
    }
}
