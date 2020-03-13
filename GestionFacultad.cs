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

namespace appBanco
{
    public partial class GestionFacultad : Form
    {
        private String codigo = "";
        public GestionFacultad(String codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

        //VentanaPrincipalDef vtnPrincipalDef = new VentanaPrincipalDef();
        Validacion validar = new Validacion();

        private void btnRegFacultad_Click(object sender, EventArgs e)
        {
            try
            {
                Facultad facu = new Facultad();
                int codigo, resultado;
                String nombreFac, nombreDecano;
                codigo = int.Parse(txtCodFacultad.Text);
                nombreFac = txtNombreFacultad.Text;
                nombreDecano = txtNomDecFacultad.Text;
                resultado = facu.registrarFacultad(codigo, nombreFac, nombreDecano);

                if (resultado > 0)
                {
                    MessageBox.Show("Facultad Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodFacultad.Text = "";
                    txtNombreFacultad.Text = "";
                    txtNomDecFacultad.Text = "";

                }
            }
            catch(OracleException ex)
            {
                if (ex.Number == 1)
                {
                    MessageBox.Show("Ya hay una facultad registrada con esa identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 913)
                {
                    MessageBox.Show("Hubo un desbordamiento por demasiados valores, Intente de Nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodFacultad.Text = "";
                    txtNombreFacultad.Text = "";
                    txtNomDecFacultad.Text = "";
                }
            }
        }

        private void btnSalirFac_Click(object sender, EventArgs e)
        {
            inicioAdmin vtnPrincipalDef = new inicioAdmin(this.codigo);
            this.Close();
            vtnPrincipalDef.Show();
        }

    }
}
