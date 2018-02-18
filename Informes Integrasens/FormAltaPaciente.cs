using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes_Integrasens
{
    public partial class FormAltaPaciente : Form
    {
        string connstring = Properties.Settings.Default.IntegrasensConnectionString;

        public FormAltaPaciente()
        {

            InitializeComponent();

            textNombre.BackColor = Color.FromArgb(248, 250, 193);
            textApellido1.BackColor = Color.FromArgb(248, 250, 193);
            textApellido2.BackColor = Color.FromArgb(248, 250, 193);
            textNif.BackColor = Color.FromArgb(248, 250, 193);
            dateTimeFechaNac.CalendarTitleBackColor = Color.FromArgb(248, 250, 193);
            comboSexo.BackColor = Color.FromArgb(248, 250, 193);
            textNumHermanos.BackColor = Color.FromArgb(248, 250, 193);


            comboProvincia.BackColor = Color.FromArgb(248, 250, 193);
            comboPoblacion.BackColor = Color.FromArgb(248, 250, 193);
            textCodigoPostal.BackColor = Color.FromArgb(248, 250, 193);
            comboTipoVia.BackColor = Color.FromArgb(248, 250, 193);
            textNombreVia.BackColor = Color.FromArgb(248, 250, 193);
            textNumero.BackColor = Color.FromArgb(248, 250, 193);

            textMotivoConsulta.BackColor = Color.FromArgb(248, 250, 193);
            comboConocePor.BackColor = Color.FromArgb(248, 250, 193);

            try
            {

                using (OleDbConnection connexion2 = new OleDbConnection(connstring))

                {
                    string query = "SELECT Cod_Provincia, Provincia FROM Provincias order by Cod_Provincia";
                    OleDbDataAdapter daProvincia = new OleDbDataAdapter(query, connexion2);
                    DataTable dt = new DataTable();
                    daProvincia.Fill(dt);

                    comboProvincia.ValueMember = "Cod_Provincia";
                    comboProvincia.DisplayMember = "Provincia";
                    comboProvincia.DataSource = dt;

                    comboProvincia.SelectedIndexChanged += new EventHandler(ComboProvincia_SelectedIndexChanged);
                }
            }
            catch (Exception)
            {
                    MessageBox.Show("Error al informar las provincias, revise los datos introducidos");
            }
        }

        private bool ValidarDatosFormulario()
        {
            if (textNombre.Text == "") { tabDatosAlta.SelectedIndex = 0; textNombre.Focus(); MessageBox.Show("Debe informar el Nombre del Paciente");  return false; }
            if (textApellido1.Text == "") { tabDatosAlta.SelectedIndex = 0; textNombre.Focus(); MessageBox.Show("Debe informar el Apellido 1");  return false; }
            if (textApellido2.Text == "") { tabDatosAlta.SelectedIndex = 0; textNombre.Focus(); MessageBox.Show("Debe informar el Apellido 2");  return false; }

            if (dateTimeFechaNac.Value.ToShortDateString() == DateTime.Now.ToShortDateString()) { tabDatosAlta.SelectedIndex = 0; dateTimeFechaNac.Focus(); MessageBox.Show("Debe informar la Fecha de Nacimiento");  return false; }

            int dias = DateTime.Now.Date.Subtract(dateTimeFechaNac.Value.Date).Days;

            if (dias < 0) { tabDatosAlta.SelectedIndex = 0; dateTimeFechaNac.Focus(); MessageBox.Show("La fecha de nacimiento no puede ser posterior a la del dia");  return false; }
            int años = dias / 365;
            if (años >= 16)
            {
                if (textNif.Text == "") { tabDatosAlta.SelectedIndex = 0; textNif.Focus(); MessageBox.Show("Debe informar el Nif");  return false; };
                if (textMail.Text == "") { tabDatosAlta.SelectedIndex = 0; textNif.Focus(); MessageBox.Show("Debe informar el Mail"); return false; }
                if (textMovil.Text == "") { tabDatosAlta.SelectedIndex = 0; textNif.Focus(); MessageBox.Show("Debe informar el Movil"); return false; }
            }

            if (comboSexo.Text == "") { tabDatosAlta.SelectedIndex = 0; comboSexo.Focus(); MessageBox.Show("Debe informar el Sexo"); return false; }
            if (textNumHermanos.Text == "") { tabDatosAlta.SelectedIndex = 0; textNumero.Focus(); MessageBox.Show("Debe informar el numero de Hermanos");  return false; }


            if (años < 16)
            {
                if ((textNifPadre.Text == "" && textNombrePadre.Text == "" && textProfesionPadre.Text == "" && textMovilPadre.Text == "" && textMovilPadre.Text == "") ||
                    (textNifMadre.Text == "" && textNombreMadre.Text == "" && textProfesionMadre.Text == "" && textMovilMadre.Text == "" && textMovilMadre.Text == ""))
                {
                    tabDatosAlta.SelectedIndex = 1;
                    textNifPadre.Focus();
                    MessageBox.Show("Es obligatorio informar los datos del Padre o de la Madre del Paciente");
                    return false;
                }
            }

            if (comboProvincia.Text == "") { tabDatosAlta.SelectedIndex = 2; comboProvincia.Focus(); MessageBox.Show("Es obligatorio informar la Provincia");  return false; }
            if (comboPoblacion.Text == "") { tabDatosAlta.SelectedIndex = 2; comboProvincia.Focus(); MessageBox.Show("Es obligatorio informar la Poblacion");  return false; }
            if (textCodigoPostal.Text == "") { tabDatosAlta.SelectedIndex = 2; comboProvincia.Focus(); MessageBox.Show("Es obligatorio informar el CP"); return false; }
            int a = Convert.ToInt32(textCodigoPostal.Text.Substring(0, 2));
            int b = Convert.ToInt32(comboProvincia.SelectedValue);
            if (a != b) { tabDatosAlta.SelectedIndex = 2; comboProvincia.Focus(); MessageBox.Show("El CP no se corresponde con la provincia");  return false; }

            if (comboTipoVia.Text == "") { tabDatosAlta.SelectedIndex = 2; comboProvincia.Focus(); MessageBox.Show("Es obligatorio informar el Tipo de via");  return false; }
            if (textNombreVia.Text == "") { tabDatosAlta.SelectedIndex = 2; comboProvincia.Focus(); MessageBox.Show("Es obligatorio informar el Nombre de la via");  return false; }
            if (textNumero.Text == "") { tabDatosAlta.SelectedIndex = 2; comboProvincia.Focus(); MessageBox.Show("Es obligatorio informar el numero de la via");  return false; }

            if (textMotivoConsulta.Text == "") { tabDatosAlta.SelectedIndex = 3; textMotivoConsulta.Focus(); MessageBox.Show("Es obligatorio informar el motivo de la consulta");  return false; }
            if (comboConocePor.Text == "") { tabDatosAlta.SelectedIndex = 3; textMotivoConsulta.Focus(); MessageBox.Show("Es obligatorio informar como no ha conocido");  return false; }

            return true;
        }


        private void ToolStripGuardar_Click(object sender, EventArgs e)
        {
            string a = "";
            int cp = 0;
            int movil = 0;
            int movilP = 0;
            int movilM = 0;
            int telefono = 0;
            int telefonoP = 0;
            int telefonoM = 0;
            int hermanos = 0;

            if (ValidarDatosFormulario())
            {
                try
                {
                    cp = Convert.ToInt32(textCodigoPostal.Text);

                    if (textMovil.Text != "") { movil = Convert.ToInt32(textMovil.Text); }
                    if (textMovilPadre.Text != "") { movilP = Convert.ToInt32(textMovilPadre.Text); }
                    if (textMovilMadre.Text != "") { movilM = Convert.ToInt32(textMovilMadre.Text); }
                    if (textTelefono.Text != "") { telefono = Convert.ToInt32(textTelefono.Text); }
                    if (textTelefonoMadre.Text != "") { telefonoM = Convert.ToInt32(textTelefonoMadre.Text); }
                    if (textTelefonoPadre.Text != "") { telefonoP = Convert.ToInt32(textTelefonoPadre.Text); }

                    hermanos = Convert.ToInt16(textNumHermanos.Text);
                }
                catch (Exception)
                {
                        MessageBox.Show("Error convirtiendo datos numericos");
                }

                if (ValidaBBDDPacientes())
                {
                    try
                    {
                        //Añade fila a la tabla de Pacientes
                        IntegrasensDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter = new IntegrasensDataSetTableAdapters.PacientesTableAdapter();
                        pacientesTableAdapter.Insert(
                            textNif.Text.ToUpper(),
                            textNombre.Text.ToUpper(),
                            textApellido1.Text.ToUpper(),
                            textApellido2.Text.ToUpper(),
                            dateTimeFechaNac.Value,
                            comboSexo.Text.Substring(0, 1),
                            hermanos,
                            textAficiones.Text.ToUpper(),
                            movil,
                            textMail.Text.ToLower(),
                            textNifPadre.Text.ToUpper(),
                            textNombrePadre.Text.ToUpper(),
                            textMailPadre.Text.ToLower(),
                            movilP,
                            telefonoP,
                            textProfesionPadre.Text.ToUpper(),
                            textNifMadre.Text.ToUpper(),
                            textNombreMadre.Text.ToUpper(),
                            textMailMadre.Text.ToLower(),
                            movilM,
                            telefonoM,
                            textProfesionMadre.Text.ToUpper(),
                            comboProvincia.Text.ToUpper(),
                            comboPoblacion.Text.ToUpper(),
                            cp,
                            comboTipoVia.Text.ToUpper(),
                            textNombreVia.Text.ToUpper(),
                            textNumero.Text.ToUpper(),
                            textPiso.Text.ToUpper(),
                            textLetra.Text.ToUpper(),
                            textPortal.Text.ToUpper(),
                            textMedicacion.Text.ToUpper(),
                            textAlergias.Text.ToUpper(),
                            textEnfermedades.Text.ToUpper(),
                            a,
                            comboConocePor.Text.ToUpper(),
                            textMotivoConsulta.Text.ToUpper(),
                            checkBoxIndProteccionDatos.Checked,
                            checkBoxIndPublicidad.Checked,
                            false,
                            DateTime.Now,
                            Convert.ToDateTime("31/12/9999"),
                            DateTime.Now,
                            "ADMIN",
                            a,
                            telefono);

                        MessageBox.Show("Paciente registrado correctamente");
                        this.Close();
                    }
                        catch (Exception ex)
                    {
                        MessageBox.Show("Error insertando en la tabla de Pacientes, revise los datos. Error:" + ex.Message);
                    }
                }
            }
    }

        private bool ValidaBBDDPacientes()
        {

            int dias = DateTime.Now.Date.Subtract(dateTimeFechaNac.Value.Date).Days;

            int años = dias / 365;


            /* validamos que los datos no existan ya en la tabla introducido*/

            using (OleDbConnection connexion2 = new OleDbConnection(connstring))

            {
                try
                {
                    string query = "";

                    if (años >= 16)
                    {
                        query = "SELECT * FROM Pacientes where Nif = '" + textNif.Text.ToUpper() + "' or Movil = " + textMovil.Text.Trim() + " or ( Nombre = '" + textNombre.Text.ToUpper().Trim() + "' and Apellido1 ='" + textApellido1.Text.ToUpper().Trim() + "')";
                    }
                    else
                    {
                        query = "SELECT * FROM Pacientes where ((Nif_Padre = '" + textNifPadre.Text.ToUpper().Trim() + "' or Nif_Madre = '" + textNifMadre.Text.ToUpper().Trim() + "')" +
                                     "and Nombre = '" + textNombre.Text.ToUpper().Trim() + "' and Apellido1 ='" + textApellido1.Text.ToUpper().Trim() + "') or" +
                                     "((Movil_Padre =" + textMovilPadre.Text.Trim() + " or Movil_Madre =" + textMovilMadre.Text.Trim() + ")" +
                                     "and Nombre = '" + textNombre.Text.ToUpper().Trim() + "' and Apellido1 ='" + textApellido1.Text.ToUpper().Trim() + "')";
                    }

                   
                    OleDbDataAdapter daPacientes = new OleDbDataAdapter(query, connexion2);
                    DataTable dtPac = new DataTable();
                    daPacientes.Fill(dtPac);

                    if (dtPac.Rows.Count > 0)
                    {
                        tabDatosAlta.SelectedIndex = 0;
                        textNombre.Focus();
                        MessageBox.Show("El paciente ya está registrado");
                        return false;
                    }

                    return true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error en la consulta de Pacientes. Error=" + ex.Message );
                    return false;
                }

            }
        }

        private void FormAltaPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'integrasensDataSet.Tipos_via' 
            this.tipos_viaTableAdapter.Fill(this.integrasensDataSet.Tipos_via);

        }


        private void TextMovil_Leave(object sender, EventArgs e)
        {
            Regex rex = new Regex("[67]{1}[0-9]{8,8}$");
            TextBox campotxt = sender as TextBox;

            if (!rex.IsMatch(campotxt.Text) && campotxt.Text!="")
            {
                switch (campotxt.Name)
                {
                    case "textMovil":
                        textMovil.Focus();
                        break;
                    case "textMovilPadre":
                        textMovilPadre.Focus();
                        break;
                    case "textMovilMadre":
                        textMovilMadre.Focus();
                        break;
                    default:
                        break;
                }

                MessageBox.Show("El numero de movil no es válido");
                return;
            }
        }

        private void TextTelefono_Leave(object sender, EventArgs e)
        {
            Regex rex = new Regex("[89]{1}[0-9]{8,8}$");
            TextBox campotxt = sender as TextBox;

            if (!rex.IsMatch(campotxt.Text) && campotxt.Text != "")
            {
                switch (campotxt.Name)
                {
                    case "textTelefono":
                        textTelefono.Focus();
                        break;
                    case "textTelefonoPadre":
                        textTelefonoPadre.Focus();
                        break;
                    case "textTelefonoMadre":
                        textTelefonoMadre.Focus();
                        break;
                    default:
                        break;
                }

                MessageBox.Show("El numero de telefono no es válido");
                return;
            }
        }

        private void TextMail_Leave(object sender, EventArgs e)
        {
            TextBox campotxt = sender as TextBox;
            
            Regex rex = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            if (!rex.IsMatch(campotxt.Text) && campotxt.Text != "")
            {
                switch (campotxt.Name)
                {
                    case "textMail":
                        textMail.Focus();
                        break;
                    case "textMailPadre":
                        textMailPadre.Focus();
                        break;
                    case "textMailMadre":
                        textMailMadre.Focus();
                        break;
                    default:
                        break;
                }
                MessageBox.Show("El mail no tiene un formato válido");

            }
        }

        private void ValidarSoloTextooNumeros(object sender, KeyPressEventArgs e)
        {
            TextBox campotxt = sender as TextBox;

                switch (campotxt.Name)
                {
                    case "textNombre": 
                    case "textApellido1":
                    case "textApellido2":
                    case "textNombrePadre":
                    case "textProfesionPadre":
                    case "textNombreMadre":
                    case "textProfesionMadre":
                        Validaciones.SoloLetras(e);
                        break;

                    case "textNif":
                    case "textNifPadre":
                    case "textNifMadre":
                        Validaciones.SoloLetrasONumeros(e);
                        break;

                    case "textNumHermanos":
                    case "textTelefono":
                    case "textMovil":
                    case "textTelefonoPadre":
                    case "textMovilPadre":
                    case "textTelefonoMadre":
                    case "textMovilMadre":
                    case "textCodigoPostal":
                        Validaciones.SoloNumeros(e);
                        break;

                    default:
                        break;
                }           
        }

        private void TextNif_Leave(object sender, EventArgs e)
        {
            TextBox campotxt = sender as TextBox;

            if (!Validaciones.ValidarNIF(campotxt.Text) && campotxt.Text != "")
            {
                switch (campotxt.Name)
                {
                    case "textNif":
                        textNif.Focus();
                        break;
                    case "textNifPadre":
                        textNifPadre.Focus();
                        break;
                    case "textNifMadre":
                        textNifMadre.Focus();
                        break;
                    default:
                        break;
                }
                MessageBox.Show("Nif Erroneo o mal informado");
            }
        }


        private void ComboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProvincia.SelectedIndex != -1)
            {
                try
                {

                    using (OleDbConnection connexion2 = new OleDbConnection(connstring))

                    {
                        string query = "SELECT Poblacion FROM Poblaciones where Cod_Provincia in (0, " + comboProvincia.SelectedValue + ") order by Poblacion"; 
                        OleDbDataAdapter daPoblacion = new OleDbDataAdapter(query, connexion2);
                        DataTable dt = new DataTable();
                        daPoblacion.Fill(dt);
                        
                        comboPoblacion.ValueMember = "Poblacion";
                        comboPoblacion.DisplayMember = "Poblacion";
                        comboPoblacion.DataSource = dt;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al informar las poblaciones, revise los datos introducidos");
                }
            }
        }

        private void TextCodigoPostal_Leave(object sender, EventArgs e)
        {
            TextBox campotxt = sender as TextBox;

            Regex rex = new Regex("^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$");

            if (!rex.IsMatch(campotxt.Text) && campotxt.Text != "")
            {
                switch (campotxt.Name)
                {
                    case "textCodigoPostal":
                        textCodigoPostal.Focus();
                        break;

                    default:
                        break;
                }

                MessageBox.Show("El codigo postal no tiene un formato válido");

            }
        }

        private void DateTimeFechaNac_Leave(object sender, EventArgs e)
        {

            if (dateTimeFechaNac.Value.ToShortDateString() == DateTime.Now.ToShortDateString()) { MessageBox.Show("Debe informar la Fecha de Nacimiento"); tabDatosAlta.SelectedIndex = 0; dateTimeFechaNac.Focus(); return; }

            int dias = DateTime.Now.Date.Subtract(dateTimeFechaNac.Value.Date).Days;

            if (dias < 0) { MessageBox.Show("La fecha de nacimiento no puede ser posterior a la del dia"); tabDatosAlta.SelectedIndex = 0; dateTimeFechaNac.Focus(); return; }

            if (dias > 0)
            {
                int anos = dias / 365;

                if (anos > 16)
                {
                    textMovil.BackColor = Color.FromArgb(248, 250, 193);
                    textMail.BackColor = Color.FromArgb(248, 250, 193);

                    textNombreMadre.BackColor = Color.White;
                    textNifMadre.BackColor = Color.White;
                    textProfesionMadre.BackColor = Color.White;
                    textMovilMadre.BackColor = Color.White;
                    textMailMadre.BackColor = Color.White;
                    textNombrePadre.BackColor = Color.White;
                    textNifPadre.BackColor = Color.White;
                    textProfesionPadre.BackColor = Color.White;
                    textMovilPadre.BackColor = Color.White;
                    textMailPadre.BackColor = Color.White;
                }
                else
                {
                    textNombreMadre.BackColor = Color.FromArgb(234, 250, 202);
                    textNifMadre.BackColor = Color.FromArgb(234, 250, 202);
                    textProfesionMadre.BackColor = Color.FromArgb(234, 250, 202);
                    textMovilMadre.BackColor = Color.FromArgb(234, 250, 202);
                    textMailMadre.BackColor = Color.FromArgb(234, 250, 202);
                    textNombrePadre.BackColor = Color.FromArgb(234, 250, 202);
                    textNifPadre.BackColor = Color.FromArgb(234, 250, 202);
                    textProfesionPadre.BackColor = Color.FromArgb(234, 250, 202);
                    textMovilPadre.BackColor = Color.FromArgb(234, 250, 202);
                    textMailPadre.BackColor = Color.FromArgb(234, 250, 202);

                    textMovil.BackColor = Color.White;
                    textMail.BackColor = Color.White;
                }
            }
        }
    }
}
