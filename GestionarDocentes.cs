using appBanco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appBanco.logica;
using Oracle.DataAccess.Client;

namespace FormulariosDeRegistro
{
    public partial class frmGesDocente : Form
    {
        private String codigo = "";
        public frmGesDocente(String codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

      


        private void btnRegistrarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                Docente DocenteReg = new Docente();
                //Asignación a las variables de los datos ingresados por el usuario
                double identificacion;
                double Codigo;
                int NroOficina;
                int resultado;
                string area, especializacion;
                identificacion = double.Parse(lblDatosPersonaRDocente.Text);
                Codigo = double.Parse(tbxRCodDocente.Text);
                NroOficina = int.Parse(tbxROficinaDocente.Text);
                area = tbxRCapAccDocente.Text;
                especializacion = tbxREspDocente.Text;
                resultado = DocenteReg.ingresarDocente(identificacion,Codigo,NroOficina,area,especializacion);
                //Creación Mensajes de validación
                if (resultado > 0)
                {
                    MessageBox.Show("Docente Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDatosPersonaRDocente.Text = "";
                    tbxRCodDocente.Text = "";
                    tbxROficinaDocente.Text = "";
                    tbxRCapAccDocente.Text = "";
                    tbxREspDocente.Text = "";
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 1)
                {
                    MessageBox.Show("Ya hay un Docente registrado con ese Codigo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 913)
                {
                    MessageBox.Show("Hubo un desbordamiento por demasiados valores, Intente de Nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblDatosPersonaRDocente.Text = "";
                    tbxRCodDocente.Text = "";
                    tbxROficinaDocente.Text = "";
                    tbxRCapAccDocente.Text = "";
                    tbxREspDocente.Text = "";
                }
            }
    }

        private void btnBuscarPersonaDocente_Click(object sender, EventArgs e)
        {
            try
            {
                Docente Docente = new Docente();
                double DocIdent;
                DocIdent = double.Parse(tbxConsultaIdDocente.Text);
                DataSet miDS = new DataSet();
                miDS = Docente.consultarXPersona(DocIdent);
                if (miDS.Tables[0].Rows.Count > 0)
                {
                    tbxConsultaIdDocente.Text = "";
                    lblDatosPersonaRDocente.Text = miDS.Tables[0].Rows[0]["persona_ident"].ToString();
                    lblNombrePersonaRDocente.Text = miDS.Tables[0].Rows[0]["persona_nombre"].ToString();
                    lblApePersonaRDocente.Text = miDS.Tables[0].Rows[0]["persona_apellido"].ToString();
                }
                else
                {
                    MessageBox.Show("El Cliente no esta registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 933)
                {
                    MessageBox.Show("Hubo un desbordamiento por demasiados valores, Intente de Nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxConsultaIdDocente.Text = "";
                }
            }
        }

        private void btnVerPreregistro_Click(object sender, EventArgs e)
        {

        }

        private void btnRegVolver_Click(object sender, EventArgs e)
        {

            inicioAdmin vtnPrincipalDef = new inicioAdmin(this.codigo);
            this.Close();
            vtnPrincipalDef.Show();

        }
    }
}
